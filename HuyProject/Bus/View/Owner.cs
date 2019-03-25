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
    public partial class Owner : Form
    {
        private OwnerBLL bll;
        private OwnerDTO main_owner_dto;
        private List<BusDTO> _listBus;
        public Owner()
        {
            InitializeComponent();
            bll = new OwnerBLL();
        }
        public bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (String.IsNullOrWhiteSpace(txtId.Text) || txtId.Text.Split(' ')[0].Length != 6)
            {
                errorProvider1.SetError(txtId, "format OWxxxx 'x' is digit");
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
            if (DateTime.Compare(dtpDateOfBirth.Value, DateTime.Now) > 0)
            {
                errorProvider6.SetError(dtpDateOfBirth, "Date does not gather than current date");
                check = false;
            }
            return check;
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvOwner.DataSource = bll.GetOwnerList();
            dgvOwner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadListBus()
        {
            listBus.DataSource = null;
            listBus.DataSource = _listBus;
            listBus.DisplayMember = "BSX";
            listBus.ValueMember = "Id";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            try
            {
                OwnerDTO dto = bll.GetOwnerById(id);
                txtId.Text = dto.Id;
                txtName.Text = dto.Name;
                txtPhone.Text = dto.Phone;
                txtCMND.Text = dto.CMND;
                txtAddress.Text = dto.Address;
                dtpDateOfBirth.Value = dto.DateOfBirth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dgvOwner.Data
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            dtpDateOfBirth.Text = "1/1/1970";
            txtCMND.Text = "";
            txtAddress.Text = "";
            txtId.Focus();
            txtId.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtId.ReadOnly)
            {
                if (KiemTraDuLieu())
                {
                    string id = txtId.Text;
                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    DateTime dob = dtpDateOfBirth.Value;
                    string cmnd = txtCMND.Text;
                    string address = txtAddress.Text;
                    try
                    {
                        bll.InsertOwner(id, name, phone, dob, cmnd, address);
                        main_owner_dto = new OwnerDTO() { Id = id, Name = name, Phone = phone, DateOfBirth = dob, CMND = cmnd, Address = address };
                        LoadData();
                        txtId.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click new to add Owner");
            }
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
                        main_owner_dto = new OwnerDTO() { Id = id, Name = name, Phone = phone, DateOfBirth = dob, CMND = cmnd, Address = address };
                        LoadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly)
            {
                string id = txtId.Text;
                try
                {
                    bll.DeleteOwner(id);
                    main_owner_dto = null;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please chosse to delete Owner");
            }
        }

        private void dgvOwner_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            int index = dgvOwner.CurrentRow.Index;
            txtId.Text = dgvOwner.Rows[index].Cells["Id"].Value.ToString();
            txtName.Text = dgvOwner.Rows[index].Cells["Name"].Value.ToString();
            txtPhone.Text = dgvOwner.Rows[index].Cells["Phone"].Value.ToString();
            txtCMND.Text = dgvOwner.Rows[index].Cells["CMND"].Value.ToString();
            txtAddress.Text = dgvOwner.Rows[index].Cells["Address"].Value.ToString();
            dtpDateOfBirth.Value = DateTime.Parse(dgvOwner.Rows[index].Cells["DateOfBirth"].Value.ToString());
            _listBus = bll.GetMyListBuses(txtId.Text);
            main_owner_dto = new OwnerDTO() { Id = txtId.Text, Name = txtName.Text, Phone = txtPhone.Text, DateOfBirth = dtpDateOfBirth.Value, CMND = txtCMND.Text, Address = txtAddress.Text };
            LoadListBus();
        }

        private void listBus_Click(object sender, EventArgs e)
        {
            if (_listBus != null)
            {
                if (listBus.SelectedItem != null)
                {
                    try
                    {
                        BusDetailOfOwner _detailBusForm = new BusDetailOfOwner((BusDTO)listBus.SelectedItem, _listBus, txtName.Text);
                        _detailBusForm.ShowDialog();
                        _listBus = bll.GetMyListBuses(txtId.Text);
                        LoadListBus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if (main_owner_dto != null)
            {
                BusViewToAddForOwner form = new BusViewToAddForOwner(main_owner_dto);
                form.ShowDialog();
                _listBus = bll.GetMyListBuses(txtId.Text);
                LoadData();
                LoadListBus();
            }
            else
            {
                MessageBox.Show("Please Choose Owner before add!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
