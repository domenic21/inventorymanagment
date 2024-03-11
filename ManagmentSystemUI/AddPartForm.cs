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

            addPartIDValue.Enabled = false;

        }

        private int generateId()
        {
            // Implement your ID generation logic here
            // For example, you could use a random number
            Random random = new Random();
            return random.Next(1, 10000);
        }

        private void addPartsSaveBtn_Click(object sender, EventArgs e)
        {
            string name = addPartNameValue.Text;
            int inventory = Convert.ToInt32(inventoryValue.Text);
            int max = Convert.ToInt32(maxValue.Text);
            int min = Convert.ToInt32(minValue.Text);
            decimal price = Convert.ToDecimal(priceCostValue.Text);

            int partID = generateId();

            //min and max validation




            if (inHouseRadioBtn.Checked)
            {
                int machineID = Convert.ToInt32(labelSwitch2.Text);
                Inventory.addPart(new InHouse(partID, inventory, min, max, price, name, machineID));
            }
            else if (outsourcedRadioBtn.Checked)
            {
                string companyName = labelSwitch2.Text;
                Inventory.addPart(new Outsource(partID, inventory, min, max, price, name, companyName));
            }
            else
            {
                MessageBox.Show("Please select a part type");
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


        //validate inputs


    }
}
