using Bus.BLL;
using Bus.DAO;
using Bus.DTO;
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
        StaffBLL bll;
        public StaffView()
        {
            InitializeComponent();
            bll = new StaffBLL();
            LoadView();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            gvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadView()
        {
            gvStaff.DataSource = bll.getAll();
        }

        private void btnStaffNew_Click(object sender, EventArgs e)
        {
            txtStaffMSNV.Text = null;
            txtStaffCMND.Text = null;
            txtStaffName.Text = null;
            txtStaffPhone.Text = null;
        }
    }
}
