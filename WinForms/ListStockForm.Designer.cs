using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms
{
    partial class frmStockSheet
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsStock = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(728, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.majorSupplierDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.reOrderLevelDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsStock;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(815, 325);
            this.dataGridView1.TabIndex = 58;
            // 
            // bsStock
            // 
            this.bsStock.AllowNew = false;
            this.bsStock.DataSource = typeof(StockViewModel);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // majorSupplierDataGridViewTextBoxColumn
            // 
            this.majorSupplierDataGridViewTextBoxColumn.DataPropertyName = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.HeaderText = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.Name = "majorSupplierDataGridViewTextBoxColumn";
            this.majorSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reOrderLevelDataGridViewTextBoxColumn
            // 
            this.reOrderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.HeaderText = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.Name = "reOrderLevelDataGridViewTextBoxColumn";
            this.reOrderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockLevelDataGridViewTextBoxColumn
            // 
            this.stockLevelDataGridViewTextBoxColumn.DataPropertyName = "StockLevel";
            this.stockLevelDataGridViewTextBoxColumn.HeaderText = "StockLevel";
            this.stockLevelDataGridViewTextBoxColumn.Name = "stockLevelDataGridViewTextBoxColumn";
            this.stockLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmStockSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStockSheet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Record Sheet";
            this.Load += new System.EventHandler(this.frmStockSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
    }
}