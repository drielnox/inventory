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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblItemId;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            this.bsControl = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblItemIdentifier = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            lblItemId = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(144, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 156;
            label2.Text = "Code:";
            label2.Visible = false;
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new System.Drawing.Point(3, 7);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new System.Drawing.Size(50, 13);
            lblItemId.TabIndex = 140;
            lblItemId.Text = "Identifier:";
            lblItemId.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 143;
            label3.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 13);
            label5.TabIndex = 149;
            label5.Text = "Quantity to Dispense";
            // 
            // bsControl
            // 
            this.bsControl.DataSource = typeof(SmartInventorySystem.ViewModel.Controls.DispenseItemDetailsControlViewModel);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(254, 122);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(79, 23);
            this.btnAddItem.TabIndex = 154;
            this.btnAddItem.Text = "Add to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 147;
            this.label4.Text = "Unit Price";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsControl, "UnitPrice", true));
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Location = new System.Drawing.Point(114, 51);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.nudUnitPrice.TabIndex = 164;
            // 
            // lblItemIdentifier
            // 
            this.lblItemIdentifier.AutoSize = true;
            this.lblItemIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "ItemId", true));
            this.lblItemIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIdentifier.Location = new System.Drawing.Point(59, 7);
            this.lblItemIdentifier.Name = "lblItemIdentifier";
            this.lblItemIdentifier.Size = new System.Drawing.Size(11, 13);
            this.lblItemIdentifier.TabIndex = 165;
            this.lblItemIdentifier.Text = "-";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "ItemCode", true));
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(185, 7);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(11, 13);
            this.lblItemCode.TabIndex = 166;
            this.lblItemCode.Text = "-";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "ItemName", true));
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(47, 25);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(11, 13);
            this.lblItemName.TabIndex = 167;
            this.lblItemName.Text = "-";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bsControl, "StockLevel", true));
            this.nudQuantity.Location = new System.Drawing.Point(114, 77);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 168;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DispenseItemDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lblItemIdentifier);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(label2);
            this.Controls.Add(lblItemId);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(label5);
            this.Name = "DispenseItemDetailsUserControl";
            this.Size = new System.Drawing.Size(336, 148);
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsControl;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.Label lblItemIdentifier;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
