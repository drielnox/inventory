namespace SmartInventorySystem.WinForms
{
    partial class NewItemForm
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
            this.bsForm = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlterName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManuf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMajSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIssQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlterItem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEOQ = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "Name", true));
            this.txtItemName.Location = new System.Drawing.Point(97, 123);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 20);
            this.txtItemName.TabIndex = 22;
            // 
            // bsForm
            // 
            this.bsForm.DataSource = typeof(SmartInventorySystem.ViewModel.Forms.NewItemFormViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item Description";
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "Description", true));
            this.txtDesc.Location = new System.Drawing.Point(329, 155);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 58);
            this.txtDesc.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alternative Name";
            // 
            // txtAlterName
            // 
            this.txtAlterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlterName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "AlternativeName", true));
            this.txtAlterName.Location = new System.Drawing.Point(97, 159);
            this.txtAlterName.Name = "txtAlterName";
            this.txtAlterName.Size = new System.Drawing.Size(185, 20);
            this.txtAlterName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Manufacturer";
            // 
            // txtManuf
            // 
            this.txtManuf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManuf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "Manufacturer", true));
            this.txtManuf.Location = new System.Drawing.Point(97, 195);
            this.txtManuf.Name = "txtManuf";
            this.txtManuf.Size = new System.Drawing.Size(185, 20);
            this.txtManuf.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Major Supplier";
            // 
            // txtMajSupplier
            // 
            this.txtMajSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajSupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "MajorSupplier", true));
            this.txtMajSupplier.Location = new System.Drawing.Point(97, 232);
            this.txtMajSupplier.Name = "txtMajSupplier";
            this.txtMajSupplier.Size = new System.Drawing.Size(185, 20);
            this.txtMajSupplier.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Pack Size";
            // 
            // txtPackSize
            // 
            this.txtPackSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "PackSize", true));
            this.txtPackSize.Location = new System.Drawing.Point(97, 267);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(185, 20);
            this.txtPackSize.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Pack Description";
            // 
            // txtPackDesc
            // 
            this.txtPackDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "PackDescription", true));
            this.txtPackDesc.Location = new System.Drawing.Point(97, 302);
            this.txtPackDesc.Name = "txtPackDesc";
            this.txtPackDesc.Size = new System.Drawing.Size(185, 20);
            this.txtPackDesc.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Standard Issue Quantity";
            // 
            // txtIssQuantity
            // 
            this.txtIssQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIssQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "StandardIssueQuantity", true));
            this.txtIssQuantity.Location = new System.Drawing.Point(444, 234);
            this.txtIssQuantity.Name = "txtIssQuantity";
            this.txtIssQuantity.Size = new System.Drawing.Size(70, 20);
            this.txtIssQuantity.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alternative Item";
            // 
            // txtAlterItem
            // 
            this.txtAlterItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlterItem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "AlternativeItem", true));
            this.txtAlterItem.Location = new System.Drawing.Point(412, 271);
            this.txtAlterItem.Name = "txtAlterItem";
            this.txtAlterItem.Size = new System.Drawing.Size(102, 20);
            this.txtAlterItem.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Economic Order Quantity";
            // 
            // txtEOQ
            // 
            this.txtEOQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEOQ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "EconomicOrderQuantity", true));
            this.txtEOQ.Location = new System.Drawing.Point(444, 306);
            this.txtEOQ.Name = "txtEOQ";
            this.txtEOQ.Size = new System.Drawing.Size(70, 20);
            this.txtEOQ.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(351, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(227, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "ADD NEW ITEM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Item Code";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsForm, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(97, 89);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 20);
            this.txtCode.TabIndex = 13;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 401);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEOQ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAlterItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIssQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPackDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPackSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMajSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewItemForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Item";
            this.Load += new System.EventHandler(this.frmNew_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManuf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMajSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIssQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAlterItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEOQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.BindingSource bsForm;
    }
}

