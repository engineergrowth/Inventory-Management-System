using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PartApp
{
    public partial class MainForm : Form
    {
        private Inventory _inventory;

        public MainForm(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshPartsGrid();
            RefreshProductsGrid();
            MainPartDGV.ReadOnly = true;
            MainProductDGV.ReadOnly = true;
            MainPartDGV.RowHeadersVisible = false;
            MainProductDGV.RowHeadersVisible = false;
        }

        private void PartSearchBT_Click(object sender, EventArgs e)
        {
            SearchParts();
        }

        private void ProductsSearchBT_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void AddPartBT_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(_inventory);
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
                RefreshPartsGrid();
            }
        }

        private void ModifyPartBT_Click(object sender, EventArgs e)
        {
            if (MainPartDGV.CurrentRow != null)
            {
                int partId = Convert.ToInt32(MainPartDGV.CurrentRow.Cells["PartId"].Value);
                Part partToModify = GetPartById(partId);
                if (partToModify != null)
                {
                    ModifyPart modifyPartForm = new ModifyPart(partId, _inventory); 
                    modifyPartForm.InitialParts = _inventory.AllParts.ToList(); 
                    if (modifyPartForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshPartsGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to modify.", "No Part Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void DeletePartBT_Click(object sender, EventArgs e)
        {
            if (MainPartDGV.CurrentRow != null)
            {
                int partId = Convert.ToInt32(MainPartDGV.CurrentRow.Cells["PartId"].Value);
                var confirmResult = MessageBox.Show("Are you sure to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeletePart(partId);
                    RefreshPartsGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "No Part Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddProductBT_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(_inventory); // Pass the Inventory object
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                RefreshProductsGrid();
            }
        }

        private void ModifyProductBT_Click(object sender, EventArgs e)
        {
            if (MainProductDGV.CurrentRow != null)
            {
                int productId = Convert.ToInt32(MainProductDGV.CurrentRow.Cells["ProductId"].Value);
                ModifyProduct modifyProductForm = new ModifyProduct(productId, _inventory.Products, _inventory.AllParts); // Pass the Inventory object, initialProducts, and initialParts
                if (modifyProductForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshProductsGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteProductBT_Click(object sender, EventArgs e)
        {
            if (MainProductDGV.CurrentRow != null)
            {
                int productId = Convert.ToInt32(MainProductDGV.CurrentRow.Cells["ProductId"].Value);
                Product productToDelete = GetProductById(productId);

                if (productToDelete != null && productToDelete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has parts associated with it.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteProduct(productId);
                    RefreshProductsGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchParts()
        {
            var searchText = PartSearchBox.Text.ToLower();
            MainPartDGV.DataSource = string.IsNullOrWhiteSpace(searchText)
                ? _inventory.AllParts
                : new BindingList<Part>(_inventory.AllParts.Where(part => part.Name.ToLower().Contains(searchText)).ToList());
        }

        private void SearchProducts()
        {
            var searchText = ProductSearchBox.Text.ToLower();
            MainProductDGV.DataSource = string.IsNullOrWhiteSpace(searchText)
                ? _inventory.Products
                : new BindingList<Product>(_inventory.Products.Where(product => product.Name.ToLower().Contains(searchText)).ToList());
        }

        private void RefreshPartsGrid()
        {
            MainPartDGV.DataSource = null;
            MainPartDGV.DataSource = _inventory.AllParts;
        }

        private void RefreshProductsGrid()
        {
            MainProductDGV.DataSource = null;
            MainProductDGV.DataSource = _inventory.Products;
        }

        private void DeletePart(int partId)
        {
            Part partToDelete = GetPartById(partId);
            if (partToDelete != null)
            {
                _inventory.DeletePart(partToDelete);
            }
        }

        private void DeleteProduct(int productId)
        {
            Product productToDelete = GetProductById(productId);
            if (productToDelete != null)
            {
                _inventory.Products.Remove(productToDelete);
            }
        }

        private Part GetPartById(int partId)
        {
            return _inventory.LookupPart(partId);
        }

        private Product GetProductById(int productId)
        {
            return _inventory.LookupProduct(productId);
        }
    }
}
