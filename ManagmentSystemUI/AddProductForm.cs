using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class AddProductForm : Form
    {
        BindingList<Parts> parts = new BindingList<Parts>();
        public AddProductForm()
        {
            InitializeComponent();
            addProductIDValue.Enabled = false;
            partsShowBox.DataSource = Inventory.AllParts;
            this.Size = new System.Drawing.Size(1110, 700);
            partsShowBox.ClearSelection();
            associatedPartShowBox.DataSource = parts;
            // binds data to the datagrid and ensures to clear the selection after the data is loaded
            partsShowBox.DataBindingComplete += PartsShowBox_DataBindingComplete;
        }

        //clears the selection after the data is loaded
        private void PartsShowBox_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsShowBox.ClearSelection();

        }





        private void partsShowBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partsShowBox.ClearSelection();

        }

        private void addProductCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProductSaveBtn_Click(object sender, EventArgs e)
        {
            //check if associated parts list is empty
            if (parts.Count == 0)
            {
                MessageBox.Show("Please add at least one part to the product");
                return;
            }

            //check if the user has entered a value for each field
            if (string.IsNullOrWhiteSpace(addProductNameValue.Text) ||
                 string.IsNullOrEmpty(inventoryValue.Text) ||
                 string.IsNullOrEmpty(priceCostValue.Text) ||
                 string.IsNullOrEmpty(maxValue.Text) ||
                string.IsNullOrEmpty(minValue.Text))
            {
                MessageBox.Show("Please enter a valid value for each field");
                return;
            }
            try
            {
                string name = addProductNameValue.Text;
                int inventory = Convert.ToInt32(inventoryValue.Text);
                int max = Convert.ToInt32(maxValue.Text);
                int min = Convert.ToInt32(minValue.Text);
                decimal price = Convert.ToDecimal(priceCostValue.Text);
                int productID = Inventory.GenerateID();
                // check if name is a number
                if (int.TryParse(name, out int result))
                {
                    MessageBox.Show("Name cannot be a number");
                    return;
                }

                //min and max validation
                if (min > max)
                {
                    MessageBox.Show("Min value cannot be greater than max value");
                    return;
                }
                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory value must be between min and max values");
                    return;
                }
                Products product = new Products(productID, name, inventory, price, min, max);
                foreach (var part in parts)
                {
                    product.addAssociatedPart(part);
                }
                Inventory.addProduct(product);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid value for each field");
                return;
            }
            this.Close();

        }

        // add part to associated parts binding list and display in the datagrid
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!partsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to add");
            }
            else
            {
                Parts part = (Parts)partsShowBox.CurrentRow.DataBoundItem;
                parts.Add(part);

            }
            associatedPartShowBox.ClearSelection();
            partsShowBox.ClearSelection();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (partsShowBox.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo))
                {
                    parts.Remove((Parts)associatedPartShowBox.CurrentRow.DataBoundItem);
                }
            }

        }


    }

}

