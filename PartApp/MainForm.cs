using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PartApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            AddPart addPartForm = new AddPart();
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
                ModifyPart modifyPartForm = new ModifyPart(partId);
                if (modifyPartForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshPartsGrid();
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
                    ProductDataStore.DeletePart(partId);
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
            AddProduct addProductForm = new AddProduct();
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
                ModifyProduct modifyProductForm = new ModifyProduct(productId);
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
                Product productToDelete = ProductDataStore.GetProductById(productId);

                if (productToDelete != null && productToDelete.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has parts associated with it.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    ProductDataStore.DeleteProduct(productId);
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
                ? ProductDataStore.AllParts
                : new BindingList<Part>(ProductDataStore.AllParts.Where(part => part.Name.ToLower().Contains(searchText)).ToList());
        }

        private void SearchProducts()
        {
            var searchText = ProductSearchBox.Text.ToLower();
            MainProductDGV.DataSource = string.IsNullOrWhiteSpace(searchText)
                ? ProductDataStore.Products
                : new BindingList<Product>(ProductDataStore.Products.Where(product => product.Name.ToLower().Contains(searchText)).ToList());
        }

        private void RefreshPartsGrid()
        {
            MainPartDGV.DataSource = null;
            MainPartDGV.DataSource = ProductDataStore.AllParts;
        }

        private void RefreshProductsGrid()
        {
            MainProductDGV.DataSource = null;
            MainProductDGV.DataSource = ProductDataStore.Products;
        }
    }
}

