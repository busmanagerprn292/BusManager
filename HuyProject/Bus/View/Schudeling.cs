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
                    Status = 1,
                    TimeBack = dateTimePicker2.Text
                };

                MessageBox.Show(dateTimePicker2.Text);
                if (dao.Add(busdt))
                {
                    MessageBox.Show("success");
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

                foreach (var item in list)
                {
                    DateTime TimeGo = Convert.ToDateTime(item.DepartureTime);
                    DateTime TimeBack = Convert.ToDateTime(item.TimeBack);

                    if ((TimeGo - DateGoPick).TotalDays==0 &&( (DateGoPick - TimeBack).TotalHours< 0 ) && (DateReturnPick - TimeGo).TotalHours < 0)
                    {
                        return false;
                    }else if ((TimeGo - DateGoPick).TotalDays==0 &&((DateReturnPick - TimeGo).TotalHours > 0) && (TimeBack - TimeGo).TotalHours > 0)
                    {
                        return false;
                    }else if ((DateGoPick-TimeGo).TotalHours >= 0 && (TimeBack - DateGoPick).TotalHours>=0)
                    {
                        return false;
                    }else if ((DateReturnPick - TimeGo).TotalHours >= 0 && (TimeBack - DateReturnPick).TotalHours >= 0) { return false; }
                    else if ((DateGoPick - DateReturnPick).TotalHours ==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadDataGridView()
        {
            tblViewBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblViewBus.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            

            var list = dao.GetAllBus();
            List<BusStationGridView> listView = new List<BusStationGridView>();
            
            if (list != null)
            {
                foreach (var i in list)
                {
                    listView.Add(new BusStationGridView()
                    {
                        BusID = i.BusID,
                        DepartureTime = i.DepartureTime,
                        ID = i.ID,
                        MSNVCAST = i.MSNVCAST,
                        MSNVDRIVER = i.MSNVDRIVER,
                        Status = i.Status.ToString(),
                        TimeBack = i.TimeBack
                    });
                }
                tblViewBus.DataSource = listView;
                tblViewBus.Columns["ID"].Visible = false;
              
                for (int i = 0; i < tblViewBus.Rows.Count; i++)
                {
                    tblViewBus[6, i].Value = Enum.GetName(typeof(Change), list[i].Status).ToString();
                }
                
            }
        }

        private void Schudeling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'busManagerDataSet.BusStation' table. You can move, or remove it, as needed.
            

        }
    }
}
