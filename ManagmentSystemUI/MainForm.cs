using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1130, 500);
            ProductsShowBox.DataSource = Inventory.Products;
            ProductsShowBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsShowBox.MultiSelect = false;
            ProductsShowBox.AllowUserToAddRows = false;
            ProductsShowBox.RowHeadersVisible = false;
            ProductsShowBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            partsShowBox.DataSource = Inventory.AllParts;
            //partsShowBox.DataSource = Inventory.AllParts;// data sample
            partsShowBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsShowBox.MultiSelect = false;
            partsShowBox.AllowUserToAddRows = false;
            partsShowBox.RowHeadersVisible = false;
            partsShowBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //called the method to add parts to the inventory
            InventoryData();





        }
        private void InventoryData()
        {
            Inventory.addPart(new InHouse(1, 10, 1, 10, 150, "Wheel", 1));
            Inventory.addPart(new InHouse(2, 10, 1, 10, 200, "Steering", 2));
            Inventory.addPart(new InHouse(3, 10, 1, 10, 500, "Ignition", 3));
            Inventory.addPart(new Outsource(5, 10, 1, 10, 500, "Ignition", "Company Inc"));
            Inventory.addPart(new Outsource(12, 10, 1, 10, 500, "Bolts", "Company Inc"));

            Inventory.addProduct(new Products(5, "Car", 10, 150, 1, 10));
            Inventory.addProduct(new Products(6, "Truck", 10, 200, 1, 10));
            Inventory.addProduct(new Products(7, "Motorcycle", 10, 500, 1, 10));
            Inventory.addProduct(new Products(8, "Bike", 10, 500, 1, 10));




        }


        //opens add parts form
        private void AddParts_Click(object sender, EventArgs e)
        {
            AddPartForm addPartsForm = new AddPartForm();
            addPartsForm.Show();

        }
        //opens modify parts form
        private void AddProductsBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();

        }






        //closes the application
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Modify this method to pass the selected row data to the ModifyProductForm
        private void ModifyProductsBtn_Click(object sender, EventArgs e)
        {
            if (!ProductsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify");
            }
            else if (ProductsShowBox.CurrentRow.Selected)
            {
                Products product = (Products)ProductsShowBox.CurrentRow.DataBoundItem;
                ModifyProductForm modifyProductForm = new ModifyProductForm(product);
                modifyProductForm.Show();
            }
        }


        private void ProductsShowBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void DeleteProductsBtn_Click(object sender, EventArgs e)
        {
            if (!ProductsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to delete");
            }
            else if (ProductsShowBox.CurrentRow.Selected)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo))
                {
                    Inventory.removeProduct((Products)ProductsShowBox.CurrentRow.DataBoundItem);
                }

            }



        }

        private void noSelectionInitial(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsShowBox.ClearSelection(); //clears the selection of the datagridview
        }

        // Modify this method to pass the selected row data to the ModifyPartForm
        // Modify this method to refresh the partsShowBox after the modification form is closed
        private void ModifyPartsBtn_Click(object sender, EventArgs e)
        {
            if (!partsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify");
            }
            else if (partsShowBox.CurrentRow.Selected)
            {
                Parts selectedPart = (Parts)partsShowBox.CurrentRow.DataBoundItem;
                ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart);
                modifyPartForm.FormClosed += ModifyPartForm_FormClosed; // handle the FormClosed event
                modifyPartForm.Show(); // Show the modifyPartForm
            }
        }

        // Add this method to handle the FormClosed event of the modifyPartForm
        private void ModifyPartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            partsShowBox.DataSource = null; // Set the DataSource to null
            partsShowBox.DataSource = Inventory.AllParts; // Set the DataSource to the updated AllParts list
            partsShowBox.Refresh();// Refresh the partsShowBox
        }

        private void DeletePartsBtn_Click(object sender, EventArgs e)
        {
            if (!partsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete");
            }
            else if (partsShowBox.CurrentRow.Selected)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo))
                {
                    // Inventory.parts.RemoveAt(partsShowBox.CurrentRow.Index);
                    Inventory.deletePart((Parts)partsShowBox.CurrentRow.DataBoundItem);
                }

            }
        }

        private void NoPartsSelectedInit(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsShowBox.ClearSelection(); //clears the selection of the datagridview
        }

        // search button for parts

        private void SearchPartsBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchPartsValue.Text))
            {
                MessageBox.Show("Please enter a part ID to search");
                foreach (DataGridViewRow row in partsShowBox.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                return; // Exit the method if search value is empty
            }

            try
            {
                int partId = Convert.ToInt32(searchPartsValue.Text);
                var part = Inventory.lookupPart(partId);

                if (part != null)
                {
                    // Do something with the part
                    foreach (DataGridViewRow row in partsShowBox.Rows)
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
                    partsShowBox.ClearSelection();
                    foreach (DataGridViewRow row in partsShowBox.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid part ID");
            }

            partsShowBox.ClearSelection();
        }

        // search button for products
        private void SeachProductsBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductValue.Text))
            {
                MessageBox.Show("Please enter a product ID to search");
                ProductsShowBox.ClearSelection();
                foreach (DataGridViewRow row in ProductsShowBox.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;

                }
                return; // Exit the method if search value is empty


            }
            try
            {
                int productId = Convert.ToInt32(searchProductValue.Text);
                var product = Inventory.lookupProduct(productId);

                if (product != null)
                {
                    // Do something with the part
                    foreach (DataGridViewRow row in ProductsShowBox.Rows)
                    {
                        if (row.Cells[0].Value != null && (int)row.Cells[0].Value == productId)
                        {
                            row.Selected = true;
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
                    MessageBox.Show("Product not found");
                    foreach (DataGridViewRow row in ProductsShowBox.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    ProductsShowBox.ClearSelection();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid product ID");
            }

            ProductsShowBox.ClearSelection();
        }


    }
}







