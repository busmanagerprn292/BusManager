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
    public partial class BusViewToAddForOwner : Form
    {
        OwnerDTO main_owner_dto;
        private BusBLL main_bus_bll;
        public BusViewToAddForOwner()
        {
            InitializeComponent();
        }
        public BusViewToAddForOwner(OwnerDTO dto)
        {
            InitializeComponent();
            main_owner_dto = dto;
            main_bus_bll = new BusBLL();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (String.IsNullOrWhiteSpace(txtId.Text) || txtId.Text.Split(' ')[0].Length != 6)
            {
                errorProvider1.SetError(txtId, "Please Fill With BUxxxx format");
                check = false;
            }
            //if (String.IsNullOrWhiteSpace(txtOwnerName.Text))
            //{
            //    errorProvider2.SetError(txtOwnerName, "not allow null");
            //    check = false;
            //}
            if (String.IsNullOrWhiteSpace(txtBSX.Text))
            {
                errorProvider3.SetError(txtBSX, "not allow null");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                errorProvider4.SetError(txtBrand, "not allow null");
                check = false;
            }
            if (DateTime.Compare(dtpDateRegistration.Value, DateTime.Now) > 0)
            {
                errorProvider5.SetError(dtpDateRegistration, "Date Registration can not gather than current date");
                check = false;
            }
            return check;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                try
                {
                    main_bus_bll.InsertBus(txtId.Text, txtBSX.Text, txtBrand.Text, dtpDateRegistration.Value, main_owner_dto.Id, cbbRouteID.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BusViewToAddForOwner_Load(object sender, EventArgs e)
        {
            RouteBLL r_bll = new RouteBLL();
            cbbRouteID.DataSource = r_bll.GetRouteList();
            cbbRouteID.DisplayMember = "Id";
            cbbRouteID.ValueMember = "TuyenDuong";
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();
            lbOwnerName.Text = main_owner_dto.Name;
        }

        private void cbbRouteID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();
        }
    }
}
