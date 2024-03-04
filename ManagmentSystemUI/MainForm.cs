using Domenic_Arias_C968.inventoryManagmentSystem;
using Domenic_Arias_C968.model;
using System;
using System.Windows.Forms;

namespace ManagmentSystemUI
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            ProductsShowBox.DataSource = Inventory.Products;
            ProductsShowBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsShowBox.MultiSelect = false;
            ProductsShowBox.AllowUserToAddRows = false;


            partsShowBox.DataSource = Inventory.parts;
            partsShowBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsShowBox.MultiSelect = false;
            partsShowBox.AllowUserToAddRows = false;





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

        private void ModifyProductsBtn_Click(object sender, EventArgs e)
        {
            if (!ProductsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify");
            }
            ModifyProductForm modifyProductForm = new ModifyProductForm();
            modifyProductForm.Show();
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
                    Inventory.Products.RemoveAt(ProductsShowBox.CurrentRow.Index);
                }
                
            }



        }

        private void noSelectionInitial(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ProductsShowBox.ClearSelection(); //clears the selection of the datagridview
        }

        private void ModifyPartsBtn_Click(object sender, EventArgs e)
        {
            if (!ProductsShowBox.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify");
            }
            ModifyPartForm modifyPartForm = new ModifyPartForm();
            modifyPartForm.Show();
            
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
                    Inventory.parts.RemoveAt(partsShowBox.CurrentRow.Index);
                }

            }
        }

        private void NoPartsSelectedInit(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsShowBox.ClearSelection(); //clears the selection of the datagridview
        }
    }
}






