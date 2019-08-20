namespace SmartInventorySystem.WinForms.Controls
{
    partial class DispenseCartControl
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
            System.Windows.Forms.GroupBox gbCart;
            System.Windows.Forms.ToolStrip tsCart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispenseCartControl));
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label6;
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.identifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItemsToCheckout = new System.Windows.Forms.BindingSource(this.components);
            this.bsControl = new System.Windows.Forms.BindingSource(this.components);
            this.tsbRemoveItemCart = new System.Windows.Forms.ToolStripButton();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.nudVat = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            gbCart = new System.Windows.Forms.GroupBox();
            tsCart = new System.Windows.Forms.ToolStrip();
            label7 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsToCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).BeginInit();
            tsCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCart
            // 
            gbCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbCart.Controls.Add(this.dgvCart);
            gbCart.Controls.Add(tsCart);
            gbCart.Location = new System.Drawing.Point(3, 3);
            gbCart.Name = "gbCart";
            gbCart.Size = new System.Drawing.Size(409, 463);
            gbCart.TabIndex = 1;
            gbCart.TabStop = false;
            gbCart.Text = "Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifierDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dgvCart.DataSource = this.bsItemsToCheckout;
            this.dgvCart.Location = new System.Drawing.Point(3, 44);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(403, 413);
            this.dgvCart.TabIndex = 1;
            // 
            // identifierDataGridViewTextBoxColumn
            // 
            this.identifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn.Name = "identifierDataGridViewTextBoxColumn";
            this.identifierDataGridViewTextBoxColumn.ReadOnly = true;
            this.identifierDataGridViewTextBoxColumn.Width = 72;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 71;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 75;
            // 
            // bsItemsToCheckout
            // 
            this.bsItemsToCheckout.DataMember = "ItemsToCheckout";
            this.bsItemsToCheckout.DataSource = this.bsControl;
            // 
            // bsControl
            // 
            this.bsControl.DataSource = typeof(SmartInventorySystem.ViewModel.Controls.DispenseCartControlViewModel);
            // 
            // tsCart
            // 
            tsCart.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRemoveItemCart});
            tsCart.Location = new System.Drawing.Point(3, 16);
            tsCart.Name = "tsCart";
            tsCart.Size = new System.Drawing.Size(403, 25);
            tsCart.TabIndex = 0;
            tsCart.Text = "toolStrip1";
            // 
            // tsbRemoveItemCart
            // 
            this.tsbRemoveItemCart.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveItemCart.Image")));
            this.tsbRemoveItemCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveItemCart.Name = "tsbRemoveItemCart";
            this.tsbRemoveItemCart.Size = new System.Drawing.Size(70, 22);
            this.tsbRemoveItemCart.Text = "Remove";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(3, 474);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 13);
            label7.TabIndex = 128;
            label7.Text = "Subtotal";
            // 
            // label17
            // 
            label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(3, 500);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(66, 13);
            label17.TabIndex = 150;
            label17.Text = "Discount (N)";
            // 
            // label16
            // 
            label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(3, 552);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(36, 13);
            label16.TabIndex = 149;
            label16.Text = "Total";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 526);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 13);
            label6.TabIndex = 147;
            label6.Text = "VAT (%)";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "SubTotal", true));
            this.txtAmountTotal.Location = new System.Drawing.Point(288, 472);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.ReadOnly = true;
            this.txtAmountTotal.Size = new System.Drawing.Size(121, 20);
            this.txtAmountTotal.TabIndex = 127;
            this.txtAmountTotal.Text = "0";
            // 
            // nudVat
            // 
            this.nudVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsControl, "Vat", true));
            this.nudVat.Location = new System.Drawing.Point(288, 524);
            this.nudVat.Name = "nudVat";
            this.nudVat.Size = new System.Drawing.Size(121, 20);
            this.nudVat.TabIndex = 153;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsControl, "Discount", true));
            this.nudDiscount.Location = new System.Drawing.Point(288, 498);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(121, 20);
            this.nudDiscount.TabIndex = 152;
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsControl, "Total", true));
            this.txtTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFinal.Location = new System.Drawing.Point(288, 550);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFinal.TabIndex = 148;
            this.txtTotalFinal.Text = "0";
            // 
            // DispenseCartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudVat);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(label17);
            this.Controls.Add(label16);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtAmountTotal);
            this.Controls.Add(gbCart);
            this.Name = "DispenseCartControl";
            this.Size = new System.Drawing.Size(415, 573);
            gbCart.ResumeLayout(false);
            gbCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsToCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControl)).EndInit();
            tsCart.ResumeLayout(false);
            tsCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ToolStripButton tsbRemoveItemCart;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.NumericUpDown nudVat;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.BindingSource bsControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsItemsToCheckout;
    }
}
