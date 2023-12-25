using System;
using System.Linq;
using System.Windows.Forms;

namespace PartApp
{
    public partial class ModifyPart : Form
    {
        private Part _currentPart;

        public ModifyPart(int partId)
        {
            InitializeComponent();
            _currentPart = ProductDataStore.GetPartById(partId);
            if (_currentPart == null)
            {
                MessageBox.Show("Part not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            LoadPartDetails();
            SetupRadioButtons();
            ToggleCompanyNameMachineIDFields();
        }

        private void LoadPartDetails()
        {
            txtPartId.Text = _currentPart.PartId.ToString();
            txtName.Text = _currentPart.Name;
            txtInventory.Text = _currentPart.InStock.ToString();
            txtPrice.Text = _currentPart.Price.ToString("C2");
            txtMin.Text = _currentPart.Min.ToString();
            txtMax.Text = _currentPart.Max.ToString();
            if (_currentPart is Inhouse inhousePart)
            {
                radioInHouse.Checked = true;
                txtMachineID.Text = inhousePart.MachineId.ToString();
            }
            else if (_currentPart is Outsourced outsourcedPart)
            {
                radioOutsourced.Checked = true;
                txtCompanyName.Text = outsourcedPart.CompanyName;
            }
        }

        private void SetupRadioButtons()
        {
            radioInHouse.CheckedChanged += (sender, e) => ToggleCompanyNameMachineIDFields();
            radioOutsourced.CheckedChanged += (sender, e) => ToggleCompanyNameMachineIDFields();
        }

        private void ToggleCompanyNameMachineIDFields()
        {
            bool inHouseSelected = radioInHouse.Checked;
            labelMachineID.Visible = txtMachineID.Visible = inHouseSelected;
            labelCompanyName.Visible = txtCompanyName.Visible = !inHouseSelected;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!TryParseFormFields(out int inventory, out decimal price, out int min, out int max))
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and Max.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Min should be less than Max.");
                return;
            }
            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }
            UpdatePart(inventory, price, min, max);
            Close();
        }

        private bool TryParseFormFields(out int inventory, out decimal price, out int min, out int max)
        {
            inventory = 0;
            price = 0m;
            min = 0;
            max = 0;
            bool inventoryValid = int.TryParse(txtInventory.Text, out inventory);
            bool priceValid = decimal.TryParse(txtPrice.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            bool minValid = int.TryParse(txtMin.Text, out min);
            bool maxValid = int.TryParse(txtMax.Text, out max);
            return inventoryValid && priceValid && minValid && maxValid;
        }

        private void UpdatePart(int inventory, decimal price, int min, int max)
        {
            _currentPart.Name = txtName.Text;
            _currentPart.InStock = inventory;
            _currentPart.Price = price;
            _currentPart.Min = min;
            _currentPart.Max = max;
            if (radioInHouse.Checked)
            {
                if (_currentPart is Inhouse inhousePart)
                {
                    if (int.TryParse(txtMachineID.Text, out int machineId))
                    {
                        inhousePart.MachineId = machineId;
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Machine ID.");
                    }
                }
                else
                {
                    throw new ApplicationException("Part is not of type Inhouse.");
                }
            }
            else if (radioOutsourced.Checked)
            {
                if (_currentPart is Outsourced outsourcedPart)
                {
                    outsourcedPart.CompanyName = txtCompanyName.Text;
                }
                else
                {
                    throw new ApplicationException("Part is not of type Outsourced.");
                }
            }
            ProductDataStore.UpdatePart(_currentPart);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
