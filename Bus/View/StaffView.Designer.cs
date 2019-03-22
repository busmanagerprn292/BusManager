namespace Bus.View
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Manager";
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvStaff);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 525);
            this.splitContainer1.SplitterDistance = 459;
            this.splitContainer1.TabIndex = 0;
            // 
            // gvStaff
            // 
            this.gvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStaff.Location = new System.Drawing.Point(0, 0);
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.Size = new System.Drawing.Size(459, 525);
            this.gvStaff.TabIndex = 1;
            this.gvStaff.Click += new System.EventHandler(this.gvStaff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStaffCMND);
            this.panel1.Controls.Add(this.txtStaffPhone);
            this.panel1.Controls.Add(this.txtStaffMSNV);
            this.panel1.Controls.Add(this.ErrorCmnd);
            this.panel1.Controls.Add(this.ErrorPhone);
            this.panel1.Controls.Add(this.ErrorDate);
            this.panel1.Controls.Add(this.ErrorName);
            this.panel1.Controls.Add(this.ErrorMSNV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnStaffNew);
            this.panel1.Controls.Add(this.btnStaffDelete);
            this.panel1.Controls.Add(this.btnStaffUpdate);
            this.panel1.Controls.Add(this.btnStaffAdd);
            this.panel1.Controls.Add(this.cbStaffRole);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpStaffDateOfBirth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 525);
            this.panel1.TabIndex = 2;
            // 
            // txtStaffCMND
            // 
            this.txtStaffCMND.Location = new System.Drawing.Point(126, 359);
            this.txtStaffCMND.Mask = "00000000";
            this.txtStaffCMND.Name = "txtStaffCMND";
            this.txtStaffCMND.Size = new System.Drawing.Size(228, 20);
            this.txtStaffCMND.TabIndex = 25;
            this.txtStaffCMND.ValidatingType = typeof(int);
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(126, 308);
            this.txtStaffPhone.Mask = "(999) 000-0000";
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(228, 20);
            this.txtStaffPhone.TabIndex = 24;
            // 
            // txtStaffMSNV
            // 
            this.txtStaffMSNV.Location = new System.Drawing.Point(126, 92);
            this.txtStaffMSNV.Mask = "ST0000";
            this.txtStaffMSNV.Name = "txtStaffMSNV";
            this.txtStaffMSNV.ReadOnly = true;
            this.txtStaffMSNV.Size = new System.Drawing.Size(228, 20);
            this.txtStaffMSNV.TabIndex = 23;
            // 
            // ErrorCmnd
            // 
            this.ErrorCmnd.AutoSize = true;
            this.ErrorCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorCmnd.Location = new System.Drawing.Point(408, 365);
            this.ErrorCmnd.Name = "ErrorCmnd";
            this.ErrorCmnd.Size = new System.Drawing.Size(0, 16);
            this.ErrorCmnd.TabIndex = 22;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.Location = new System.Drawing.Point(408, 312);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(0, 16);
            this.ErrorPhone.TabIndex = 21;
            // 
            // ErrorDate
            // 
            this.ErrorDate.AutoSize = true;
            this.ErrorDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDate.Location = new System.Drawing.Point(426, 214);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new System.Drawing.Size(0, 16);
            this.ErrorDate.TabIndex = 19;
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorName.Location = new System.Drawing.Point(426, 155);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(0, 16);
            this.ErrorName.TabIndex = 18;
            // 
            // ErrorMSNV
            // 
            this.ErrorMSNV.AutoSize = true;
            this.ErrorMSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMSNV.Location = new System.Drawing.Point(426, 100);
            this.ErrorMSNV.Name = "ErrorMSNV";
            this.ErrorMSNV.Size = new System.Drawing.Size(0, 16);
            this.ErrorMSNV.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "STAFF MANAGER";
            // 
            // btnStaffNew
            // 
            this.btnStaffNew.Location = new System.Drawing.Point(65, 467);
            this.btnStaffNew.Name = "btnStaffNew";
            this.btnStaffNew.Size = new System.Drawing.Size(75, 27);
            this.btnStaffNew.TabIndex = 15;
            this.btnStaffNew.Text = "New";
            this.btnStaffNew.UseVisualStyleBackColor = true;
            this.btnStaffNew.Click += new System.EventHandler(this.btnStaffNew_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Location = new System.Drawing.Point(429, 467);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 27);
            this.btnStaffDelete.TabIndex = 14;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.Location = new System.Drawing.Point(303, 467);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnStaffUpdate.TabIndex = 13;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = true;
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(182, 467);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 27);
            this.btnStaffAdd.TabIndex = 12;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // cbStaffRole
            // 
            this.cbStaffRole.FormattingEnabled = true;
            this.cbStaffRole.Location = new System.Drawing.Point(126, 262);
            this.cbStaffRole.Name = "cbStaffRole";
            this.cbStaffRole.Size = new System.Drawing.Size(228, 21);
            this.cbStaffRole.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Role";
            // 
            // dtpStaffDateOfBirth
            // 
            this.dtpStaffDateOfBirth.CustomFormat = "yyyy-MM-dd ";
            this.dtpStaffDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStaffDateOfBirth.Location = new System.Drawing.Point(126, 210);
            this.dtpStaffDateOfBirth.Name = "dtpStaffDateOfBirth";
            this.dtpStaffDateOfBirth.Size = new System.Drawing.Size(228, 20);
            this.dtpStaffDateOfBirth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date Of Birth";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(126, 151);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(228, 20);
            this.txtStaffName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSNV";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 561);
            this.tabControl1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "StaffView";
            this.Text = "StaffView";
            this.Load += new System.EventHandler(this.StaffView_Load);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvStaff;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ErrorCmnd;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorDate;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorMSNV;
        private System.Windows.Forms.MaskedTextBox txtStaffMSNV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox txtStaffPhone;
        private System.Windows.Forms.MaskedTextBox txtStaffCMND;
    }
}