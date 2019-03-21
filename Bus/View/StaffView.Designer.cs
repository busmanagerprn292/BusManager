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
            this.label1 = new System.Windows.Forms.Label();
            this.gvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStaffImage = new System.Windows.Forms.Label();
            this.btnStaffNew = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.cbStaffRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStaffDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffCMND = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffMSNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tblViewBus = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBusID = new System.Windows.Forms.TextBox();
            this.txtBSX = new System.Windows.Forms.TextBox();
            this.txtTimeGo = new System.Windows.Forms.TextBox();
            this.txtTimeBack = new System.Windows.Forms.TextBox();
            this.cbCasher = new System.Windows.Forms.ComboBox();
            this.cbDriver = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBus)).BeginInit();
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
            // gvStaff
            // 
            this.gvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStaff.Location = new System.Drawing.Point(0, 0);
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.Size = new System.Drawing.Size(459, 525);
            this.gvStaff.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbStaffImage);
            this.panel1.Controls.Add(this.btnStaffNew);
            this.panel1.Controls.Add(this.btnStaffDelete);
            this.panel1.Controls.Add(this.btnStaffUpdate);
            this.panel1.Controls.Add(this.btnStaffAdd);
            this.panel1.Controls.Add(this.cbStaffRole);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpStaffDateOfBirth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStaffPhone);
            this.panel1.Controls.Add(this.txtStaffCMND);
            this.panel1.Controls.Add(this.txtStaffName);
            this.panel1.Controls.Add(this.txtStaffMSNV);
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
            // lbStaffImage
            // 
            this.lbStaffImage.AutoSize = true;
            this.lbStaffImage.Location = new System.Drawing.Point(445, 96);
            this.lbStaffImage.MinimumSize = new System.Drawing.Size(150, 150);
            this.lbStaffImage.Name = "lbStaffImage";
            this.lbStaffImage.Size = new System.Drawing.Size(150, 150);
            this.lbStaffImage.TabIndex = 16;
            this.lbStaffImage.Text = "label8";
            // 
            // btnStaffNew
            // 
            this.btnStaffNew.Location = new System.Drawing.Point(65, 467);
            this.btnStaffNew.Name = "btnStaffNew";
            this.btnStaffNew.Size = new System.Drawing.Size(75, 27);
            this.btnStaffNew.TabIndex = 15;
            this.btnStaffNew.Text = "New";
            this.btnStaffNew.UseVisualStyleBackColor = true;
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Location = new System.Drawing.Point(429, 467);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 27);
            this.btnStaffDelete.TabIndex = 14;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.Location = new System.Drawing.Point(303, 467);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnStaffUpdate.TabIndex = 13;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = true;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(182, 467);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 27);
            this.btnStaffAdd.TabIndex = 12;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
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
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(126, 308);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(228, 20);
            this.txtStaffPhone.TabIndex = 7;
            // 
            // txtStaffCMND
            // 
            this.txtStaffCMND.Location = new System.Drawing.Point(126, 361);
            this.txtStaffCMND.Name = "txtStaffCMND";
            this.txtStaffCMND.Size = new System.Drawing.Size(228, 20);
            this.txtStaffCMND.TabIndex = 6;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(126, 151);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(228, 20);
            this.txtStaffName.TabIndex = 5;
            // 
            // txtStaffMSNV
            // 
            this.txtStaffMSNV.Location = new System.Drawing.Point(126, 96);
            this.txtStaffMSNV.Name = "txtStaffMSNV";
            this.txtStaffMSNV.Size = new System.Drawing.Size(228, 20);
            this.txtStaffMSNV.TabIndex = 4;
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 561);
            this.tabControl1.TabIndex = 3;
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
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer2.Size = new System.Drawing.Size(1055, 525);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1065, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Owner";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1065, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Route";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage5.Controls.Add(this.cbDriver);
            this.tabPage5.Controls.Add(this.cbCasher);
            this.tabPage5.Controls.Add(this.txtTimeBack);
            this.tabPage5.Controls.Add(this.txtTimeGo);
            this.tabPage5.Controls.Add(this.txtBSX);
            this.tabPage5.Controls.Add(this.txtBusID);
            this.tabPage5.Controls.Add(this.tblViewBus);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1065, 535);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Scheduling";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tblViewBus
            // 
            this.tblViewBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewBus.Location = new System.Drawing.Point(1, 262);
            this.tblViewBus.Name = "tblViewBus";
            this.tblViewBus.Size = new System.Drawing.Size(1171, 266);
            this.tblViewBus.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1001, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Driver :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Casher :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(458, 17);
            this.label11.MinimumSize = new System.Drawing.Size(350, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 50);
            this.label11.TabIndex = 12;
            this.label11.Text = "QUẢN LÝ BẾN XE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "BSX :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Thời gian về bến :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Thời gian khởi hành";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "BUS ID :";
            // 
            // txtBusID
            // 
            this.txtBusID.Location = new System.Drawing.Point(328, 75);
            this.txtBusID.Name = "txtBusID";
            this.txtBusID.Size = new System.Drawing.Size(214, 20);
            this.txtBusID.TabIndex = 17;
            // 
            // txtBSX
            // 
            this.txtBSX.Location = new System.Drawing.Point(328, 117);
            this.txtBSX.Name = "txtBSX";
            this.txtBSX.Size = new System.Drawing.Size(214, 20);
            this.txtBSX.TabIndex = 18;
            // 
            // txtTimeGo
            // 
            this.txtTimeGo.Location = new System.Drawing.Point(328, 161);
            this.txtTimeGo.Name = "txtTimeGo";
            this.txtTimeGo.Size = new System.Drawing.Size(214, 20);
            this.txtTimeGo.TabIndex = 19;
            // 
            // txtTimeBack
            // 
            this.txtTimeBack.Location = new System.Drawing.Point(328, 203);
            this.txtTimeBack.Name = "txtTimeBack";
            this.txtTimeBack.Size = new System.Drawing.Size(214, 20);
            this.txtTimeBack.TabIndex = 20;
            // 
            // cbCasher
            // 
            this.cbCasher.FormattingEnabled = true;
            this.cbCasher.Location = new System.Drawing.Point(737, 67);
            this.cbCasher.Name = "cbCasher";
            this.cbCasher.Size = new System.Drawing.Size(215, 21);
            this.cbCasher.TabIndex = 21;
            // 
            // cbDriver
            // 
            this.cbDriver.Location = new System.Drawing.Point(737, 112);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(215, 20);
            this.cbDriver.TabIndex = 22;
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
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffCMND;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffMSNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStaffDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStaffRole;
        private System.Windows.Forms.Button btnStaffNew;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Label lbStaffImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tblViewBus;
        private System.Windows.Forms.TextBox cbDriver;
        private System.Windows.Forms.ComboBox cbCasher;
        private System.Windows.Forms.TextBox txtTimeBack;
        private System.Windows.Forms.TextBox txtTimeGo;
        private System.Windows.Forms.TextBox txtBSX;
        private System.Windows.Forms.TextBox txtBusID;
    }
}