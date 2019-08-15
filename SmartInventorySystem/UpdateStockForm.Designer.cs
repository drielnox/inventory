namespace SmartInventorySystem
{
    partial class frmStock_Update
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockBal = new System.Windows.Forms.TextBox();
            this.txtCancel = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDateAmend = new System.Windows.Forms.TextBox();
            this.txtUserAmend = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bsItemsSearched = new System.Windows.Forms.BindingSource(this.components);
            this.identifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardIssueQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economicOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markupPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsSearched)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(107, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Item ID";
            this.label1.Visible = false;
            // 
            // txtItemid
            // 
            this.txtItemid.BackColor = System.Drawing.Color.White;
            this.txtItemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemid.Location = new System.Drawing.Point(498, 22);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(120, 20);
            this.txtItemid.TabIndex = 50;
            this.txtItemid.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(199, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "UPDATE STOCK LEVEL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = "Stock Level";
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockLevel.Location = new System.Drawing.Point(107, 88);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(120, 20);
            this.txtStockLevel.TabIndex = 96;
            this.txtStockLevel.Text = "0";
            this.txtStockLevel.Leave += new System.EventHandler(this.txtStockLevel_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Add Quantity";
            // 
            // txtAdd
            // 
            this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdd.Location = new System.Drawing.Point(107, 125);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(120, 20);
            this.txtAdd.TabIndex = 98;
            this.txtAdd.Text = "0";
            this.txtAdd.Leave += new System.EventHandler(this.txtAdd_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Deduct Quantity";
            // 
            // txtDeduct
            // 
            this.txtDeduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeduct.Location = new System.Drawing.Point(107, 157);
            this.txtDeduct.Name = "txtDeduct";
            this.txtDeduct.Size = new System.Drawing.Size(120, 20);
            this.txtDeduct.TabIndex = 100;
            this.txtDeduct.Text = "0";
            this.txtDeduct.Leave += new System.EventHandler(this.txtDeduct_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Stock Balance";
            // 
            // txtStockBal
            // 
            this.txtStockBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockBal.Location = new System.Drawing.Point(498, 83);
            this.txtStockBal.Name = "txtStockBal";
            this.txtStockBal.ReadOnly = true;
            this.txtStockBal.Size = new System.Drawing.Size(120, 20);
            this.txtStockBal.TabIndex = 102;
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(543, 154);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 105;
            this.txtCancel.Text = "Close";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(463, 154);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 104;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifierDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.alternativeNameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.majorSupplierDataGridViewTextBoxColumn,
            this.packQuantityDataGridViewTextBoxColumn,
            this.packDescriptionDataGridViewTextBoxColumn,
            this.alternativeItemDataGridViewTextBoxColumn,
            this.standardIssueQuantityDataGridViewTextBoxColumn,
            this.economicOrderQuantityDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.markupPercentDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockLevelDataGridViewTextBoxColumn,
            this.minimumLevelDataGridViewTextBoxColumn,
            this.reOrderLevelDataGridViewTextBoxColumn,
            this.maximumLevelDataGridViewTextBoxColumn,
            this.leadDaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsItemsSearched;
            this.dataGridView1.Location = new System.Drawing.Point(320, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 87);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(562, 133);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(83, 23);
            this.btnSelect.TabIndex = 110;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(11, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(252, 20);
            this.label21.TabIndex = 106;
            this.label21.Text = "Search Drug by Name or Code";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(15, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 107;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(208, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDateAmend
            // 
            this.txtDateAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateAmend.Location = new System.Drawing.Point(608, 9);
            this.txtDateAmend.Name = "txtDateAmend";
            this.txtDateAmend.Size = new System.Drawing.Size(46, 20);
            this.txtDateAmend.TabIndex = 111;
            this.txtDateAmend.Visible = false;
            // 
            // txtUserAmend
            // 
            this.txtUserAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAmend.Location = new System.Drawing.Point(555, 9);
            this.txtUserAmend.Name = "txtUserAmend";
            this.txtUserAmend.Size = new System.Drawing.Size(47, 20);
            this.txtUserAmend.TabIndex = 112;
            this.txtUserAmend.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 114;
            this.label22.Text = "Item Code";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(107, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 20);
            this.txtCode.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(481, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 115;
            this.label5.Text = "On Save, this will overwrite \r\nthe \"Stock Level\" data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.txtStockLevel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDeduct);
            this.panel1.Controls.Add(this.txtCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtItemid);
            this.panel1.Controls.Add(this.txtStockBal);
            this.panel1.Location = new System.Drawing.Point(12, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 187);
            this.panel1.TabIndex = 116;
            this.panel1.Visible = false;
            // 
            // bsItemsSearched
            // 
            this.bsItemsSearched.AllowNew = false;
            this.bsItemsSearched.DataSource = typeof(SmartInventorySystem.ViewModel.ItemViewModel);
            // 
            // identifierDataGridViewTextBoxColumn
            // 
            this.identifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn.Name = "identifierDataGridViewTextBoxColumn";
            this.identifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeNameDataGridViewTextBoxColumn
            // 
            this.alternativeNameDataGridViewTextBoxColumn.DataPropertyName = "AlternativeName";
            this.alternativeNameDataGridViewTextBoxColumn.HeaderText = "AlternativeName";
            this.alternativeNameDataGridViewTextBoxColumn.Name = "alternativeNameDataGridViewTextBoxColumn";
            this.alternativeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // majorSupplierDataGridViewTextBoxColumn
            // 
            this.majorSupplierDataGridViewTextBoxColumn.DataPropertyName = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.HeaderText = "MajorSupplier";
            this.majorSupplierDataGridViewTextBoxColumn.Name = "majorSupplierDataGridViewTextBoxColumn";
            this.majorSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packQuantityDataGridViewTextBoxColumn
            // 
            this.packQuantityDataGridViewTextBoxColumn.DataPropertyName = "PackQuantity";
            this.packQuantityDataGridViewTextBoxColumn.HeaderText = "PackQuantity";
            this.packQuantityDataGridViewTextBoxColumn.Name = "packQuantityDataGridViewTextBoxColumn";
            this.packQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packDescriptionDataGridViewTextBoxColumn
            // 
            this.packDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PackDescription";
            this.packDescriptionDataGridViewTextBoxColumn.HeaderText = "PackDescription";
            this.packDescriptionDataGridViewTextBoxColumn.Name = "packDescriptionDataGridViewTextBoxColumn";
            this.packDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeItemDataGridViewTextBoxColumn
            // 
            this.alternativeItemDataGridViewTextBoxColumn.DataPropertyName = "AlternativeItem";
            this.alternativeItemDataGridViewTextBoxColumn.HeaderText = "AlternativeItem";
            this.alternativeItemDataGridViewTextBoxColumn.Name = "alternativeItemDataGridViewTextBoxColumn";
            this.alternativeItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // standardIssueQuantityDataGridViewTextBoxColumn
            // 
            this.standardIssueQuantityDataGridViewTextBoxColumn.DataPropertyName = "StandardIssueQuantity";
            this.standardIssueQuantityDataGridViewTextBoxColumn.HeaderText = "StandardIssueQuantity";
            this.standardIssueQuantityDataGridViewTextBoxColumn.Name = "standardIssueQuantityDataGridViewTextBoxColumn";
            this.standardIssueQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economicOrderQuantityDataGridViewTextBoxColumn
            // 
            this.economicOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "EconomicOrderQuantity";
            this.economicOrderQuantityDataGridViewTextBoxColumn.HeaderText = "EconomicOrderQuantity";
            this.economicOrderQuantityDataGridViewTextBoxColumn.Name = "economicOrderQuantityDataGridViewTextBoxColumn";
            this.economicOrderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markupPercentDataGridViewTextBoxColumn
            // 
            this.markupPercentDataGridViewTextBoxColumn.DataPropertyName = "MarkupPercent";
            this.markupPercentDataGridViewTextBoxColumn.HeaderText = "MarkupPercent";
            this.markupPercentDataGridViewTextBoxColumn.Name = "markupPercentDataGridViewTextBoxColumn";
            this.markupPercentDataGridViewTextBoxColumn.ReadOnly = true;
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
            // minimumLevelDataGridViewTextBoxColumn
            // 
            this.minimumLevelDataGridViewTextBoxColumn.DataPropertyName = "MinimumLevel";
            this.minimumLevelDataGridViewTextBoxColumn.HeaderText = "MinimumLevel";
            this.minimumLevelDataGridViewTextBoxColumn.Name = "minimumLevelDataGridViewTextBoxColumn";
            this.minimumLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reOrderLevelDataGridViewTextBoxColumn
            // 
            this.reOrderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.HeaderText = "ReOrderLevel";
            this.reOrderLevelDataGridViewTextBoxColumn.Name = "reOrderLevelDataGridViewTextBoxColumn";
            this.reOrderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximumLevelDataGridViewTextBoxColumn
            // 
            this.maximumLevelDataGridViewTextBoxColumn.DataPropertyName = "MaximumLevel";
            this.maximumLevelDataGridViewTextBoxColumn.HeaderText = "MaximumLevel";
            this.maximumLevelDataGridViewTextBoxColumn.Name = "maximumLevelDataGridViewTextBoxColumn";
            this.maximumLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leadDaysDataGridViewTextBoxColumn
            // 
            this.leadDaysDataGridViewTextBoxColumn.DataPropertyName = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.HeaderText = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.Name = "leadDaysDataGridViewTextBoxColumn";
            this.leadDaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmStock_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserAmend);
            this.Controls.Add(this.txtDateAmend);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStock_Update";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Update";
            this.Load += new System.EventHandler(this.frmStock_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsSearched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockBal;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDateAmend;
        private System.Windows.Forms.TextBox txtUserAmend;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardIssueQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economicOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markupPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsItemsSearched;
    }
}