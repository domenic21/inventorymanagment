namespace ManagmentSystemUI
{
    partial class AddPartForm
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
            this.inHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.addPartIDValue = new System.Windows.Forms.TextBox();
            this.addPartNameValue = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.TextBox();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSwitch2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.priceCostValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.addPartsSaveBtn = new System.Windows.Forms.Button();
            this.addPartsCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Parts";
            // 
            // inHouseRadioBtn
            // 
            this.inHouseRadioBtn.AutoSize = true;
            this.inHouseRadioBtn.Location = new System.Drawing.Point(217, 15);
            this.inHouseRadioBtn.Name = "inHouseRadioBtn";
            this.inHouseRadioBtn.Size = new System.Drawing.Size(149, 32);
            this.inHouseRadioBtn.TabIndex = 1;
            this.inHouseRadioBtn.TabStop = true;
            this.inHouseRadioBtn.Text = "In-House";
            this.inHouseRadioBtn.UseVisualStyleBackColor = true;
            this.inHouseRadioBtn.CheckedChanged += new System.EventHandler(this.inHouseRadioBtn_CheckedChanged);
            // 
            // outsourcedRadioBtn
            // 
            this.outsourcedRadioBtn.AutoSize = true;
            this.outsourcedRadioBtn.Location = new System.Drawing.Point(351, 12);
            this.outsourcedRadioBtn.Name = "outsourcedRadioBtn";
            this.outsourcedRadioBtn.Size = new System.Drawing.Size(177, 32);
            this.outsourcedRadioBtn.TabIndex = 2;
            this.outsourcedRadioBtn.TabStop = true;
            this.outsourcedRadioBtn.Text = "Outsourced";
            this.outsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.outsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.outsourcedRadioBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // addPartIDValue
            // 
            this.addPartIDValue.Location = new System.Drawing.Point(249, 72);
            this.addPartIDValue.Name = "addPartIDValue";
            this.addPartIDValue.Size = new System.Drawing.Size(187, 35);
            this.addPartIDValue.TabIndex = 4;
            // 
            // addPartNameValue
            // 
            this.addPartNameValue.Location = new System.Drawing.Point(249, 133);
            this.addPartNameValue.Name = "addPartNameValue";
            this.addPartNameValue.Size = new System.Drawing.Size(187, 35);
            this.addPartNameValue.TabIndex = 6;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(126, 140);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(68, 28);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Name";
            // 
            // inventoryValue
            // 
            this.inventoryValue.Location = new System.Drawing.Point(249, 193);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(187, 35);
            this.inventoryValue.TabIndex = 8;
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.Location = new System.Drawing.Point(112, 203);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(138, 28);
            this.inventorylabel.TabIndex = 7;
            this.inventorylabel.Text = "Inventory";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(217, 307);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(50, 35);
            this.maxValue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price / Cost";
            // 
            // labelSwitch2
            // 
            this.labelSwitch2.Location = new System.Drawing.Point(301, 374);
            this.labelSwitch2.Name = "labelSwitch2";
            this.labelSwitch2.Size = new System.Drawing.Size(187, 35);
            this.labelSwitch2.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(112, 381);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 28);
            this.label.TabIndex = 13;
            this.label.Text = "Machine ID";
            // 
            // priceCostValue
            // 
            this.priceCostValue.Location = new System.Drawing.Point(249, 256);
            this.priceCostValue.Name = "priceCostValue";
            this.priceCostValue.Size = new System.Drawing.Size(187, 35);
            this.priceCostValue.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Min";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(351, 307);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(50, 35);
            this.minValue.TabIndex = 17;
            // 
            // addPartsSaveBtn
            // 
            this.addPartsSaveBtn.Location = new System.Drawing.Point(335, 437);
            this.addPartsSaveBtn.Name = "addPartsSaveBtn";
            this.addPartsSaveBtn.Size = new System.Drawing.Size(75, 29);
            this.addPartsSaveBtn.TabIndex = 19;
            this.addPartsSaveBtn.Text = "Save";
            this.addPartsSaveBtn.UseVisualStyleBackColor = true;
            this.addPartsSaveBtn.Click += new System.EventHandler(this.addPartsSaveBtn_Click);
            // 
            // addPartsCancelBtn
            // 
            this.addPartsCancelBtn.Location = new System.Drawing.Point(433, 437);
            this.addPartsCancelBtn.Name = "addPartsCancelBtn";
            this.addPartsCancelBtn.Size = new System.Drawing.Size(85, 29);
            this.addPartsCancelBtn.TabIndex = 20;
            this.addPartsCancelBtn.Text = "Cancel";
            this.addPartsCancelBtn.UseVisualStyleBackColor = true;
            this.addPartsCancelBtn.Click += new System.EventHandler(this.addPartsCancelBtn_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 499);
            this.Controls.Add(this.addPartsCancelBtn);
            this.Controls.Add(this.addPartsSaveBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.priceCostValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSwitch2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inventoryValue);
            this.Controls.Add(this.inventorylabel);
            this.Controls.Add(this.addPartNameValue);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.addPartIDValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outsourcedRadioBtn);
            this.Controls.Add(this.inHouseRadioBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddPartForm";
            this.Text = "AddPartForm";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseRadioBtn;
        private System.Windows.Forms.RadioButton outsourcedRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addPartIDValue;
        private System.Windows.Forms.TextBox addPartNameValue;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox inventoryValue;
        private System.Windows.Forms.Label inventorylabel;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelSwitch2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox priceCostValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.Button addPartsSaveBtn;
        private System.Windows.Forms.Button addPartsCancelBtn;
    }
}