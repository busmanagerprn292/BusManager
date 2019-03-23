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
    public partial class OwnerDetailOfBus : Form
    {
        public OwnerDTO dto{ get; set; }
        private OwnerBLL bll;
        public OwnerDetailOfBus()
        {
            InitializeComponent();
        }
        public OwnerDetailOfBus(OwnerDTO dto)
        {
            InitializeComponent();
            bll = new OwnerBLL();
            txtId.ReadOnly = true;
            this.dto = dto;
            LoadData();
        }
        private void LoadData()
        {
            txtId.Text = dto.Id;
            txtCMND.Text = dto.CMND;
            txtAddress.Text = dto.Address;
            txtName.Text = dto.Name;
            txtPhone.Text = dto.Phone;
            dtpDateOfBirth.Value = dto.DateOfBirth;
        }
        public bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (String.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Không được để trống");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider2.SetError(txtName, "Không được để trống");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length != 10)
            {
                errorProvider3.SetError(txtPhone, "Không được để trống và độ dài là 10");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtCMND.Text) || txtCMND.Text.Length != 9)
            {
                errorProvider4.SetError(txtCMND, "Không được để trống và độ dài là 9");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider5.SetError(txtAddress, "Không được để trống");
                check = false;
            }
            if(DateTime.Compare(dtpDateOfBirth.Value,DateTime.Now) > 0)
            {
                errorProvider6.SetError(dtpDateOfBirth, "Date does not gather than current date");
                check = false;
            }
            return check;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly)
            {
                if (KiemTraDuLieu())
                {
                    string id = txtId.Text;
                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    DateTime dob = DateTime.Parse(dtpDateOfBirth.Value.ToShortDateString());
                    string cmnd = txtCMND.Text;
                    string address = txtAddress.Text;
                    try
                    {
                        bll.UpdateOwner(id, name, phone, dob, cmnd, address);
                        dto.Name = name;
                        dto.Phone = phone;
                        dto.DateOfBirth = dob;
                        dto.CMND = cmnd;
                        dto.Address = address;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please chosse to update Owner");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
