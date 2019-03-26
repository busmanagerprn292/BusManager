namespace Bus.View
{
    partial class ScheduleDetailOfBus
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
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpTimeBack = new System.Windows.Forms.DateTimePicker();
            this.dtpDepatureTime = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listCasher = new System.Windows.Forms.ListBox();
            this.listDriver = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.lbTuyenDuong = new System.Windows.Forms.Label();
            this.lbBSX = new System.Windows.Forms.Label();
            this.lbBusId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvSchedule);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 505);
            this.splitContainer1.SplitterDistance = 617;
            this.splitContainer1.TabIndex = 12;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(617, 505);
            this.dgvSchedule.TabIndex = 12;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dtpTimeBack);
            this.groupBox1.Controls.Add(this.dtpDepatureTime);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.listCasher);
            this.groupBox1.Controls.Add(this.listDriver);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lbTuyenDuong);
            this.groupBox1.Controls.Add(this.lbBSX);
            this.groupBox1.Controls.Add(this.lbBusId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduling";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(195, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpTimeBack
            // 
            this.dtpTimeBack.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeBack.Location = new System.Drawing.Point(180, 255);
            this.dtpTimeBack.Name = "dtpTimeBack";
            this.dtpTimeBack.Size = new System.Drawing.Size(123, 26);
            this.dtpTimeBack.TabIndex = 27;
            // 
            // dtpDepatureTime
            // 
            this.dtpDepatureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepatureTime.Location = new System.Drawing.Point(180, 204);
            this.dtpDepatureTime.Name = "dtpDepatureTime";
            this.dtpDepatureTime.Size = new System.Drawing.Size(123, 26);
            this.dtpDepatureTime.TabIndex = 26;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(70, 436);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 31);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(70, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listCasher
            // 
            this.listCasher.FormattingEnabled = true;
            this.listCasher.ItemHeight = 20;
            this.listCasher.Location = new System.Drawing.Point(335, 296);
            this.listCasher.Name = "listCasher";
            this.listCasher.Size = new System.Drawing.Size(130, 184);
            this.listCasher.TabIndex = 21;
            this.listCasher.Click += new System.EventHandler(this.listCasher_Click);
            // 
            // listDriver
            // 
            this.listDriver.FormattingEnabled = true;
            this.listDriver.ItemHeight = 20;
            this.listDriver.Location = new System.Drawing.Point(335, 78);
            this.listDriver.Name = "listDriver";
            this.listDriver.Size = new System.Drawing.Size(130, 164);
            this.listDriver.TabIndex = 20;
            this.listDriver.Click += new System.EventHandler(this.listDriver_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(70, 336);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 31);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lbTuyenDuong
            // 
            this.lbTuyenDuong.AutoSize = true;
            this.lbTuyenDuong.Location = new System.Drawing.Point(195, 151);
            this.lbTuyenDuong.Name = "lbTuyenDuong";
            this.lbTuyenDuong.Size = new System.Drawing.Size(60, 20);
            this.lbTuyenDuong.TabIndex = 18;
            this.lbTuyenDuong.Text = "label10";
            // 
            // lbBSX
            // 
            this.lbBSX.AutoSize = true;
            this.lbBSX.Location = new System.Drawing.Point(191, 98);
            this.lbBSX.Name = "lbBSX";
            this.lbBSX.Size = new System.Drawing.Size(51, 20);
            this.lbBSX.TabIndex = 17;
            this.lbBSX.Text = "label9";
            // 
            // lbBusId
            // 
            this.lbBusId.AutoSize = true;
            this.lbBusId.Location = new System.Drawing.Point(191, 51);
            this.lbBusId.Name = "lbBusId";
            this.lbBusId.Size = new System.Drawing.Size(51, 20);
            this.lbBusId.TabIndex = 16;
            this.lbBusId.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time Back";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departure Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Casher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Go to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bản số xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bus ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ScheduleDetailOfBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 505);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ScheduleDetailOfBus";
            this.Text = "ScheduleDetailOfBus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleDetailOfBus_FormClosing);
            this.Load += new System.EventHandler(this.ScheduleDetailOfBus_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listDriver;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbTuyenDuong;
        private System.Windows.Forms.Label lbBSX;
        private System.Windows.Forms.Label lbBusId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimeBack;
        private System.Windows.Forms.DateTimePicker dtpDepatureTime;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listCasher;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnExit;
    }
}