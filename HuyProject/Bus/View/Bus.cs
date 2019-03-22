﻿using Bus.BLL;
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
    public partial class Bus : Form
    {
        private BusBLL bll;
        private BusDTO main_busDto; //chua bus hien hanh
        private OwnerDTO main_ownerDto; //chua owner cua bus hien hanh
        public Bus()
        {
            InitializeComponent();
            bll = new BusBLL();
            dgvBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Bus_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvBus.DataSource = bll.GetBusList();
            //dgvBus.co
        }

        private void dgvBus_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            int index = dgvBus.CurrentRow.Index;
            txtId.Text = dgvBus.Rows[index].Cells["Id"].Value.ToString();
            txtBrand.Text = dgvBus.Rows[index].Cells["Brand"].Value.ToString();
            txtBSX.Text = dgvBus.Rows[index].Cells["BSX"].Value.ToString();
            dtpDateRegistration.Value = DateTime.Parse(dgvBus.Rows[index].Cells["DateRegistration"].Value.ToString());
            try
            {
                main_ownerDto = bll.GetOwnerById(dgvBus.Rows[index].Cells["OwnerId"].Value.ToString());
                txtOwnerName.Text = main_ownerDto.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtId.Text = "";
            txtId.Focus();
            txtBSX.Text = "";
            txtBrand.Text = "";
            dtpDateRegistration.Value = DateTime.Parse("1/1/1970");

        }
    }
}