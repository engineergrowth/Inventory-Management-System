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

        private void ModifyProductSaveBT_Click(object sender, EventArgs e)
        {
            if (!TryParseFormFields(out int inventory, out decimal price, out int min, out int max))
            {
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min should be less than Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UpdateProduct(inventory, price, min, max);
                this.DialogResult = DialogResult.OK; // Indicate success
                Close(); // Close the form
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryParseFormFields(out int inventory, out decimal price, out int min, out int max)
        {
            bool inventoryValid = int.TryParse(txtInventory.Text, out inventory);
            bool priceValid = decimal.TryParse(txtPrice.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            bool minValid = int.TryParse(txtMin.Text, out min);
            bool maxValid = int.TryParse(txtMax.Text, out max);

            if (!inventoryValid || !priceValid || !minValid || !maxValid)
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void UpdateProduct(int inventory, decimal price, int min, int max)
        {
            _currentProduct.Name = txtName.Text;
            _currentProduct.InStock = inventory;
            _currentProduct.Price = price;
            _currentProduct.Min = min;
            _currentProduct.Max = max;

            ProductDataStore.UpdateProduct(_currentProduct);
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
