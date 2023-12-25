using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PartApp
{
    public partial class ModifyProduct : Form
    {
        private Product _currentProduct;
        private BindingList<Part> _availableParts;

        public ModifyProduct(int productId)
        {
            InitializeComponent();
            _currentProduct = ProductDataStore.GetProductById(productId);
            if (_currentProduct == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            SetupDataGridViewColumns(dgvAllParts);
            SetupDataGridViewColumns(dgvAssociatedParts);
            LoadProductData();
        }

        private void LoadProductData()
        {
            txtProductId.Text = _currentProduct.ProductId.ToString();
            txtName.Text = _currentProduct.Name;
            txtInventory.Text = _currentProduct.InStock.ToString();
            txtPrice.Text = _currentProduct.Price.ToString("C2");
            txtMin.Text = _currentProduct.Min.ToString();
            txtMax.Text = _currentProduct.Max.ToString();

            _availableParts = new BindingList<Part>(
                ProductDataStore.AllParts.Except(_currentProduct.AssociatedParts).ToList()
            );

            dgvAllParts.DataSource = _availableParts;
            dgvAssociatedParts.DataSource = _currentProduct.AssociatedParts;
        }

        private void SetupDataGridViewColumns(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoGenerateColumns = false;

            dgv.Columns.Clear();

            dgv.Columns.Add(CreateTextBoxColumn("PartId", "Part ID"));
            dgv.Columns.Add(CreateTextBoxColumn("Name", "Name"));
            dgv.Columns.Add(CreateTextBoxColumn("InStock", "Inventory"));
            dgv.Columns.Add(CreateTextBoxColumn("Price", "Price"));
            dgv.Columns.Add(CreateTextBoxColumn("Min", "Min"));
            dgv.Columns.Add(CreateTextBoxColumn("Max", "Max"));

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgv.Refresh();
        }

        private DataGridViewTextBoxColumn CreateTextBoxColumn(string dataPropertyName, string headerText)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = $"column{dataPropertyName}"
            };
        }

        private void ModifyProductSaveBT_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInventory.Text, out int inventory) ||
                !decimal.TryParse(txtPrice.Text.Substring(1), out decimal price) || 
                !int.TryParse(txtMin.Text, out int min) ||
                !int.TryParse(txtMax.Text, out int max))
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Update the product in the global store
                _currentProduct.Name = txtName.Text;
                _currentProduct.Price = price;
                _currentProduct.Max = max; 
                _currentProduct.Min = min;
                _currentProduct.InStock = inventory; 
                ProductDataStore.UpdateProduct(_currentProduct);

                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyProductCancelBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null) return;

            var partToAdd = (Part)dgvAllParts.CurrentRow.DataBoundItem;
            _currentProduct.AddAssociatedPart(partToAdd);
            _availableParts.Remove(partToAdd);

            dgvAssociatedParts.DataSource = new BindingList<Part>(_currentProduct.AssociatedParts);
            dgvAllParts.Refresh();
            dgvAssociatedParts.Refresh();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null) return;

            var partToRemove = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to remove '{partToRemove.Name}' from this product?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _currentProduct.RemoveAssociatedPart(partToRemove.PartId);
                _availableParts.Add(partToRemove);

                dgvAssociatedParts.DataSource = new BindingList<Part>(_currentProduct.AssociatedParts);
                dgvAllParts.Refresh();
                dgvAssociatedParts.Refresh();
            }
        }
    }
}
