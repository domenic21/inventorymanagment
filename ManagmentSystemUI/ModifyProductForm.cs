using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class ModifyProductForm : Form
    {
        
      
        BindingList<Parts> parts = new BindingList<Parts>();

        public ModifyProductForm(Products product)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1110, 700);
            allPartsShowBox.DataSource = Inventory.AllParts;
            modifyProductIDValue.Enabled = false;
            
            modifyProductIDValue.Text = product.ProductID.ToString();
            modifyProductNameValue.Text = product.Name;
            inventoryValue.Text = product.Inventory.ToString();
            priceCostValue.Text = product.Price.ToString();
            maxValue.Text = product.Max.ToString();
            minValue.Text = product.Min.ToString();
            partsAssociatedBox.DataSource = parts;
            foreach (Parts part in product.AssociatedParts)
            {
                parts.Add(part);

            }
            
        }

       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!allPartsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to add");
            }
            else
            {
                Parts part = (Parts)allPartsShowBox.CurrentRow.DataBoundItem;
                parts.Add(part);
            }
        }

        private void modifySaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyProductNameValue.Text) ||
               string.IsNullOrEmpty(inventoryValue.Text) ||
                 string.IsNullOrEmpty(priceCostValue.Text) ||
                    string.IsNullOrEmpty(maxValue.Text) ||
                      string.IsNullOrEmpty(minValue.Text))
            {
                MessageBox.Show("Please enter a valid value for each field");
                return;
            }
            if (parts.Count == 0)
            {
                MessageBox.Show("Please add at least one part to the product");
                return;
            }
            try
            {
                string name = modifyProductNameValue.Text;
                int inventory = Convert.ToInt32(inventoryValue.Text);
                int max = Convert.ToInt32(maxValue.Text);
                int min = Convert.ToInt32(minValue.Text);
                decimal price = Convert.ToDecimal(priceCostValue.Text);
                if (min > max)
                {
                    MessageBox.Show("Min must be less than max");
                    return;
                }
                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between min and max");
                    return;
                }
                Products product = new Products(Convert.ToInt32(modifyProductIDValue.Text), name, inventory, price, min, max);
                foreach (Parts part in parts)
                {
                    product.addAssociatedPart(part);
                }
                Inventory.updateProduct(Convert.ToInt32(modifyProductIDValue.Text), product);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid value for each field");
            }   

        }
    }
}
