using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class ModifyPartForm : Form
    {
        public Parts SelectedPart { get; set; }

        public ModifyPartForm()
        {
            InitializeComponent();
            modifyPartIDValue.Enabled = false;




            //modifyPartIDValue.Text = Inventory.Parts.PartID.ToString();
        }

        public ModifyPartForm(Parts selectedPart)
        {
            SelectedPart = selectedPart;
            InitializeComponent();
            modifyPartIDValue.Text = SelectedPart.PartID.ToString();
            modifyPartNameValue.Text = SelectedPart.Name;
            inventoryValue.Text = SelectedPart.InStock.ToString();
            priceCostValue.Text = SelectedPart.Price.ToString();
            maxValue.Text = SelectedPart.Max.ToString();
            minValue.Text = SelectedPart.Min.ToString();
            if (selectedPart is InHouse)
            {
                inHouseRadioBtn.Checked = true;
                ValueSwitch.Text = ((InHouse)SelectedPart).MachineID.ToString();
            }
            else
            {
                outsourcedRadioBtn.Checked = true;
                ValueSwitch.Text = ((Outsource)SelectedPart).CompanyName;
            }
        }

        private void cancelPartsCancelBtn_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            labelSwitch.Text = "Company Name";
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            labelSwitch.Text = "Machine ID";
        }
        //save button update part
        private void modifyPartsSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartNameValue.Text) ||
                  string.IsNullOrEmpty(inventoryValue.Text) ||
                   string.IsNullOrEmpty(priceCostValue.Text) ||
                     string.IsNullOrEmpty(maxValue.Text) ||
                     string.IsNullOrEmpty(minValue.Text) ||
                    string.IsNullOrEmpty(ValueSwitch.Text))
            {
                MessageBox.Show("Please enter a valid value for each field");
                return;
            }
            try
            {
                int inventory = Convert.ToInt32(inventoryValue.Text);
                int max = Convert.ToInt32(maxValue.Text);
                int min = Convert.ToInt32(minValue.Text);
                decimal price = Convert.ToDecimal(priceCostValue.Text);
                string name = modifyPartNameValue.Text;
                int partID = Convert.ToInt32(modifyPartIDValue.Text);

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between min and max values");
                    return;
                }
                else if (min > max)
                {
                    MessageBox.Show("Min value must be less than max value");
                    return;
                }

                SelectedPart.Name = modifyPartNameValue.Text;
                SelectedPart.InStock = Convert.ToInt32(inventoryValue.Text);
                SelectedPart.Price = Convert.ToDecimal(priceCostValue.Text);
                SelectedPart.Max = Convert.ToInt32(maxValue.Text);
                SelectedPart.Min = Convert.ToInt32(minValue.Text);


                if (inHouseRadioBtn.Checked)
                {
                    if (SelectedPart is InHouse inHousePart)
                    {
                        inHousePart.MachineID = Convert.ToInt32(ValueSwitch.Text);
                        Inventory.updatePart(inHousePart.PartID, inHousePart);
                    }
                    else if (SelectedPart is Outsource outsourcePart)
                    {
                        Inventory.deletePart(outsourcePart);
                        int machineID = Convert.ToInt32(ValueSwitch.Text);
                        Inventory.addPart(new InHouse(partID, inventory, min, max, price, name, machineID));
                        inHouseRadioBtn.Checked = true;
                        labelSwitch.Text = "Machine ID";
                    }
                }
                else if (outsourcedRadioBtn.Checked)
                {
                    if (SelectedPart is Outsource outsourcePart)
                    {
                        outsourcePart.CompanyName = ValueSwitch.Text;
                        Inventory.updatePart(outsourcePart.PartID, outsourcePart);
                    }
                    else if (SelectedPart is InHouse inHousePart)
                    {
                        string companyName = ValueSwitch.Text;
                        // Check if the company name is a number
                        if (int.TryParse(companyName, out _)) // Check if the company name is a number
                        {
                            // If the company name is a number, throw a format exception
                            throw new FormatException("Company name cannot be a number");
                        }

                        Inventory.deletePart(inHousePart);
                        Inventory.addPart(new Outsource(partID, inventory, min, max, price, name, companyName));
                        outsourcedRadioBtn.Checked = true;
                        labelSwitch.Text = "Company Name";
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                ValueSwitch.BackColor = System.Drawing.Color.Red;
                return;
            }
            ValueSwitch.BackColor = System.Drawing.Color.White;
            Close();
        }


    }
}












