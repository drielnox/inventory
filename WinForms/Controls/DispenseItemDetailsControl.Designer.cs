namespace SmartInventorySystem.WinForms
{
    partial class DispenseItemDetailsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblItemCode;
            System.Windows.Forms.Label lblItemId;
            System.Windows.Forms.Label lblItemName;
            System.Windows.Forms.Label lblAmount;
            System.Windows.Forms.Label lblStockLevel;
            System.Windows.Forms.Label lblQuantityToDispense;
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.bsControl = new System.Windows.Forms.BindingSource(this.components);
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockBal = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtDispenseQty = new System.Windows.Forms.TextBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            lblItemCode = new System.Windows.Forms.Label();
            lblItemId = new System.Windows.Forms.Label();
            lblItemName = new System.Windows.Forms.Label();
            lblAmount = new System.Windows.Forms.Label();
            lblStockLevel = new System.Windows.Forms.Label();
            lblQuantityToDispense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Location = new System.Drawing.Point(3, 38);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new System.Drawing.Size(55, 13);
            lblItemCode.TabIndex = 156;
            lblItemCode.Text = "Item Code";
            lblItemCode.Visible = false;
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new System.Drawing.Point(3, 7);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new System.Drawing.Size(41, 13);
            lblItemId.TabIndex = 140;
            lblItemId.Text = "Item ID";
            lblItemId.Visible = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new System.Drawing.Point(3, 67);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new System.Drawing.Size(58, 13);
            lblItemName.TabIndex = 143;
            lblItemName.Text = "Item Name";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(3, 193);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(60, 13);
            lblAmount.TabIndex = 153;
            lblAmount.Text = "Amount (N)";
            lblAmount.Visible = false;
            // 
            // lblStockLevel
            // 
            lblStockLevel.AutoSize = true;
            lblStockLevel.Location = new System.Drawing.Point(3, 97);
            lblStockLevel.Name = "lblStockLevel";
            lblStockLevel.Size = new System.Drawing.Size(64, 13);
            lblStockLevel.TabIndex = 145;
            lblStockLevel.Text = "Stock Level";
            lblStockLevel.Visible = false;
            // 
            // lblQuantityToDispense
            // 
            lblQuantityToDispense.AutoSize = true;
            lblQuantityToDispense.Location = new System.Drawing.Point(3, 159);
            lblQuantityToDispense.Name = "lblQuantityToDispense";
            lblQuantityToDispense.Size = new System.Drawing.Size(105, 13);
            lblQuantityToDispense.TabIndex = 149;
            lblQuantityToDispense.Text = "Quantity to Dispense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(281, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 157;
            this.label8.Text = "On Save, this will overwrite \r\nthe \"Stock Level\" data";
            this.label8.Visible = false;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "Code", true));
            this.txtItemCode.Location = new System.Drawing.Point(112, 31);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(185, 20);
            this.txtItemCode.TabIndex = 141;
            this.txtItemCode.Visible = false;
            // 
            // bsControl
            // 
            this.bsControl.DataSource = typeof(SmartInventorySystem.ViewModel.Forms.Grids.ItemRowViewModel);
            // 
            // txtItemId
            // 
            this.txtItemId.BackColor = System.Drawing.Color.White;
            this.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "Identifier", true));
            this.txtItemId.Location = new System.Drawing.Point(112, 5);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(26, 20);
            this.txtItemId.TabIndex = 139;
            this.txtItemId.Visible = false;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "Name", true));
            this.txtItemName.Location = new System.Drawing.Point(112, 62);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 142;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(315, 220);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 23);
            this.btnAddItem.TabIndex = 154;
            this.btnAddItem.Text = "Add to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "StockLevel", true));
            this.txtStockLevel.Location = new System.Drawing.Point(112, 95);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.ReadOnly = true;
            this.txtStockLevel.Size = new System.Drawing.Size(120, 20);
            this.txtStockLevel.TabIndex = 144;
            this.txtStockLevel.Text = "0";
            this.txtStockLevel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "Stock Balance";
            this.label4.Visible = false;
            // 
            // txtStockBal
            // 
            this.txtStockBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockBal.Location = new System.Drawing.Point(364, 95);
            this.txtStockBal.Name = "txtStockBal";
            this.txtStockBal.ReadOnly = true;
            this.txtStockBal.Size = new System.Drawing.Size(52, 20);
            this.txtStockBal.TabIndex = 150;
            this.txtStockBal.Text = "0";
            this.txtStockBal.Visible = false;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(3, 127);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(70, 13);
            this.lblUnitPrice.TabIndex = 147;
            this.lblUnitPrice.Text = "Unit Price (N)";
            // 
            // txtDispenseQty
            // 
            this.txtDispenseQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDispenseQty.Location = new System.Drawing.Point(112, 157);
            this.txtDispenseQty.Name = "txtDispenseQty";
            this.txtDispenseQty.Size = new System.Drawing.Size(120, 20);
            this.txtDispenseQty.TabIndex = 148;
            this.txtDispenseQty.Text = "0";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(112, 125);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.nudUnitPrice.TabIndex = 164;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(112, 191);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAmount.TabIndex = 165;
            // 
            // DispenseItemDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(lblItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(lblItemId);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(lblItemName);
            this.Controls.Add(lblAmount);
            this.Controls.Add(this.txtStockLevel);
            this.Controls.Add(lblStockLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockBal);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(lblQuantityToDispense);
            this.Controls.Add(this.txtDispenseQty);
            this.Name = "DispenseItemDetailsUserControl";
            this.Size = new System.Drawing.Size(428, 246);
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockBal;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtDispenseQty;
        private System.Windows.Forms.BindingSource bsControl;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}
