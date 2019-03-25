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
    public partial class Schudeling : Form
    {
        BusBLL bus = new BusBLL();
        BusStationDAO dao = new BusStationDAO();
        StaffBLL Staff = new StaffBLL();
        public Schudeling()
        {
            InitializeComponent();
            LoadAllBus();
            LoadAllStaff();
            LoadDataGridView();

        }
        public void test()
        {
            DateTime Star = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime End = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan cacu = Star - End;
            double a = cacu.TotalHours;
            MessageBox.Show(a.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkDateAccess())
            {
                string key = ((KeyValuePair<string, string>)CbBSX.SelectedItem).Key;
                string[] index = key.Split('.');
                string Casher = ((KeyValuePair<string, string>)cbCasher.SelectedItem).Value;
                string Driver = ((KeyValuePair<string, string>)cbDriver.SelectedItem).Value;

                BusStationDTO busdt = new BusStationDTO()
                {
                    BusID = index[2],
                    DepartureTime = dateTimePicker1.Text,
                    MSNVCAST = ((KeyValuePair<string, string>)cbCasher.SelectedItem).Value,
                    MSNVDRIVER = ((KeyValuePair<string, string>)cbDriver.SelectedItem).Value,
                    Status = "1",
                    TimeBack = dateTimePicker2.Text
                };

                if (dao.Add(busdt))
                {
                    MessageBox.Show("success");
                    LoadDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Your Bus has Schudeling");

            }
        }
        public void LoadAllBus()
        {
            var list = bus.GetBusList();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (var item in list)
            {
                comboSource.Add(item.OwnerID + "." + item.DateRegistration + "." + item.Id, item.BSX);
            }
            CbBSX.DataSource = new BindingSource(comboSource, null);
            CbBSX.DisplayMember = "Value";
            CbBSX.ValueMember = "Key";
        }
        public void LoadAllStaff()
        {
            var list = Staff.getAll();
            var listCs = list.Where(a => a.RoleID.Equals("SC"));
            var listCd = list.Where(b => b.RoleID.Equals("SD"));
            Dictionary<string, string> comboCasher = new Dictionary<string, string>();
            foreach (var item in listCs)
            {
                comboCasher.Add(item.Name + "." + item.Phone + "." + item.Date, item.MSNV);
            }
            cbCasher.DataSource = new BindingSource(comboCasher, null);
            cbCasher.DisplayMember = "Value";
            cbCasher.ValueMember = "Key";

            Dictionary<string, string> comboDriver = new Dictionary<string, string>();
            foreach (var item in listCd)
            {
                comboDriver.Add(item.Name + "." + item.Phone + "." + item.Date, item.MSNV);
            }
            cbDriver.DataSource = new BindingSource(comboDriver, null);
            cbDriver.DisplayMember = "Value";
            cbDriver.ValueMember = "Key";

        }
        private void CbBSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)CbBSX.SelectedItem).Key;
            string[] index = key.Split('.');
            txtOwner.Text = index[0];
            txtDateRegis.Text = index[1];
        }
        private void cbCasher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRole.Text = "Casher";
            string key = ((KeyValuePair<string, string>)cbCasher.SelectedItem).Key;
            string[] index = key.Split('.');
            txtName.Text = index[0];
            txtPhone.Text = index[1];
            txtDateOfBirth.Text = index[2];
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRole.Text = "Driver";

            string key = ((KeyValuePair<string, string>)cbCasher.SelectedItem).Key;
            string[] index = key.Split('.');
            txtName.Text = index[0];
            txtPhone.Text = index[1];
            txtDateOfBirth.Text = index[2];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            DateTime DateGoPick = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime DateReturnPick = Convert.ToDateTime(dateTimePicker2.Text);


            TimeSpan cacu = Today - DateGoPick;
            TimeSpan Check = DateReturnPick - DateGoPick;

            if (cacu.TotalDays > 1)
            {
                dateTimePicker1.Text = DateTime.Now.ToString();
            }
            else if (Check.TotalHours > 3 || Check.TotalHours < 0)
            {
                DateReturnPick = DateGoPick.AddHours(3);
                dateTimePicker2.Text = DateReturnPick.ToString();
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            DateTime DateGoPick = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime DateReturnPick = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan cacu = Today - DateGoPick;
            TimeSpan Check = DateReturnPick - DateGoPick;
            if (cacu.TotalDays > 1)
            {
                dateTimePicker2.Text = DateTime.Now.ToString();
            }
            else if (Check.TotalHours > 3 || Check.TotalHours < 0)
            {
                DateGoPick = DateReturnPick.AddHours(-3);
                dateTimePicker1.Text = DateGoPick.ToString();
            }
        }

        private bool checkDateAccess()
        {
            string key = ((KeyValuePair<string, string>)CbBSX.SelectedItem).Key;
            string[] index = key.Split('.');
            var list = dao.SearchScheduleOfBusByBusId(index[2]);
            if (list != null)
            {
                DateTime DateGoPick = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime DateReturnPick = Convert.ToDateTime(dateTimePicker2.Text);
                bool check = false;
                foreach (var item in list)
                {
                    DateTime TimeGo = Convert.ToDateTime(item.DepartureTime);
                    DateTime TimeBack = Convert.ToDateTime(item.TimeBack);

                    if ((DateGoPick - TimeBack).TotalMinutes > 0 || (TimeGo - DateReturnPick).TotalMinutes > 0)
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        List<BusStationDTO> list = new List<BusStationDTO>();
        public void LoadDataGridView()
        {
            tblViewBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblViewBus.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;


            list = dao.GetAllBus();
            var bxs = bus.GetBusList();
            List<BusStationGridView> listView = new List<BusStationGridView>();

            if (list != null)
            {
                foreach (var i in list)
                {
                    var thisBus = bxs.Where(a => a.Id == i.BusID).ToList();
                    listView.Add(new BusStationGridView()
                    {
                        BusID = i.BusID,
                       BXS = thisBus[0].BSX,
                        DepartureTime = i.DepartureTime,
                        ID = i.ID,
                        MSNVCAST = i.MSNVCAST,
                        MSNVDRIVER = i.MSNVDRIVER,
                        Status = i.Status.ToString(),
                        TimeBack = i.TimeBack,
                    });
                }
                tblViewBus.DataSource = listView;
                tblViewBus.Columns["ID"].Visible = false;

                for (int i = 0; i < tblViewBus.Rows.Count; i++)
                {
                    tblViewBus[6, i].Value = Enum.GetName(typeof(Change),int.Parse( list[i].Status)).ToString();
                }
            }
        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < tblViewBus.Rows.Count; i++)
            {
                DateTime Now = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                DateTime Back = Convert.ToDateTime(list[i].TimeBack);
                DateTime Go = Convert.ToDateTime(list[i].DepartureTime);

                if ((Now - Back).TotalMinutes >0)
                {
                    tblViewBus[6, i].Value = Enum.GetName(typeof(Change), 3).ToString();// ready
                   

                    string a = Convert.ToString(tblViewBus.Rows[i].Cells["status"].Value);
                    if (a.Equals("finished")==false)
                    {
                        dao.UpdateStatus(list[i].ID,"3");
                        LoadDataGridView();
                    }
                }
                else if ((Go - Now).TotalMinutes > 10)
                {
                    tblViewBus[6, i].Value = Enum.GetName(typeof(Change), 1).ToString(); // 

                    string a = Convert.ToString(tblViewBus.Rows[i].Cells["status"].Value);
                    if (a.Equals("ready") == false)
                    {
                        LoadDataGridView();
                        dao.UpdateStatus(list[i].ID, "1");
                    }
                }
                else
                {
                    tblViewBus[6, i].Value = Enum.GetName(typeof(Change), 4).ToString();
                    if (count%10==0)
                    {
                        dao.UpdateStatus(list[i].ID, "4");
                        LoadDataGridView();
                        count++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tblViewBus.SelectedCells.Count > 0)
            {
                int selectedrowindex = tblViewBus.SelectedCells[0].RowIndex;
                int id = list[selectedrowindex].ID;
                if (dao.DeleteById(id))
                {
                    MessageBox.Show("success");
                    LoadDataGridView();
                }
            }
        }
    }
}
