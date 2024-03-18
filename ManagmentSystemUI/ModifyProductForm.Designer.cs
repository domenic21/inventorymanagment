namespace ManagmentSystemUI
{
    partial class ModifyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchAllParts = new System.Windows.Forms.TextBox();
            this.searchValueAssociated = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.partsAssociatedBox = new System.Windows.Forms.DataGridView();
            this.allPartsShowBox = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.priceCostValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.TextBox();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.modifyProductNameValue = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.modifyProductIDValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.modifySaveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsShowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 38);
            this.label1.TabIndex = 62;
            this.label1.Text = "Modify Inventory";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1484, 1140);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 42);
            this.deleteBtn.TabIndex = 61;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchAllParts
            // 
            this.searchAllParts.Location = new System.Drawing.Point(803, 111);
            this.searchAllParts.Margin = new System.Windows.Forms.Padding(6);
            this.searchAllParts.Name = "searchAllParts";
            this.searchAllParts.Size = new System.Drawing.Size(477, 29);
            this.searchAllParts.TabIndex = 60;
            // 
            // searchValueAssociated
            // 
            this.searchValueAssociated.Location = new System.Drawing.Point(803, 663);
            this.searchValueAssociated.Margin = new System.Windows.Forms.Padding(6);
            this.searchValueAssociated.Name = "searchValueAssociated";
            this.searchValueAssociated.Size = new System.Drawing.Size(477, 29);
            this.searchValueAssociated.TabIndex = 59;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(654, 663);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 42);
            this.searchButton.TabIndex = 58;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1609, 588);
            this.addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(138, 42);
            this.addBtn.TabIndex = 57;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(654, 107);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 42);
            this.searchBtn.TabIndex = 56;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // partsAssociatedBox
            // 
            this.partsAssociatedBox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.partsAssociatedBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsAssociatedBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedBox.Location = new System.Drawing.Point(654, 720);
            this.partsAssociatedBox.Margin = new System.Windows.Forms.Padding(6);
            this.partsAssociatedBox.MultiSelect = false;
            this.partsAssociatedBox.Name = "partsAssociatedBox";
            this.partsAssociatedBox.ReadOnly = true;
            this.partsAssociatedBox.RowHeadersWidth = 51;
            this.partsAssociatedBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsAssociatedBox.Size = new System.Drawing.Size(1093, 412);
            this.partsAssociatedBox.TabIndex = 55;
            // 
            // allPartsShowBox
            // 
            this.allPartsShowBox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.allPartsShowBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allPartsShowBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsShowBox.Location = new System.Drawing.Point(654, 164);
            this.allPartsShowBox.Margin = new System.Windows.Forms.Padding(6);
            this.allPartsShowBox.MultiSelect = false;
            this.allPartsShowBox.Name = "allPartsShowBox";
            this.allPartsShowBox.ReadOnly = true;
            this.allPartsShowBox.RowHeadersWidth = 51;
            this.allPartsShowBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsShowBox.Size = new System.Drawing.Size(1093, 412);
            this.allPartsShowBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 541);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "Min";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(420, 541);
            this.minValue.Margin = new System.Windows.Forms.Padding(6);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(88, 29);
            this.minValue.TabIndex = 52;
            // 
            // priceCostValue
            // 
            this.priceCostValue.Location = new System.Drawing.Point(169, 460);
            this.priceCostValue.Margin = new System.Windows.Forms.Padding(6);
            this.priceCostValue.Name = "priceCostValue";
            this.priceCostValue.Size = new System.Drawing.Size(340, 29);
            this.priceCostValue.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 541);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Max";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(169, 535);
            this.maxValue.Margin = new System.Windows.Forms.Padding(6);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(88, 29);
            this.maxValue.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Price / Cost";
            // 
            // inventoryValue
            // 
            this.inventoryValue.Location = new System.Drawing.Point(169, 390);
            this.inventoryValue.Margin = new System.Windows.Forms.Padding(6);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(340, 29);
            this.inventoryValue.TabIndex = 47;
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.Location = new System.Drawing.Point(57, 399);
            this.inventorylabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(92, 25);
            this.inventorylabel.TabIndex = 46;
            this.inventorylabel.Text = "Inventory";
            // 
            // modifyProductNameValue
            // 
            this.modifyProductNameValue.Location = new System.Drawing.Point(169, 323);
            this.modifyProductNameValue.Margin = new System.Windows.Forms.Padding(6);
            this.modifyProductNameValue.Name = "modifyProductNameValue";
            this.modifyProductNameValue.Size = new System.Drawing.Size(340, 29);
            this.modifyProductNameValue.TabIndex = 45;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(82, 332);
            this.namelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(64, 25);
            this.namelabel.TabIndex = 44;
            this.namelabel.Text = "Name";
            // 
            // modifyProductIDValue
            // 
            this.modifyProductIDValue.Location = new System.Drawing.Point(169, 260);
            this.modifyProductIDValue.Margin = new System.Windows.Forms.Padding(6);
            this.modifyProductIDValue.Name = "modifyProductIDValue";
            this.modifyProductIDValue.Size = new System.Drawing.Size(340, 29);
            this.modifyProductIDValue.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1442, 680);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1663, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "All Parts";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1624, 1141);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(123, 41);
            this.exitBtn.TabIndex = 65;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // modifySaveProduct
            // 
            this.modifySaveProduct.Location = new System.Drawing.Point(1344, 1140);
            this.modifySaveProduct.Name = "modifySaveProduct";
            this.modifySaveProduct.Size = new System.Drawing.Size(131, 42);
            this.modifySaveProduct.TabIndex = 66;
            this.modifySaveProduct.Text = "Save";
            this.modifySaveProduct.UseVisualStyleBackColor = true;
            this.modifySaveProduct.Click += new System.EventHandler(this.modifySaveProduct_Click);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 1261);
            this.Controls.Add(this.modifySaveProduct);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchAllParts);
            this.Controls.Add(this.searchValueAssociated);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.partsAssociatedBox);
            this.Controls.Add(this.allPartsShowBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.priceCostValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryValue);
            this.Controls.Add(this.inventorylabel);
            this.Controls.Add(this.modifyProductNameValue);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.modifyProductIDValue);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsShowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchAllParts;
        private System.Windows.Forms.TextBox searchValueAssociated;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView partsAssociatedBox;
        private System.Windows.Forms.DataGridView allPartsShowBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox priceCostValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventoryValue;
        private System.Windows.Forms.Label inventorylabel;
        private System.Windows.Forms.TextBox modifyProductNameValue;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox modifyProductIDValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button modifySaveProduct;
    }
}