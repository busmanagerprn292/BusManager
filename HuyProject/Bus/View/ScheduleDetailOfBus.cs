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
    public partial class ScheduleDetailOfBus : Form
    {
        BusDTO main_bus_dto;
        BusStationGridView main_schedule_dto;
        StaffBLL main_staff_bll;
        RouteDTO main_route_dto;
        StaffDTO main_driver_dto;
        StaffDTO main_casher_dto;
        BusBLL bus_bll;
        StaffDetailOfHuy staff_form;
        public ScheduleDetailOfBus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Khi cell click dgvSchdule (Ben BusView)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public ScheduleDetailOfBus(BusDTO dto, RouteDTO rDto, BusStationGridView bDto, StaffDTO casher, StaffDTO driver)
        {
            InitializeComponent();
            main_bus_dto = dto;
            main_route_dto = rDto;
            main_schedule_dto = bDto;
            main_driver_dto = driver;
            main_casher_dto = casher;
            main_staff_bll = new StaffBLL();
            bus_bll = new BusBLL();
            staff_form = null;
        }
        /// <summary>
        /// Khi click vao Create Schedule 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="oDto"></param>
        public ScheduleDetailOfBus(BusDTO dto, RouteDTO rDto)
        {
            InitializeComponent();
            main_bus_dto = dto;
            main_route_dto = rDto;
            main_staff_bll = new StaffBLL();
            bus_bll = new BusBLL();
            staff_form = null;
        }

        private void ScheduleDetailOfBus_Load(object sender, EventArgs e)
        {
            listCasher.DataSource = main_staff_bll.getAll();
            listDriver.DataSource = main_staff_bll.getAll();
            listDriver.DisplayMember = "Name";
            listCasher.DisplayMember = "Name";
            listCasher.ValueMember = "MSNV";
            listDriver.ValueMember = "MSNV";
            LoadData();
        }
        private void LoadData()
        {
            lbBSX.Text = main_bus_dto.BSX;
            lbBusId.Text = main_bus_dto.Id;
            lbTuyenDuong.Text = main_route_dto.TuyenDuong;
            //dtpDepatureTime.Text = main_schedule_dto.DepartureTime.Split(' ')[1] + " " + main_schedule_dto.DepartureTime.Split(' ')[2];
            //dtpTimeBack.Text = main_schedule_dto.TimeBack.Split(' ')[1] + " " + main_schedule_dto.TimeBack.Split(' ')[2];
            if (main_schedule_dto != null && main_casher_dto != null && main_driver_dto != null)
            {
                dtpDepatureTime.Value = DateTime.Parse(main_schedule_dto.DepartureTime);
                dtpTimeBack.Value = DateTime.Parse(main_schedule_dto.TimeBack);
                listCasher.SelectedValue = main_casher_dto.MSNV;
                listDriver.SelectedValue = main_driver_dto.MSNV;
            }
            var list = bus_bll.SearchScheduleOfBusByBusId(main_bus_dto.Id);
            dgvSchedule.DataSource = list;
            dgvSchedule.Columns.Remove("MSNVDRIVER");
            dgvSchedule.Columns.Remove("MSNVCAST");
            dgvSchedule.Columns.Remove("BusID");
            dgvSchedule.Columns.Remove("BXS");
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dgvSchedule.Rows.Count; i++)
            {
                dgvSchedule[3, i].Value = Enum.GetName(typeof(Change), int.Parse(list[i].Status)).ToString();

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dtpDepatureTime.Value = DateTime.Now;
            dtpTimeBack.Value = DateTime.Now;
            listCasher.SelectedIndex = 0;
            listDriver.SelectedIndex = 0;
        }

        private bool KiemTraDuLieu()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            bool check = true;
            if (DateTime.Compare(dtpDepatureTime.Value, DateTime.Now) < 0)
            {
                errorProvider1.SetError(dtpDepatureTime, "Date must gather than current date");
                check = false;
            }
            if (DateTime.Compare(dtpTimeBack.Value, DateTime.Now) < 0)
            {
                errorProvider2.SetError(dtpTimeBack, "Date must gather than current date");
                check = false;
            }
            else
            {
                if (DateTime.Compare(dtpTimeBack.Value, dtpDepatureTime.Value) < 0)
                {
                    errorProvider2.SetError(dtpTimeBack, "Datetime must gather than Depature Time");
                    check = false;
                }
            }
            return check;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string busId = main_bus_dto.Id;
                string driver = listDriver.SelectedValue.ToString();
                string casher = listCasher.SelectedValue.ToString();
                string departure_time = dtpDepatureTime.Value.ToString();
                string back_time = dtpTimeBack.Value.ToString();
                string status = "1";
                try
                {

                    if (checkDateAccess())
                    {
                        main_schedule_dto = new BusStationGridView() { BusID = busId, DepartureTime = departure_time, TimeBack = back_time, MSNVCAST = casher, MSNVDRIVER = driver, Status = status };
                        bus_bll.AddBusStation(main_schedule_dto);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private bool checkDateAccess()
        {
            BusStationDAO dao = new BusStationDAO();
            var list = dao.SearchScheduleOfBusByBusId(main_bus_dto.Id);
            if (list != null)
            {
                DateTime DateGoPick = dtpDepatureTime.Value;
                DateTime DateReturnPick = dtpTimeBack.Value;
                bool check = false;
                foreach (var item in list)
                {
                    DateTime TimeGo = Convert.ToDateTime(item.DepartureTime);
                    DateTime TimeBack = Convert.ToDateTime(item.TimeBack);

                    if ((DateGoPick - TimeBack).TotalMinutes > 0 || (TimeGo - DateReturnPick).TotalMinutes > 0)
                    {
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(dtpDepatureTime, " có lịch rồi");
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (main_schedule_dto != null)
            {
                if (KiemTraDuLieu())
                {

                    int id = int.Parse(dgvSchedule.Rows[dgvSchedule.CurrentRow.Index].Cells["ID"].Value.ToString());
                    string busId = main_bus_dto.Id;
                    string driver = listDriver.SelectedValue.ToString();
                    string casher = listCasher.SelectedValue.ToString();
                    string departure_time = dtpDepatureTime.Value.ToString();
                    string back_time = dtpTimeBack.Value.ToString();
                    try
                    {
                        if (checkDateAccess())
                        {
                            main_schedule_dto = new BusStationGridView() { ID = id, BusID = busId, DepartureTime = departure_time, TimeBack = back_time, MSNVCAST = casher, MSNVDRIVER = driver };
                            bus_bll.UpdateBusStation(main_schedule_dto);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose scheduling before Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (main_schedule_dto != null)
                {
                    bus_bll.DeleteBusStationById(main_schedule_dto.ID);
                    main_schedule_dto = null;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please choose schedule before delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSchedule.CurrentRow.Index;
            dtpDepatureTime.Value = DateTime.Parse(dgvSchedule.Rows[index].Cells["DepartureTime"].Value.ToString());
            dtpTimeBack.Value = DateTime.Parse(dgvSchedule.Rows[index].Cells["TimeBack"].Value.ToString());
            main_schedule_dto = bus_bll.GetDetailOfScheduleById(int.Parse(dgvSchedule.Rows[index].Cells["Id"].Value.ToString()));
            listDriver.SelectedValue = main_schedule_dto.MSNVDRIVER;
            listCasher.SelectedValue = main_schedule_dto.MSNVCAST;
        }

        private void listDriver_Click(object sender, EventArgs e)
        {
            if (staff_form != null)
            {
                if (staff_form.IsDisposed)
                {
                    staff_form = null;
                }
            }
            if (staff_form == null)
            {
                staff_form = new StaffDetailOfHuy();
                staff_form.main_staff_dto = (StaffDTO)listDriver.SelectedItem;
                staff_form.LoadData();
                staff_form.Show();
            }
            else
            {
                staff_form.main_staff_dto = (StaffDTO)listDriver.SelectedItem;
                staff_form.LoadData();
            }
        }

        private void listCasher_Click(object sender, EventArgs e)
        {
            if (staff_form != null)
            {
                if (staff_form.IsDisposed)
                {
                    staff_form = null;
                }
            }
            if (staff_form == null)
            {
                staff_form = new StaffDetailOfHuy();
                staff_form.main_staff_dto = (StaffDTO)listCasher.SelectedItem;
                staff_form.LoadData();
                staff_form.Show();
            }
            else
            {
                staff_form.main_staff_dto = (StaffDTO)listCasher.SelectedItem;
                staff_form.LoadData();
            }
        }

        private void btnShowStaffDetail_Click(object sender, EventArgs e)
        {
            staff_form.Show();
        }

        private void ScheduleDetailOfBus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (staff_form != null)
            {
                if (!staff_form.IsDisposed)
                {
                    staff_form.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
