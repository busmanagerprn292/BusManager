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
            TblView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TblView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TblView.Columns[0].Name = "Mã Số Nhân Viên";
            TblView.Columns[1].Name = "Name";
            TblView.Columns[2].Name = "Chức Vụ ";
            TblView.Columns[3].Name = "Date Of Birth";
            TblView.Columns[4].Name = "Phone Number";
            TblView.Columns[5].Name = "Trạng Thái";
        }

        private void TblView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void New_Click(object sender, EventArgs e)
        {
            var a = "true";
        }
    }
}
