using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PartApp
{
    public partial class ModifyPart : Form
    {
        private Part _currentPart;
        private Inventory _inventory;
        private List<Part> _initialParts; 

      
        public List<Part> InitialParts
        {
            get { return _initialParts; }
            set { _initialParts = value; }
        }

        public ModifyPart(int partId, Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            _currentPart = _inventory.LookupPart(partId);
            if (_currentPart == null)
            {
                MessageBox.Show("Part not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            LoadPartDetails();
            SetupRadioButtons();
        }

        private void LoadPartDetails()
        {
            txtPartId.Text = _currentPart.PartId.ToString();
            txtName.Text = _currentPart.Name;
            txtInventory.Text = _currentPart.InStock.ToString();
            txtPrice.Text = _currentPart.Price.ToString("C");
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
            ToggleCompanyNameMachineIDFields();
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
                Part updatedPart;
                if (radioInHouse.Checked)
                {
                    if (int.TryParse(txtMachineID.Text, out int machineId))
                    {
                        updatedPart = new Inhouse(
                            _currentPart.PartId,
                            txtName.Text,
                            price,
                            inventory,
                            min,
                            max,
                            machineId);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Machine ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    updatedPart = new Outsourced(
                        _currentPart.PartId,
                        txtName.Text,
                        price,
                        inventory,
                        min,
                        max,
                        txtCompanyName.Text);
                }

                _inventory.UpdatePart(_currentPart.PartId, updatedPart);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating part: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdatePart(int inventory, decimal price, int min, int max)
        {
            _currentPart.Name = txtName.Text;
            _currentPart.InStock = inventory;
            _currentPart.Price = price;
            _currentPart.Min = min;
            _currentPart.Max = max;

            if (radioInHouse.Checked && _currentPart is Inhouse inhousePart)
            {
                if (int.TryParse(txtMachineID.Text, out int machineId))
                {
                    inhousePart.MachineId = machineId;
                }
                else
                {
                    MessageBox.Show("Invalid Machine ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (radioOutsourced.Checked && _currentPart is Outsourced outsourcedPart)
            {
                outsourcedPart.CompanyName = txtCompanyName.Text;
            }

            _inventory.UpdatePart(_currentPart.PartId, _currentPart); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
