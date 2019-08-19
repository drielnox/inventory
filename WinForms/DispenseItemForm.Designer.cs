using SmartInventorySystem.ViewModel;

namespace SmartInventorySystem.WinForms
{
    partial class DispenseItemForm
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
            System.Windows.Forms.GroupBox gbCart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispenseItemForm));
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.bsCart = new System.Windows.Forms.BindingSource(this.components);
            this.dsCart = new SmartInventorySystem.WinForms.DispenseCartDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRemoveItemCart = new System.Windows.Forms.ToolStripButton();
            this.txtCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockBal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDispenseQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdispStatus = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgroupDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDspid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSearchedItem = new System.Windows.Forms.DataGridView();
            this.bsSearchedItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.txtUserAmend = new System.Windows.Forms.TextBox();
            this.txtDateAmend = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsForm = new System.Windows.Forms.BindingSource(this.components);
            gbCart = new System.Windows.Forms.GroupBox();
            gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCart)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearchedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCart
            // 
            gbCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gbCart.Controls.Add(this.dgvCart);
            gbCart.Controls.Add(this.toolStrip1);
            gbCart.Location = new System.Drawing.Point(3, 12);
            gbCart.Name = "gbCart";
            gbCart.Size = new System.Drawing.Size(322, 477);
            gbCart.TabIndex = 0;
            gbCart.TabStop = false;
            gbCart.Text = "Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.DataSource = this.bsCart;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCart.Location = new System.Drawing.Point(3, 44);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(316, 430);
            this.dgvCart.TabIndex = 1;
            // 
            // bsCart
            // 
            this.bsCart.DataSource = this.dsCart;
            this.bsCart.Position = 0;
            // 
            // dsCart
            // 
            this.dsCart.DataSetName = "DispenseCartDataSet";
            this.dsCart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRemoveItemCart});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(316, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRemoveItemCart
            // 
            this.tsbRemoveItemCart.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveItemCart.Image")));
            this.tsbRemoveItemCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveItemCart.Name = "tsbRemoveItemCart";
            this.tsbRemoveItemCart.Size = new System.Drawing.Size(70, 22);
            this.tsbRemoveItemCart.Text = "Remove";
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(165, 274);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 120;
            this.txtCancel.Text = "Close";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(65, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Stock Balance";
            this.label4.Visible = false;
            // 
            // txtStockBal
            // 
            this.txtStockBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockBal.Location = new System.Drawing.Point(333, 75);
            this.txtStockBal.Name = "txtStockBal";
            this.txtStockBal.ReadOnly = true;
            this.txtStockBal.Size = new System.Drawing.Size(52, 20);
            this.txtStockBal.TabIndex = 117;
            this.txtStockBal.Text = "0";
            this.txtStockBal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Quantity to Dispense";
            // 
            // txtDispenseQty
            // 
            this.txtDispenseQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDispenseQty.Location = new System.Drawing.Point(124, 137);
            this.txtDispenseQty.Name = "txtDispenseQty";
            this.txtDispenseQty.Size = new System.Drawing.Size(120, 20);
            this.txtDispenseQty.TabIndex = 115;
            this.txtDispenseQty.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Unit Price (N)";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Location = new System.Drawing.Point(124, 105);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.txtUnitPrice.TabIndex = 113;
            this.txtUnitPrice.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 112;
            this.label15.Text = "Stock Level";
            this.label15.Visible = false;
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockLevel.Location = new System.Drawing.Point(124, 75);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.ReadOnly = true;
            this.txtStockLevel.Size = new System.Drawing.Size(120, 20);
            this.txtStockLevel.TabIndex = 111;
            this.txtStockLevel.Text = "0";
            this.txtStockLevel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(308, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 110;
            this.label12.Text = "DISPENSE ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(124, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Item ID";
            this.label1.Visible = false;
            // 
            // txtItemid
            // 
            this.txtItemid.BackColor = System.Drawing.Color.White;
            this.txtItemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemid.Location = new System.Drawing.Point(362, 11);
            this.txtItemid.Name = "txtItemid";
            this.txtItemid.ReadOnly = true;
            this.txtItemid.Size = new System.Drawing.Size(26, 20);
            this.txtItemid.TabIndex = 106;
            this.txtItemid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "Amount (N)";
            this.label5.Visible = false;
            // 
            // txtAmountSub
            // 
            this.txtAmountSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountSub.Location = new System.Drawing.Point(124, 171);
            this.txtAmountSub.Name = "txtAmountSub";
            this.txtAmountSub.Size = new System.Drawing.Size(120, 20);
            this.txtAmountSub.TabIndex = 121;
            this.txtAmountSub.Text = "0";
            this.txtAmountSub.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "VAT (%)";
            // 
            // txtVat
            // 
            this.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVat.Location = new System.Drawing.Point(119, 187);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(60, 20);
            this.txtVat.TabIndex = 123;
            this.txtVat.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 126;
            this.label7.Text = "Sub Total Amount (N)";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountTotal.Location = new System.Drawing.Point(119, 128);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.ReadOnly = true;
            this.txtAmountTotal.Size = new System.Drawing.Size(121, 20);
            this.txtAmountTotal.TabIndex = 125;
            this.txtAmountTotal.Text = "0";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(3, 277);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 23);
            this.btnAddItem.TabIndex = 128;
            this.btnAddItem.Text = "Add to Cart";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(119, 277);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(110, 23);
            this.btnCompute.TabIndex = 129;
            this.btnCompute.Text = "Checkout >>";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnComputeTotal);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtTotalFinal);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtdispStatus);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAmountTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtVat);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtCancel);
            this.panel2.Location = new System.Drawing.Point(466, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 303);
            this.panel2.TabIndex = 130;
            this.panel2.Visible = false;
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Enabled = false;
            this.btnComputeTotal.Location = new System.Drawing.Point(119, 240);
            this.btnComputeTotal.Name = "btnComputeTotal";
            this.btnComputeTotal.Size = new System.Drawing.Size(114, 23);
            this.btnComputeTotal.TabIndex = 144;
            this.btnComputeTotal.Text = "Compute Total";
            this.btnComputeTotal.UseVisualStyleBackColor = true;
            this.btnComputeTotal.Click += new System.EventHandler(this.btnComputeTotal_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 143;
            this.label17.Text = "Discount (N)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(119, 155);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 142;
            this.txtDiscount.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 141;
            this.label16.Text = "Total (N)";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFinal.Location = new System.Drawing.Point(119, 217);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.ReadOnly = true;
            this.txtTotalFinal.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFinal.TabIndex = 140;
            this.txtTotalFinal.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(246, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Dispense Executed";
            this.label14.Visible = false;
            // 
            // txtdispStatus
            // 
            this.txtdispStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdispStatus.Location = new System.Drawing.Point(249, 277);
            this.txtdispStatus.Name = "txtdispStatus";
            this.txtdispStatus.Size = new System.Drawing.Size(26, 20);
            this.txtdispStatus.TabIndex = 139;
            this.txtdispStatus.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(262, 87);
            this.dataGridView2.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtgroupDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtRandom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDspid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtItemid);
            this.panel1.Controls.Add(this.btnCompute);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStockLevel);
            this.panel1.Controls.Add(this.txtAmountSub);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtStockBal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDispenseQty);
            this.panel1.Location = new System.Drawing.Point(12, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 303);
            this.panel1.TabIndex = 131;
            this.panel1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 138;
            this.label13.Text = "Date";
            this.label13.Visible = false;
            // 
            // txtgroupDate
            // 
            this.txtgroupDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgroupDate.Location = new System.Drawing.Point(362, 270);
            this.txtgroupDate.Name = "txtgroupDate";
            this.txtgroupDate.Size = new System.Drawing.Size(26, 20);
            this.txtgroupDate.TabIndex = 137;
            this.txtgroupDate.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 136;
            this.label11.Text = "Rand";
            this.label11.Visible = false;
            // 
            // txtRandom
            // 
            this.txtRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRandom.Location = new System.Drawing.Point(361, 248);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(26, 20);
            this.txtRandom.TabIndex = 135;
            this.txtRandom.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "Dsp ID";
            this.label9.Visible = false;
            // 
            // txtDspid
            // 
            this.txtDspid.BackColor = System.Drawing.Color.White;
            this.txtDspid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDspid.Location = new System.Drawing.Point(362, 38);
            this.txtDspid.Name = "txtDspid";
            this.txtDspid.ReadOnly = true;
            this.txtDspid.Size = new System.Drawing.Size(26, 20);
            this.txtDspid.TabIndex = 133;
            this.txtDspid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(251, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 26);
            this.label8.TabIndex = 132;
            this.label8.Text = "On Save, this will overwrite \r\nthe \"Stock Level\" data";
            this.label8.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 131;
            this.label22.Text = "Item Code";
            this.label22.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(124, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 20);
            this.txtCode.TabIndex = 107;
            this.txtCode.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(12, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(252, 20);
            this.label21.TabIndex = 132;
            this.label21.Text = "Search Drug by Name or Code";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "SearchItemText", true));
            this.txtSearch.Location = new System.Drawing.Point(12, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(667, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSearchedItem);
            this.panel3.Controls.Add(this.btnSelectItem);
            this.panel3.Location = new System.Drawing.Point(12, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 123);
            this.panel3.TabIndex = 135;
            this.panel3.Visible = false;
            // 
            // dgvSearchedItem
            // 
            this.dgvSearchedItem.AllowUserToAddRows = false;
            this.dgvSearchedItem.AllowUserToDeleteRows = false;
            this.dgvSearchedItem.AutoGenerateColumns = false;
            this.dgvSearchedItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSearchedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchedItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.expireDataGridViewTextBoxColumn});
            this.dgvSearchedItem.DataSource = this.bsSearchedItems;
            this.dgvSearchedItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSearchedItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSearchedItem.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchedItem.MultiSelect = false;
            this.dgvSearchedItem.Name = "dgvSearchedItem";
            this.dgvSearchedItem.ReadOnly = true;
            this.dgvSearchedItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchedItem.Size = new System.Drawing.Size(749, 91);
            this.dgvSearchedItem.TabIndex = 111;
            // 
            // bsSearchedItems
            // 
            this.bsSearchedItems.AllowNew = false;
            this.bsSearchedItems.DataMember = "SearchItemResult";
            this.bsSearchedItems.DataSource = this.bsForm;
            this.bsSearchedItems.CurrentChanged += new System.EventHandler(this.bsItem_CurrentChanged);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectItem.Enabled = false;
            this.btnSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.Location = new System.Drawing.Point(663, 97);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(83, 23);
            this.btnSelectItem.TabIndex = 112;
            this.btnSelectItem.Text = "Select";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtUserAmend
            // 
            this.txtUserAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAmend.Location = new System.Drawing.Point(619, 17);
            this.txtUserAmend.Name = "txtUserAmend";
            this.txtUserAmend.Size = new System.Drawing.Size(47, 20);
            this.txtUserAmend.TabIndex = 137;
            this.txtUserAmend.Visible = false;
            // 
            // txtDateAmend
            // 
            this.txtDateAmend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateAmend.Location = new System.Drawing.Point(672, 17);
            this.txtDateAmend.Name = "txtDateAmend";
            this.txtDateAmend.Size = new System.Drawing.Size(46, 20);
            this.txtDateAmend.TabIndex = 136;
            this.txtDateAmend.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label21);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserAmend);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.txtDateAmend);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(gbCart);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 636);
            this.splitContainer1.SplitterDistance = 764;
            this.splitContainer1.TabIndex = 138;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Identifier";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identifier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AlternativeName";
            this.dataGridViewTextBoxColumn5.HeaderText = "AlternativeName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MajorSupplier";
            this.dataGridViewTextBoxColumn7.HeaderText = "MajorSupplier";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 96;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PackQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "PackQuantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 96;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PackDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "PackDescription";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 110;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AlternativeItem";
            this.dataGridViewTextBoxColumn10.HeaderText = "AlternativeItem";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StandardIssueQuantity";
            this.dataGridViewTextBoxColumn11.HeaderText = "StandardIssueQuantity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 139;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EconomicOrderQuantity";
            this.dataGridViewTextBoxColumn12.HeaderText = "EconomicOrderQuantity";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 144;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn13.HeaderText = "PurchasePrice";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MarkupPercent";
            this.dataGridViewTextBoxColumn14.HeaderText = "MarkupPercent";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 105;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SellingPrice";
            this.dataGridViewTextBoxColumn15.HeaderText = "SellingPrice";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 87;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "StockLevel";
            this.dataGridViewTextBoxColumn16.HeaderText = "StockLevel";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 86;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MinimumLevel";
            this.dataGridViewTextBoxColumn17.HeaderText = "MinimumLevel";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 99;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ReOrderLevel";
            this.dataGridViewTextBoxColumn18.HeaderText = "ReOrderLevel";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 98;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "MaximumLevel";
            this.dataGridViewTextBoxColumn19.HeaderText = "MaximumLevel";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 102;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "LeadDays";
            this.dataGridViewTextBoxColumn20.HeaderText = "LeadDays";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 80;
            // 
            // expireDataGridViewTextBoxColumn
            // 
            this.expireDataGridViewTextBoxColumn.DataPropertyName = "Expire";
            this.expireDataGridViewTextBoxColumn.HeaderText = "Expire";
            this.expireDataGridViewTextBoxColumn.Name = "expireDataGridViewTextBoxColumn";
            this.expireDataGridViewTextBoxColumn.ReadOnly = true;
            this.expireDataGridViewTextBoxColumn.Width = 61;
            // 
            // bsForm
            // 
            this.bsForm.DataSource = typeof(SmartInventorySystem.ViewModel.Forms.DispenseItemFormViewModel);
            // 
            // DispenseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 636);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DispenseItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dispense";
            this.Load += new System.EventHandler(this.frmDispense_Load);
            gbCart.ResumeLayout(false);
            gbCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCart)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearchedItems)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDispenseQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSearchedItem;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.TextBox txtUserAmend;
        private System.Windows.Forms.TextBox txtDateAmend;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDspid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgroupDate;
        private System.Windows.Forms.TextBox txtdispStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnComputeTotal;
        private System.Windows.Forms.BindingSource bsSearchedItems;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRemoveItemCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.BindingSource bsCart;
        private DispenseCartDataSet dsCart;
        private System.Windows.Forms.BindingSource bsForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDataGridViewTextBoxColumn;
    }
}