﻿namespace Bus.View
{
    partial class StaffView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gvStaff = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.Label();
            this.Comfrimpassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffCMND = new System.Windows.Forms.MaskedTextBox();
            this.txtStaffPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtStaffMSNV = new System.Windows.Forms.MaskedTextBox();
            this.ErrorCmnd = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorDate = new System.Windows.Forms.Label();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorMSNV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStaffNew = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.cbStaffRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStaffDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvStaff);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.Panel);
            this.splitContainer1.Panel2.Controls.Add(this.txtStaffCMND);
            this.splitContainer1.Panel2.Controls.Add(this.txtStaffPhone);
            this.splitContainer1.Panel2.Controls.Add(this.txtStaffMSNV);
            this.splitContainer1.Panel2.Controls.Add(this.ErrorCmnd);
            this.splitContainer1.Panel2.Controls.Add(this.ErrorPhone);
            this.splitContainer1.Panel2.Controls.Add(this.ErrorDate);
            this.splitContainer1.Panel2.Controls.Add(this.ErrorName);
            this.splitContainer1.Panel2.Controls.Add(this.ErrorMSNV);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnStaffNew);
            this.splitContainer1.Panel2.Controls.Add(this.btnStaffDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnStaffUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnStaffAdd);
            this.splitContainer1.Panel2.Controls.Add(this.cbStaffRole);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.dtpStaffDateOfBirth);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtStaffName);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 529);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 0;
            // 
            // gvStaff
            // 
            this.gvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStaff.Location = new System.Drawing.Point(0, 0);
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.Size = new System.Drawing.Size(436, 529);
            this.gvStaff.TabIndex = 0;
            this.gvStaff.Click += new System.EventHandler(this.gvStaff_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Search Staff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.txtError);
            this.Panel.Controls.Add(this.Comfrimpassword);
            this.Panel.Controls.Add(this.txtPassword);
            this.Panel.Controls.Add(this.label9);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(416, 227);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(323, 187);
            this.Panel.TabIndex = 48;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Location = new System.Drawing.Point(101, 149);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 13);
            this.txtError.TabIndex = 4;
            // 
            // Comfrimpassword
            // 
            this.Comfrimpassword.Location = new System.Drawing.Point(132, 106);
            this.Comfrimpassword.Name = "Comfrimpassword";
            this.Comfrimpassword.PasswordChar = '*';
            this.Comfrimpassword.Size = new System.Drawing.Size(174, 20);
            this.Comfrimpassword.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Comfirm Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password :";
            // 
            // txtStaffCMND
            // 
            this.txtStaffCMND.Location = new System.Drawing.Point(113, 355);
            this.txtStaffCMND.Mask = "00000000";
            this.txtStaffCMND.Name = "txtStaffCMND";
            this.txtStaffCMND.Size = new System.Drawing.Size(228, 20);
            this.txtStaffCMND.TabIndex = 47;
            this.txtStaffCMND.ValidatingType = typeof(int);
            this.txtStaffCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffCMND_KeyPress_1);
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(113, 304);
            this.txtStaffPhone.Mask = "(999) 000-0000";
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(228, 20);
            this.txtStaffPhone.TabIndex = 46;
            // 
            // txtStaffMSNV
            // 
            this.txtStaffMSNV.Location = new System.Drawing.Point(113, 88);
            this.txtStaffMSNV.Mask = "ST0000";
            this.txtStaffMSNV.Name = "txtStaffMSNV";
            this.txtStaffMSNV.ReadOnly = true;
            this.txtStaffMSNV.Size = new System.Drawing.Size(228, 20);
            this.txtStaffMSNV.TabIndex = 45;
            // 
            // ErrorCmnd
            // 
            this.ErrorCmnd.AutoSize = true;
            this.ErrorCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCmnd.Location = new System.Drawing.Point(365, 358);
            this.ErrorCmnd.Name = "ErrorCmnd";
            this.ErrorCmnd.Size = new System.Drawing.Size(0, 16);
            this.ErrorCmnd.TabIndex = 44;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.Location = new System.Drawing.Point(365, 305);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(0, 16);
            this.ErrorPhone.TabIndex = 43;
            // 
            // ErrorDate
            // 
            this.ErrorDate.AutoSize = true;
            this.ErrorDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDate.Location = new System.Drawing.Point(365, 207);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new System.Drawing.Size(0, 16);
            this.ErrorDate.TabIndex = 42;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.Location = new System.Drawing.Point(365, 148);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(0, 16);
            this.ErrorName.TabIndex = 41;
            // 
            // ErrorMSNV
            // 
            this.ErrorMSNV.AutoSize = true;
            this.ErrorMSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMSNV.Location = new System.Drawing.Point(365, 93);
            this.ErrorMSNV.Name = "ErrorMSNV";
            this.ErrorMSNV.Size = new System.Drawing.Size(0, 16);
            this.ErrorMSNV.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "STAFF MANAGER";
            // 
            // btnStaffNew
            // 
            this.btnStaffNew.Location = new System.Drawing.Point(52, 463);
            this.btnStaffNew.Name = "btnStaffNew";
            this.btnStaffNew.Size = new System.Drawing.Size(75, 27);
            this.btnStaffNew.TabIndex = 38;
            this.btnStaffNew.Text = "New";
            this.btnStaffNew.UseVisualStyleBackColor = true;
            this.btnStaffNew.Click += new System.EventHandler(this.btnStaffNew_Click_1);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Location = new System.Drawing.Point(416, 463);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 27);
            this.btnStaffDelete.TabIndex = 37;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click_1);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.Location = new System.Drawing.Point(290, 463);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnStaffUpdate.TabIndex = 36;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = true;
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click_1);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(169, 463);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 27);
            this.btnStaffAdd.TabIndex = 35;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // cbStaffRole
            // 
            this.cbStaffRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffRole.FormattingEnabled = true;
            this.cbStaffRole.Location = new System.Drawing.Point(113, 258);
            this.cbStaffRole.Name = "cbStaffRole";
            this.cbStaffRole.Size = new System.Drawing.Size(228, 21);
            this.cbStaffRole.TabIndex = 34;
            this.cbStaffRole.SelectedIndexChanged += new System.EventHandler(this.cbStaffRole_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Role";
            // 
            // dtpStaffDateOfBirth
            // 
            this.dtpStaffDateOfBirth.CustomFormat = "yyyy-MM-dd ";
            this.dtpStaffDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStaffDateOfBirth.Location = new System.Drawing.Point(113, 206);
            this.dtpStaffDateOfBirth.Name = "dtpStaffDateOfBirth";
            this.dtpStaffDateOfBirth.Size = new System.Drawing.Size(228, 20);
            this.dtpStaffDateOfBirth.TabIndex = 32;
            this.dtpStaffDateOfBirth.Value = new System.DateTime(2000, 2, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date Of Birth";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(113, 147);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(228, 20);
            this.txtStaffName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "MSNV";
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StaffView";
            this.Text = "StaffView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvStaff;
        private System.Windows.Forms.MaskedTextBox txtStaffCMND;
        private System.Windows.Forms.MaskedTextBox txtStaffPhone;
        private System.Windows.Forms.MaskedTextBox txtStaffMSNV;
        private System.Windows.Forms.Label ErrorCmnd;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorDate;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorMSNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStaffNew;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.ComboBox cbStaffRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStaffDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Comfrimpassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button button1;
    }
}