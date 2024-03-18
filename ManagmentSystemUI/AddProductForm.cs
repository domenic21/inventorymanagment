using Domenic_Arias_C968.inventoryManagmentSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            addProductIDValue.Enabled = false;
            partsShowBox.DataSource = Inventory.AllParts;
        }

        private void partsShowBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
