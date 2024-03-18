using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class ModifyProductForm : Form
    {


        BindingList<Parts> parts = new BindingList<Parts>();
        private readonly Products product;

        public ModifyProductForm(Products product)
        {
            InitializeComponent();
            this.Size = new Size(1000, 700);
            allPartsShowBox.DataSource = Inventory.AllParts;
            modifyProductIDValue.Enabled = false;
            allPartsShowBox.ClearSelection();
            partsAssociatedBox.ClearSelection();
            modifyProductIDValue.Text = product.ProductID.ToString();
            modifyProductNameValue.Text = product.Name;
            inventoryValue.Text = product.Inventory.ToString();
            priceCostValue.Text = product.Price.ToString();
            maxValue.Text = product.Max.ToString();
            minValue.Text = product.Min.ToString();
            partsAssociatedBox.DataSource = parts;
            allPartsShowBox.RowHeadersVisible = false;
            partsAssociatedBox.RowHeadersVisible = false;
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
            allPartsShowBox.ClearSelection();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (partsAssociatedBox.CurrentRow.DataBoundItem is Parts part)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo))
                {
                    parts.Remove(part);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete");
            }
            partsAssociatedBox.ClearSelection();

        }
        //search button for all parts
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchAllParts.Text))
            {
                MessageBox.Show("Please enter a part ID to search");
                foreach (DataGridViewRow row in allPartsShowBox.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                return; // Exit the method if search value is empty
            }

            try
            {
                int partId = Convert.ToInt32(searchAllParts.Text);
                var part = Inventory.lookupPart(partId);

                if (part != null)
                {
                    // Do something with the part
                    foreach (DataGridViewRow row in allPartsShowBox.Rows)
                    {
                        if (row.Cells[0].Value != null && (int)row.Cells[0].Value == partId)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Part not found");
                    allPartsShowBox.ClearSelection();
                    foreach (DataGridViewRow row in allPartsShowBox.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid part ID");
            }

            allPartsShowBox.ClearSelection();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (partsAssociatedBox.Rows.Count == 0)
            {
                MessageBox.Show("The associated parts box is empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(searchValueAssociated.Text))
            {
                MessageBox.Show("Please enter a part ID to search");
                foreach (DataGridViewRow row in partsAssociatedBox.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                return; // Exit the method if search value is empty
            }

            try
            {
                int partId = Convert.ToInt32(searchValueAssociated.Text);
                var part = Inventory.lookupPart(partId);

                if (part != null)
                {
                    // Do something with the part
                    foreach (DataGridViewRow row in partsAssociatedBox.Rows)
                    {
                        if (row.Cells[0].Value != null && (int)row.Cells[0].Value == partId)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }

                    }
                }
                else
                {

                    partsAssociatedBox.ClearSelection();
                    foreach (DataGridViewRow row in partsAssociatedBox.Rows)
                    {
                        if ((int)row.Cells[0].Value != partId )
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            MessageBox.Show("Part not found");
                            break;
                        }

                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid part ID");
            }

            partsAssociatedBox.ClearSelection();
            allPartsShowBox.ClearSelection();


        }
        //associate parts search button

        //search button for all parts



    }
}
