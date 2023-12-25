using System;
using System.Windows.Forms;

namespace PartApp
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            InitializeRadioButtons();
        }

        private void InitializeRadioButtons()
        {
            radioInHouse.CheckedChanged += (sender, e) => ToggleCompanyNameMachineIDFields();
            radioOutsourced.CheckedChanged += (sender, e) => ToggleCompanyNameMachineIDFields();
            ToggleCompanyNameMachineIDFields();
        }

        private void ToggleCompanyNameMachineIDFields()
        {
            labelMachineID.Visible = txtMachineID.Visible = radioInHouse.Checked;
            labelCompanyName.Visible = txtCompanyName.Visible = radioOutsourced.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFormFields())
            {
                return;
            }
            Part newPart = CreatePartFromFormData();
            if (newPart != null)
            {
                ProductDataStore.AllParts.Add(newPart);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateFormFields()
        {
            if (!int.TryParse(txtInventory.Text.Trim(), out int inventory) || inventory < 0)
            {
                ShowInputError("Inventory", "Please enter a valid non-negative integer for Inventory.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                ShowInputError("Price/Cost", "Please enter a valid non-negative decimal number for Price/Cost.");
                return false;
            }

            if (!int.TryParse(txtMin.Text.Trim(), out int min) || min < 0)
            {
                ShowInputError("Min", "Please enter a valid non-negative integer for Min.");
                return false;
            }

            if (!int.TryParse(txtMax.Text.Trim(), out int max) || max <= min)
            {
                ShowInputError("Max", "Please enter a valid integer for Max that is greater than Min.");
                return false;
            }

            if (min > max)
            {
                MessageBox.Show("Min should not be greater than Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!radioInHouse.Checked && !radioOutsourced.Checked)
            {
                MessageBox.Show("Please select a part type: In-House or Outsourced.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (radioInHouse.Checked && !int.TryParse(txtMachineID.Text.Trim(), out _))
            {
                ShowInputError("Machine ID", "Please enter a valid integer for Machine ID.");
                return false;
            }

            if (radioOutsourced.Checked && string.IsNullOrWhiteSpace(txtCompanyName.Text.Trim()))
            {
                ShowInputError("Company Name", "Please enter a Company Name.");
                return false;
            }

            return true;
        }

        private void ShowInputError(string fieldName, string errorMessage)
        {
            MessageBox.Show(errorMessage, $"Invalid {fieldName}", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Part CreatePartFromFormData()
        {
            int partId = ProductDataStore.GeneratePartId();
            string name = txtName.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text.Trim());
            int inventory = int.Parse(txtInventory.Text.Trim());
            int min = int.Parse(txtMin.Text.Trim());
            int max = int.Parse(txtMax.Text.Trim());

            if (radioInHouse.Checked)
            {
                int machineId = int.Parse(txtMachineID.Text.Trim());
                return new Inhouse(partId, name, price, inventory, min, max, machineId);
            }
            else
            {
                string companyName = txtCompanyName.Text.Trim();
                return new Outsourced(partId, name, price, inventory, min, max, companyName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
