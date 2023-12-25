using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PartApp
{
    public partial class AddProduct : Form
    {
        private BindingList<Part> _availableParts;
        private BindingList<Part> _associatedParts;

        public AddProduct()
        {
            InitializeComponent();
            SetupDataGridViewColumns(dgvAllParts);
            SetupDataGridViewColumns(dgvAssociatedParts);
            _availableParts = new BindingList<Part>(ProductDataStore.AllParts);
            _associatedParts = new BindingList<Part>();

            dgvAllParts.DataSource = _availableParts;
            dgvAssociatedParts.DataSource = _associatedParts;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInventory.Text, out int inventory) ||
                !decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtMin.Text, out int min) ||
                !int.TryParse(txtMax.Text, out int max))
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and Max.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            var newProduct = new Product(
                ProductDataStore.GenerateProductId(),
                txtName.Text,
                price,
                inventory,
                min,
                max
            );

            foreach (var part in _associatedParts)
            {
                newProduct.AddAssociatedPart(part);
            }

            ProductDataStore.AddProduct(newProduct);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null) return;

            var partToAdd = (Part)dgvAllParts.CurrentRow.DataBoundItem;
            _associatedParts.Add(partToAdd);

            dgvAssociatedParts.Refresh();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null) return;

            var partToRemove = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;
            _associatedParts.Remove(partToRemove);

            dgvAssociatedParts.Refresh();
        }
    }
}
