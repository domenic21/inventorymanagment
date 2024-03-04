﻿namespace ManagmentSystemUI
{
    partial class AddProductForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.priceCostValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.TextBox();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.addProducttNameValue = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.addProductIDValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partsShowBox = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsShowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Min";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(222, 287);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(50, 20);
            this.minValue.TabIndex = 31;
            // 
            // priceCostValue
            // 
            this.priceCostValue.Location = new System.Drawing.Point(85, 243);
            this.priceCostValue.Name = "priceCostValue";
            this.priceCostValue.Size = new System.Drawing.Size(187, 20);
            this.priceCostValue.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Max";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(85, 284);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(50, 20);
            this.maxValue.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Price / Cost";
            // 
            // inventoryValue
            // 
            this.inventoryValue.Location = new System.Drawing.Point(85, 205);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(187, 20);
            this.inventoryValue.TabIndex = 24;
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.Location = new System.Drawing.Point(24, 210);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(55, 15);
            this.inventorylabel.TabIndex = 23;
            this.inventorylabel.Text = "Inventory";
            // 
            // addProducttNameValue
            // 
            this.addProducttNameValue.Location = new System.Drawing.Point(85, 169);
            this.addProducttNameValue.Name = "addProducttNameValue";
            this.addProducttNameValue.Size = new System.Drawing.Size(187, 20);
            this.addProducttNameValue.TabIndex = 22;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(38, 174);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(41, 15);
            this.namelabel.TabIndex = 21;
            this.namelabel.Text = "Name";
            // 
            // addProductIDValue
            // 
            this.addProductIDValue.Location = new System.Drawing.Point(85, 135);
            this.addProductIDValue.Name = "addProductIDValue";
            this.addProductIDValue.Size = new System.Drawing.Size(187, 20);
            this.addProductIDValue.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // partsShowBox
            // 
            this.partsShowBox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.partsShowBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsShowBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsShowBox.Location = new System.Drawing.Point(350, 81);
            this.partsShowBox.MultiSelect = false;
            this.partsShowBox.Name = "partsShowBox";
            this.partsShowBox.ReadOnly = true;
            this.partsShowBox.RowHeadersWidth = 51;
            this.partsShowBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsShowBox.Size = new System.Drawing.Size(647, 223);
            this.partsShowBox.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 382);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 223);
            this.dataGridView1.TabIndex = 34;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(350, 52);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 35;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(922, 310);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(350, 353);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(431, 353);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(262, 20);
            this.searchValue.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(431, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 39;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(922, 611);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Add Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(946, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "All Parts";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.partsShowBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.priceCostValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryValue);
            this.Controls.Add(this.inventorylabel);
            this.Controls.Add(this.addProducttNameValue);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.addProductIDValue);
            this.Controls.Add(this.label2);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.partsShowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox priceCostValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventoryValue;
        private System.Windows.Forms.Label inventorylabel;
        private System.Windows.Forms.TextBox addProducttNameValue;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox addProductIDValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView partsShowBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}