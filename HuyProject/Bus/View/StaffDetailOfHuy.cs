using Bus.BLL;
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
    public partial class StaffDetailOfHuy : Form
    {
        public StaffDTO main_staff_dto { get; set; }
        BusBLL bll;
        public StaffDetailOfHuy()
        {
            InitializeComponent();
            bll = new BusBLL();
        }
        public StaffDetailOfHuy(StaffDTO dto)
        {
            InitializeComponent();
            bll = new BusBLL();
            main_staff_dto = dto;
        }
        public void LoadData()
        {
            txtStaffMSNV.Text = main_staff_dto.MSNV;
            txtStaffName.Text = main_staff_dto.Name;
            txtPhone.Text = main_staff_dto.Phone;
            txtRole.Text = bll.GetRoleNameById(main_staff_dto.RoleID);
            txtPhone.Text = main_staff_dto.Phone;
            txtCMND.Text = main_staff_dto.CMND;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
