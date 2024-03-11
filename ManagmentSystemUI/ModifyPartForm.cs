using System;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class ModifyPartForm : Form
    {


        public ModifyPartForm()
        {
            InitializeComponent();




            //modifyPartIDValue.Text = Inventory.Parts.PartID.ToString();
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
    }
}
