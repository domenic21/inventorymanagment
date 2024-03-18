namespace ManagmentSystemUI
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.AddProductsBtn = new System.Windows.Forms.Button();
            this.ModifyProductsBtn = new System.Windows.Forms.Button();
            this.DeleteProductsBtn = new System.Windows.Forms.Button();
            this.AddPartsBtn = new System.Windows.Forms.Button();
            this.DeletePartsBtn = new System.Windows.Forms.Button();
            this.ModifyPartsBtn = new System.Windows.Forms.Button();
            this.SeachProductsBtn = new System.Windows.Forms.Button();
            this.SearchPartsBtn = new System.Windows.Forms.Button();
            this.partsShowBox = new System.Windows.Forms.DataGridView();
            this.ProductsShowBox = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPartsValue = new System.Windows.Forms.TextBox();
            this.searchProductValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.partsShowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsShowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1060, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "PRODUCTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-170, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "PARTS";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1890, 724);
            this.Exit.Margin = new System.Windows.Forms.Padding(6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(138, 42);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddProductsBtn
            // 
            this.AddProductsBtn.Location = new System.Drawing.Point(1452, 724);
            this.AddProductsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddProductsBtn.Name = "AddProductsBtn";
            this.AddProductsBtn.Size = new System.Drawing.Size(138, 42);
            this.AddProductsBtn.TabIndex = 22;
            this.AddProductsBtn.Text = "Add";
            this.AddProductsBtn.UseVisualStyleBackColor = true;
            this.AddProductsBtn.Click += new System.EventHandler(this.AddProductsBtn_Click);
            // 
            // ModifyProductsBtn
            // 
            this.ModifyProductsBtn.Location = new System.Drawing.Point(1600, 724);
            this.ModifyProductsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ModifyProductsBtn.Name = "ModifyProductsBtn";
            this.ModifyProductsBtn.Size = new System.Drawing.Size(138, 42);
            this.ModifyProductsBtn.TabIndex = 21;
            this.ModifyProductsBtn.Text = "Modify";
            this.ModifyProductsBtn.UseVisualStyleBackColor = true;
            this.ModifyProductsBtn.Click += new System.EventHandler(this.ModifyProductsBtn_Click);
            // 
            // DeleteProductsBtn
            // 
            this.DeleteProductsBtn.Location = new System.Drawing.Point(1749, 724);
            this.DeleteProductsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteProductsBtn.Name = "DeleteProductsBtn";
            this.DeleteProductsBtn.Size = new System.Drawing.Size(138, 42);
            this.DeleteProductsBtn.TabIndex = 20;
            this.DeleteProductsBtn.Text = "Delete";
            this.DeleteProductsBtn.UseVisualStyleBackColor = true;
            this.DeleteProductsBtn.Click += new System.EventHandler(this.DeleteProductsBtn_Click);
            // 
            // AddPartsBtn
            // 
            this.AddPartsBtn.Location = new System.Drawing.Point(436, 724);
            this.AddPartsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddPartsBtn.Name = "AddPartsBtn";
            this.AddPartsBtn.Size = new System.Drawing.Size(138, 42);
            this.AddPartsBtn.TabIndex = 19;
            this.AddPartsBtn.Text = "Add";
            this.AddPartsBtn.UseVisualStyleBackColor = true;
            this.AddPartsBtn.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // DeletePartsBtn
            // 
            this.DeletePartsBtn.Location = new System.Drawing.Point(733, 724);
            this.DeletePartsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeletePartsBtn.Name = "DeletePartsBtn";
            this.DeletePartsBtn.Size = new System.Drawing.Size(138, 42);
            this.DeletePartsBtn.TabIndex = 18;
            this.DeletePartsBtn.Text = "Delete";
            this.DeletePartsBtn.UseVisualStyleBackColor = true;
            this.DeletePartsBtn.Click += new System.EventHandler(this.DeletePartsBtn_Click);
            // 
            // ModifyPartsBtn
            // 
            this.ModifyPartsBtn.Location = new System.Drawing.Point(585, 724);
            this.ModifyPartsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ModifyPartsBtn.Name = "ModifyPartsBtn";
            this.ModifyPartsBtn.Size = new System.Drawing.Size(138, 42);
            this.ModifyPartsBtn.TabIndex = 17;
            this.ModifyPartsBtn.Text = "Modify";
            this.ModifyPartsBtn.UseVisualStyleBackColor = true;
            this.ModifyPartsBtn.Click += new System.EventHandler(this.ModifyPartsBtn_Click);
            // 
            // SeachProductsBtn
            // 
            this.SeachProductsBtn.Location = new System.Drawing.Point(1452, 113);
            this.SeachProductsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SeachProductsBtn.Name = "SeachProductsBtn";
            this.SeachProductsBtn.Size = new System.Drawing.Size(138, 42);
            this.SeachProductsBtn.TabIndex = 16;
            this.SeachProductsBtn.Text = "Search";
            this.SeachProductsBtn.UseVisualStyleBackColor = true;
            this.SeachProductsBtn.Click += new System.EventHandler(this.SeachProductsBtn_Click);
            // 
            // SearchPartsBtn
            // 
            this.SearchPartsBtn.Location = new System.Drawing.Point(436, 113);
            this.SearchPartsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchPartsBtn.Name = "SearchPartsBtn";
            this.SearchPartsBtn.Size = new System.Drawing.Size(138, 42);
            this.SearchPartsBtn.TabIndex = 15;
            this.SearchPartsBtn.Text = "Search";
            this.SearchPartsBtn.UseVisualStyleBackColor = true;
            this.SearchPartsBtn.Click += new System.EventHandler(this.SearchPartsBtn_Click);
            // 
            // partsShowBox
            // 
            this.partsShowBox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.partsShowBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsShowBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsShowBox.Location = new System.Drawing.Point(28, 166);
            this.partsShowBox.Margin = new System.Windows.Forms.Padding(6);
            this.partsShowBox.MultiSelect = false;
            this.partsShowBox.Name = "partsShowBox";
            this.partsShowBox.ReadOnly = true;
            this.partsShowBox.RowHeadersWidth = 51;
            this.partsShowBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsShowBox.Size = new System.Drawing.Size(843, 546);
            this.partsShowBox.TabIndex = 14;

            this.partsShowBox.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.NoPartsSelectedInit);
            // 
            // ProductsShowBox
            // 
            this.ProductsShowBox.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductsShowBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsShowBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsShowBox.Location = new System.Drawing.Point(1043, 166);
            this.ProductsShowBox.Margin = new System.Windows.Forms.Padding(6);
            this.ProductsShowBox.MultiSelect = false;
            this.ProductsShowBox.Name = "ProductsShowBox";
            this.ProductsShowBox.ReadOnly = true;
            this.ProductsShowBox.RowHeadersWidth = 51;
            this.ProductsShowBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsShowBox.Size = new System.Drawing.Size(918, 546);
            this.ProductsShowBox.TabIndex = 13;
            this.ProductsShowBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsShowBox_CellContentClick);
            this.ProductsShowBox.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.noSelectionInitial);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 137);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 25);
            this.label.TabIndex = 26;
            this.label.Text = "PARTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "Inventory Managment System";
            // 
            // searchPartsValue
            // 
            this.searchPartsValue.Location = new System.Drawing.Point(585, 118);
            this.searchPartsValue.Margin = new System.Windows.Forms.Padding(6);
            this.searchPartsValue.Name = "searchPartsValue";
            this.searchPartsValue.Size = new System.Drawing.Size(283, 29);
            this.searchPartsValue.TabIndex = 28;
            // 
            // searchProductValue
            // 
            this.searchProductValue.Location = new System.Drawing.Point(1619, 113);
            this.searchProductValue.Margin = new System.Windows.Forms.Padding(6);
            this.searchProductValue.Name = "searchProductValue";
            this.searchProductValue.Size = new System.Drawing.Size(264, 29);
            this.searchProductValue.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2066, 836);
            this.Controls.Add(this.searchProductValue);
            this.Controls.Add(this.searchPartsValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddProductsBtn);
            this.Controls.Add(this.ModifyProductsBtn);
            this.Controls.Add(this.DeleteProductsBtn);
            this.Controls.Add(this.AddPartsBtn);
            this.Controls.Add(this.DeletePartsBtn);
            this.Controls.Add(this.ModifyPartsBtn);
            this.Controls.Add(this.SeachProductsBtn);
            this.Controls.Add(this.SearchPartsBtn);
            this.Controls.Add(this.partsShowBox);
            this.Controls.Add(this.ProductsShowBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.partsShowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsShowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddProductsBtn;
        private System.Windows.Forms.Button ModifyProductsBtn;
        private System.Windows.Forms.Button DeleteProductsBtn;
        private System.Windows.Forms.Button AddPartsBtn;
        private System.Windows.Forms.Button DeletePartsBtn;
        private System.Windows.Forms.Button ModifyPartsBtn;
        private System.Windows.Forms.Button SeachProductsBtn;
        private System.Windows.Forms.Button SearchPartsBtn;
        private System.Windows.Forms.DataGridView partsShowBox;
        private System.Windows.Forms.DataGridView ProductsShowBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchPartsValue;
        private System.Windows.Forms.TextBox searchProductValue;
    }
}