using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus.View
{
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            gvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvStaff.Columns[0].Name = "Mã Số Nhân Viên";
            gvStaff.Columns[1].Name = "Name";
            gvStaff.Columns[2].Name = "Chức Vụ ";
            gvStaff.Columns[3].Name = "Date Of Birth";
            gvStaff.Columns[4].Name = "Phone Number";
            gvStaff.Columns[5].Name = "Trạng Thái";
        }
    }
}
