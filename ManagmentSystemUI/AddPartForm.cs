using Domenic_Arias_C968.inventoryManagmentSystem;
using System;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class AddPartForm : Form
    {

        public AddPartForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            addPartIDValue.Enabled = false;

        }



        private void addPartsSaveBtn_Click(object sender, EventArgs e)
        {
            // check if the user has entered a value for each field
            if (string.IsNullOrWhiteSpace(addPartNameValue.Text) ||
                string.IsNullOrEmpty(inventoryValue.Text) ||
                string.IsNullOrEmpty(priceCostValue.Text) ||
                string.IsNullOrEmpty(maxValue.Text) ||
                string.IsNullOrEmpty(minValue.Text) ||
                string.IsNullOrEmpty(labelSwitch2.Text))
            {

                MessageBox.Show("Please enter a valid value for each field");
                return;
            }



            try
            {
                string name = addPartNameValue.Text;
                int inventory = Convert.ToInt32(inventoryValue.Text);
                int max = Convert.ToInt32(maxValue.Text);
                int min = Convert.ToInt32(minValue.Text);
                decimal price = Convert.ToDecimal(priceCostValue.Text);

                int partID = Inventory.GenerateID();
                //check if name is a number
                if (int.TryParse(name, out int result))
                {
                    MessageBox.Show("Name cannot be a number");
                    return;
                }
                //min and max validation


                if (inHouseRadioBtn.Checked)
                {
                    int machineID = Convert.ToInt32(labelSwitch2.Text);
                    Inventory.addPart(new InHouse(partID, inventory, min, max, price, name, machineID));
                    ;
                }
                else if (outsourcedRadioBtn.Checked)
                {
                    string companyName = labelSwitch2.Text;
                    if (int.TryParse(companyName, out _)) // Check if the company name is a number
                    {
                        // If the company name is a number, throw a format exception
                        throw new FormatException("Company name cannot be a number");
                    }
                    else
                    {

                        Inventory.addPart(new Outsource(partID, inventory, min, max, price, name, companyName));
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part type");
                    return;
                }
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



            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid value for each field");
                return;
            }

            this.Close();
        }

        private void addPartsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void outsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Company Name";
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            label.Text = "Machine ID";
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }


        //validate inputs


    }
}
