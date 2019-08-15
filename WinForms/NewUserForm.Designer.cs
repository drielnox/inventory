namespace SmartInventorySystem.WinForms
{
    partial class frmNewUser
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.ComboBox();
            this.txtUserCreated = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Staff ID";
            this.label5.Visible = false;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffID.Location = new System.Drawing.Point(99, 60);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(185, 20);
            this.txtStaffID.TabIndex = 20;
            this.txtStaffID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(99, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(99, 139);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Location = new System.Drawing.Point(99, 113);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(185, 20);
            this.txtLName.TabIndex = 22;
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Location = new System.Drawing.Point(99, 87);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(185, 20);
            this.txtFName.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(124, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 78;
            this.label12.Text = "ADD NEW USER";
            // 
            // txtProfile
            // 
            this.txtProfile.FormattingEnabled = true;
            this.txtProfile.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.txtProfile.Location = new System.Drawing.Point(99, 191);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(185, 21);
            this.txtProfile.TabIndex = 25;
            // 
            // txtUserCreated
            // 
            this.txtUserCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserCreated.Location = new System.Drawing.Point(128, 314);
            this.txtUserCreated.Name = "txtUserCreated";
            this.txtUserCreated.Size = new System.Drawing.Size(75, 20);
            this.txtUserCreated.TabIndex = 82;
            this.txtUserCreated.Visible = false;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateCreated.Location = new System.Drawing.Point(209, 314);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(75, 20);
            this.txtDateCreated.TabIndex = 81;
            this.txtDateCreated.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(99, 245);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 20);
            this.txtPhone.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(99, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 348);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserCreated);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNewUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New User";
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtProfile;
        private System.Windows.Forms.TextBox txtUserCreated;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
    }
}