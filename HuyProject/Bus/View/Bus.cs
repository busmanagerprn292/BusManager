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
    public partial class Bus : Form
    {
        private BusBLL bll;
        private BusDTO main_busDto; //chua bus hien hanh
        private List<BusStationDTO> main_scheduleDto; //chua owner cua bus hien hanh
        private List<OwnerDTO> main_listOwner; //chua owner cua bus hien hanh
        private List<RouteDTO> main_listRoute; //chua owner cua bus hien hanh
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
            LoadDataOwner();

            //Get and load list Route
            RouteBLL r_bll = new RouteBLL();
            main_listRoute = r_bll.GetRouteList();
            cbbRouteID.DataSource = main_listRoute;
            cbbRouteID.DisplayMember = "Id";
            cbbRouteID.ValueMember = "TuyenDuong";
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();
        }

        /// <summary>
        /// Load toan bo danh sach bus trong database lên
        /// </summary>
        private void LoadData()
        {
            dgvBus.DataSource = bll.GetBusList();
        }
        /// <summary>
        /// Update main_busDto form textfield
        /// </summary>
        private void UpdateMainBusDto()
        {
            main_busDto = new BusDTO()
            {
                Id = txtId.Text,
                BSX = txtBSX.Text,
                Brand = txtBrand.Text,
                DateRegistration = dtpDateRegistration.Value,
                OwnerID = cbbOwner.SelectedValue.ToString(),
                RouteID = cbbRouteID.Text
            };
        }
        /// <summary>
        /// Load DataSource form database
        /// </summary>
        private void LoadDataOwner()
        {
            main_listOwner = bll.GetOwnerList();

            cbbOwner.DataSource = main_listOwner;
            cbbOwner.DisplayMember = "Name";
            cbbOwner.ValueMember = "Id";
        }

        /// <summary>
        /// Load lich trinh cua Bus
        /// </summary>
        private void LoadListSchedule()
        {
            dgvSchedule.DataSource = null;
            dgvSchedule.DataSource = main_scheduleDto;
            dgvSchedule.Columns.Remove("MSNVDRIVER");
            dgvSchedule.Columns.Remove("MSNVCAST");
        }

        private void dgvBus_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            cbbOwner.Enabled = false;
            int index = dgvBus.CurrentRow.Index;
            txtId.Text = dgvBus.Rows[index].Cells["Id"].Value.ToString();
            txtBrand.Text = dgvBus.Rows[index].Cells["Brand"].Value.ToString();
            txtBSX.Text = dgvBus.Rows[index].Cells["BSX"].Value.ToString();
            dtpDateRegistration.Value = DateTime.Parse(dgvBus.Rows[index].Cells["DateRegistration"].Value.ToString());
            cbbOwner.SelectedValue = dgvBus.Rows[index].Cells["OwnerID"].Value.ToString();
            cbbRouteID.SelectedIndex = cbbRouteID.FindStringExact(dgvBus.Rows[index].Cells["RouteId"].Value.ToString());
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();
            try
            {
                main_scheduleDto = bll.SearchScheduleOfBusByBusId(txtId.Text);
                foreach (var item in main_scheduleDto)
                {
                    item.DepartureTime = item.DepartureTime.Split(' ')[1] + " " + item.DepartureTime.Split(' ')[2];
                    item.TimeBack = item.TimeBack.Split(' ')[1] + " " + item.TimeBack.Split(' ')[2];
                    UpdateMainBusDto();
                }
                LoadListSchedule();
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
            cbbOwner.Enabled = true;
            txtId.ReadOnly = false;
            txtId.Text = "";
            txtId.Focus();
            txtBSX.Text = "";
            txtBrand.Text = "";
            dtpDateRegistration.Value = DateTime.Parse("1/1/1970");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                main_busDto = bll.GetBusById(txtSearch.Text);
                if (main_busDto != null)
                {
                    dgvBus.DataSource = null;
                    List<BusDTO> listBus = new List<BusDTO>();
                    listBus.Add(main_busDto);
                    dgvBus.DataSource = listBus;
                }
                else
                {
                    throw new Exception("Bus does not existed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            if (String.IsNullOrWhiteSpace(txtId.Text) || txtId.Text.Length != 6)
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
            if (!txtId.ReadOnly)
            {
                if (KiemTraDuLieu())
                {
                    try
                    {
                        OwnerDTO od = (OwnerDTO)cbbOwner.SelectedItem;
                        bll.InsertBus(txtId.Text, txtBSX.Text, txtBrand.Text, dtpDateRegistration.Value, od.Id, cbbRouteID.Text);
                        LoadData();
                        UpdateMainBusDto();
                        txtId.ReadOnly = true;
                        cbbOwner.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please click new before add");
            }
            
        }

        private void cbbRouteID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly && !cbbOwner.Enabled)
            {
                if (KiemTraDuLieu())
                {
                    try
                    {
                        OwnerDTO od = (OwnerDTO)cbbOwner.SelectedItem;
                        bll.UpdateBus(txtId.Text, txtBSX.Text, txtBrand.Text, dtpDateRegistration.Value, od.Id, cbbRouteID.Text);
                        LoadData();
                        UpdateMainBusDto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose bus before update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.ReadOnly)
            {
                try
                {
                    bll.DeleteBus(txtId.Text);
                    main_busDto = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose bus before Delete");
            }
        }

        private void btnShowOwner_Click(object sender, EventArgs e)
        {
            OwnerDetailOfBus form = new OwnerDetailOfBus((OwnerDTO)cbbOwner.SelectedItem);
            form.ShowDialog();
            LoadDataOwner();
            //OwnerDTO flag_owner_dto = null;
            //foreach (var item in main_listOwner)
            //{
            //    if (item.Id.ToUpper().Equals(cbbOwner.SelectedValue.ToString().ToUpper()))
            //    {
            //        flag_owner_dto = item;
            //    }
            //}
            ////main_listOwner.
            //main_listOwner.Remove(flag_owner_dto);
            //flag_owner_dto = form.dto;
            //main_listOwner.Add(flag_owner_dto);
            //LoadDataOwner();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if(main_busDto == null)
            {
                MessageBox.Show("Please choose bus before create Schedule");
            }
            else
            {
                ScheduleDetailOfBus form = new ScheduleDetailOfBus(main_busDto,(RouteDTO)cbbRouteID.SelectedItem);
                form.ShowDialog();
            }
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (main_busDto == null)
            {
                MessageBox.Show("Please choose bus before create Schedule");
            }
            else
            {
                StaffBLL sBll = new StaffBLL();
                int index = dgvSchedule.CurrentRow.Index;
                BusStationDTO schedule_dto = bll.GetDetailOfScheduleById(int.Parse(dgvSchedule.Rows[index].Cells["Id"].Value.ToString()));
                StaffDTO driver = sBll.SearchStaffById(schedule_dto.MSNVDRIVER);
                StaffDTO casher = sBll.SearchStaffById(schedule_dto.MSNVCAST);
                ScheduleDetailOfBus form = new ScheduleDetailOfBus(main_busDto, (RouteDTO)cbbRouteID.SelectedItem , schedule_dto , driver, casher);
                form.ShowDialog();
                main_scheduleDto = bll.SearchScheduleOfBusByBusId(txtId.Text);
                LoadListSchedule();
            }
        }
    }
}
