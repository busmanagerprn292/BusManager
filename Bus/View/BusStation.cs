using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TblView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TblView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TblView.Columns[0].Name = "BXS";
            TblView.Columns[1].Name = "Tài Xế ";
            TblView.Columns[2].Name = "Phụ Xe";
            TblView.Columns[3].Name = "Giờ ra Trạm";
            TblView.Columns[4].Name = "Giờ về Trạm";
            TblView.Columns[5].Name = "Trạng Thái";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
