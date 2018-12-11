namespace A2Programming
{
    partial class Form1
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
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblTypeBreak = new System.Windows.Forms.Label();
            this.lblTypeLunch = new System.Windows.Forms.Label();
            this.lblTypeDinner = new System.Windows.Forms.Label();
            this.cmbBreakfast = new System.Windows.Forms.ComboBox();
            this.cmbLunch = new System.Windows.Forms.ComboBox();
            this.cmbDinner = new System.Windows.Forms.ComboBox();
            this.lblQuantityBreak = new System.Windows.Forms.Label();
            this.lblQuantityLunch = new System.Windows.Forms.Label();
            this.lblQuantityDinner = new System.Windows.Forms.Label();
            this.txtBreakfast = new System.Windows.Forms.TextBox();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblErrorBreak = new System.Windows.Forms.Label();
            this.lblErrorLunch = new System.Windows.Forms.Label();
            this.lblErrorDinner = new System.Windows.Forms.Label();
            this.lblPriceSub = new System.Windows.Forms.Label();
            this.lblPriceTax = new System.Windows.Forms.Label();
            this.lblPriceTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Location = new System.Drawing.Point(52, 46);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(68, 17);
            this.lblBreakfast.TabIndex = 0;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(52, 92);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(47, 17);
            this.lblLunch.TabIndex = 1;
            this.lblLunch.Text = "Lunch";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Location = new System.Drawing.Point(52, 139);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(50, 17);
            this.lblDinner.TabIndex = 2;
            this.lblDinner.Text = "Dinner";
            // 
            // lblTypeBreak
            // 
            this.lblTypeBreak.AutoSize = true;
            this.lblTypeBreak.Location = new System.Drawing.Point(144, 46);
            this.lblTypeBreak.Name = "lblTypeBreak";
            this.lblTypeBreak.Size = new System.Drawing.Size(40, 17);
            this.lblTypeBreak.TabIndex = 3;
            this.lblTypeBreak.Text = "Type";
            // 
            // lblTypeLunch
            // 
            this.lblTypeLunch.AutoSize = true;
            this.lblTypeLunch.Location = new System.Drawing.Point(144, 92);
            this.lblTypeLunch.Name = "lblTypeLunch";
            this.lblTypeLunch.Size = new System.Drawing.Size(40, 17);
            this.lblTypeLunch.TabIndex = 4;
            this.lblTypeLunch.Text = "Type";
            // 
            // lblTypeDinner
            // 
            this.lblTypeDinner.AutoSize = true;
            this.lblTypeDinner.Location = new System.Drawing.Point(144, 139);
            this.lblTypeDinner.Name = "lblTypeDinner";
            this.lblTypeDinner.Size = new System.Drawing.Size(40, 17);
            this.lblTypeDinner.TabIndex = 5;
            this.lblTypeDinner.Text = "Type";
            // 
            // cmbBreakfast
            // 
            this.cmbBreakfast.FormattingEnabled = true;
            this.cmbBreakfast.Items.AddRange(new object[] {
            "Bagel",
            "Vegetarian Special",
            "Protein Platter"});
            this.cmbBreakfast.Location = new System.Drawing.Point(190, 43);
            this.cmbBreakfast.Name = "cmbBreakfast";
            this.cmbBreakfast.Size = new System.Drawing.Size(176, 24);
            this.cmbBreakfast.TabIndex = 6;
            // 
            // cmbLunch
            // 
            this.cmbLunch.FormattingEnabled = true;
            this.cmbLunch.Items.AddRange(new object[] {
            "Bagel",
            "Vegetarian Special",
            "Protein Platter"});
            this.cmbLunch.Location = new System.Drawing.Point(190, 89);
            this.cmbLunch.Name = "cmbLunch";
            this.cmbLunch.Size = new System.Drawing.Size(176, 24);
            this.cmbLunch.TabIndex = 7;
            // 
            // cmbDinner
            // 
            this.cmbDinner.FormattingEnabled = true;
            this.cmbDinner.Items.AddRange(new object[] {
            "Bagel",
            "Vegetarian Special",
            "Protein Platter"});
            this.cmbDinner.Location = new System.Drawing.Point(190, 136);
            this.cmbDinner.Name = "cmbDinner";
            this.cmbDinner.Size = new System.Drawing.Size(176, 24);
            this.cmbDinner.TabIndex = 8;
            // 
            // lblQuantityBreak
            // 
            this.lblQuantityBreak.AutoSize = true;
            this.lblQuantityBreak.Location = new System.Drawing.Point(415, 46);
            this.lblQuantityBreak.Name = "lblQuantityBreak";
            this.lblQuantityBreak.Size = new System.Drawing.Size(61, 17);
            this.lblQuantityBreak.TabIndex = 9;
            this.lblQuantityBreak.Text = "Quantity";
            // 
            // lblQuantityLunch
            // 
            this.lblQuantityLunch.AutoSize = true;
            this.lblQuantityLunch.Location = new System.Drawing.Point(415, 92);
            this.lblQuantityLunch.Name = "lblQuantityLunch";
            this.lblQuantityLunch.Size = new System.Drawing.Size(61, 17);
            this.lblQuantityLunch.TabIndex = 10;
            this.lblQuantityLunch.Text = "Quantity";
            // 
            // lblQuantityDinner
            // 
            this.lblQuantityDinner.AutoSize = true;
            this.lblQuantityDinner.Location = new System.Drawing.Point(415, 139);
            this.lblQuantityDinner.Name = "lblQuantityDinner";
            this.lblQuantityDinner.Size = new System.Drawing.Size(61, 17);
            this.lblQuantityDinner.TabIndex = 11;
            this.lblQuantityDinner.Text = "Quantity";
            // 
            // txtBreakfast
            // 
            this.txtBreakfast.Location = new System.Drawing.Point(482, 43);
            this.txtBreakfast.Name = "txtBreakfast";
            this.txtBreakfast.Size = new System.Drawing.Size(100, 22);
            this.txtBreakfast.TabIndex = 12;
            // 
            // txtLunch
            // 
            this.txtLunch.Location = new System.Drawing.Point(482, 89);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(100, 22);
            this.txtLunch.TabIndex = 13;
            // 
            // txtDinner
            // 
            this.txtDinner.Location = new System.Drawing.Point(483, 136);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(100, 22);
            this.txtDinner.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(245, 204);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 46);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(418, 204);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(69, 17);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(415, 250);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 17);
            this.lblTax.TabIndex = 17;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(415, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // lblErrorBreak
            // 
            this.lblErrorBreak.AutoSize = true;
            this.lblErrorBreak.Location = new System.Drawing.Point(630, 46);
            this.lblErrorBreak.Name = "lblErrorBreak";
            this.lblErrorBreak.Size = new System.Drawing.Size(0, 17);
            this.lblErrorBreak.TabIndex = 19;
            // 
            // lblErrorLunch
            // 
            this.lblErrorLunch.AutoSize = true;
            this.lblErrorLunch.Location = new System.Drawing.Point(630, 92);
            this.lblErrorLunch.Name = "lblErrorLunch";
            this.lblErrorLunch.Size = new System.Drawing.Size(0, 17);
            this.lblErrorLunch.TabIndex = 20;
            // 
            // lblErrorDinner
            // 
            this.lblErrorDinner.AutoSize = true;
            this.lblErrorDinner.Location = new System.Drawing.Point(630, 139);
            this.lblErrorDinner.Name = "lblErrorDinner";
            this.lblErrorDinner.Size = new System.Drawing.Size(0, 17);
            this.lblErrorDinner.TabIndex = 21;
            // 
            // lblPriceSub
            // 
            this.lblPriceSub.AutoSize = true;
            this.lblPriceSub.Location = new System.Drawing.Point(527, 204);
            this.lblPriceSub.Name = "lblPriceSub";
            this.lblPriceSub.Size = new System.Drawing.Size(0, 17);
            this.lblPriceSub.TabIndex = 22;
            // 
            // lblPriceTax
            // 
            this.lblPriceTax.AutoSize = true;
            this.lblPriceTax.Location = new System.Drawing.Point(527, 250);
            this.lblPriceTax.Name = "lblPriceTax";
            this.lblPriceTax.Size = new System.Drawing.Size(0, 17);
            this.lblPriceTax.TabIndex = 23;
            // 
            // lblPriceTotal
            // 
            this.lblPriceTotal.AutoSize = true;
            this.lblPriceTotal.Location = new System.Drawing.Point(527, 296);
            this.lblPriceTotal.Name = "lblPriceTotal";
            this.lblPriceTotal.Size = new System.Drawing.Size(0, 17);
            this.lblPriceTotal.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.lblPriceTotal);
            this.Controls.Add(this.lblPriceTax);
            this.Controls.Add(this.lblPriceSub);
            this.Controls.Add(this.lblErrorDinner);
            this.Controls.Add(this.lblErrorLunch);
            this.Controls.Add(this.lblErrorBreak);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtDinner);
            this.Controls.Add(this.txtLunch);
            this.Controls.Add(this.txtBreakfast);
            this.Controls.Add(this.lblQuantityDinner);
            this.Controls.Add(this.lblQuantityLunch);
            this.Controls.Add(this.lblQuantityBreak);
            this.Controls.Add(this.cmbDinner);
            this.Controls.Add(this.cmbLunch);
            this.Controls.Add(this.cmbBreakfast);
            this.Controls.Add(this.lblTypeDinner);
            this.Controls.Add(this.lblTypeLunch);
            this.Controls.Add(this.lblTypeBreak);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBreakfast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblTypeBreak;
        private System.Windows.Forms.Label lblTypeLunch;
        private System.Windows.Forms.Label lblTypeDinner;
        private System.Windows.Forms.ComboBox cmbBreakfast;
        private System.Windows.Forms.ComboBox cmbLunch;
        private System.Windows.Forms.ComboBox cmbDinner;
        private System.Windows.Forms.Label lblQuantityBreak;
        private System.Windows.Forms.Label lblQuantityLunch;
        private System.Windows.Forms.Label lblQuantityDinner;
        private System.Windows.Forms.TextBox txtBreakfast;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblErrorBreak;
        private System.Windows.Forms.Label lblErrorLunch;
        private System.Windows.Forms.Label lblErrorDinner;
        private System.Windows.Forms.Label lblPriceSub;
        private System.Windows.Forms.Label lblPriceTax;
        private System.Windows.Forms.Label lblPriceTotal;
    }
}

