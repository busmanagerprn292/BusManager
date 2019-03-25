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
    public partial class BusDetailOfOwner : Form
    {
        public List<BusDTO> _listBus { get; set; }
        private List<RouteDTO> _listRoute;
        private BusDTO dto;
        private string _ownerName;
        public BusDetailOfOwner()
        {
            InitializeComponent();
        }
        public BusDetailOfOwner(BusDTO dto, List<BusDTO> _listBus, string _ownerName)
        {
            InitializeComponent();
            this.dto = dto;
            this._listBus = _listBus;
            this._ownerName = _ownerName;
        }

        private bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (String.IsNullOrWhiteSpace(txtBSX.Text))
            {
                errorProvider1.SetError(txtBSX, "not allow null");
                check = false;
            }
            if (String.IsNullOrWhiteSpace(txtBrand.Text))
            {
                errorProvider2.SetError(txtBrand, "not allow null");
                check = false;
            }
            if (DateTime.Compare(dtpDateRegistration.Value, DateTime.Now) > 0)
            {
                errorProvider3.SetError(dtpDateRegistration, "Date Registration can not gather than current date");
                check = false;
            }
            return check;
        }
        private void FillBusDetail()
        {
            lbId.Text = dto.Id;
            txtBSX.Text = dto.BSX;
            txtBrand.Text = dto.Brand;
            dtpDateRegistration.Text = dto.DateRegistration.ToShortDateString();
            cbbRouteID.SelectedIndex = cbbRouteID.FindStringExact(dto.RouteID);
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();

        }
        private void loadListBus()
        {
            listBus.DataSource = null;
            listBus.DataSource = _listBus;
            listBus.DisplayMember = "BSX";
            listBus.ValueMember = "Id";
        }
        private void BusDetailOfOwner_Load(object sender, EventArgs e)
        {
            //Load list bus to listbox
            loadListBus();

            //Get and load list Route
            RouteBLL bll = new RouteBLL();
            _listRoute = bll.GetRouteList();
            cbbRouteID.DataSource = _listRoute;
            cbbRouteID.DisplayMember = "Id";
            cbbRouteID.ValueMember = "TuyenDuong";
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();

            //Fill detail of bus to textfield
            FillBusDetail();
            lbOwnerName.Text = _ownerName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                string id = lbId.Text;
                string bsx = txtBSX.Text;
                string brand = txtBrand.Text;
                DateTime dateRegistration = dtpDateRegistration.Value;    // DateTime.Parse(dtpDateRegistration.Value.ToShortDateString());
                string ownerId = dto.OwnerID;
                string routeId = cbbRouteID.Text;
                dto = new BusDTO() { Id = id, Brand = brand, BSX = bsx, DateRegistration = dateRegistration, OwnerID = ownerId, RouteID = routeId };
                BusBLL bll = new BusBLL();
                try
                {
                    bll.UpdateBus(id, bsx, brand, dateRegistration, ownerId, routeId);
                    BusDTO busflag = null;
                    foreach (var bus in _listBus)
                    {
                        if (bus.Id.Equals(id))
                        {
                            busflag = bus;
                        }
                    }
                    _listBus.Remove(busflag);
                    busflag = dto;
                    _listBus.Add(busflag);
                    loadListBus();
                    FillBusDetail();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lbId.Text;
            try
            {
                BusBLL bll = new BusBLL();
                bll.DeleteBus(id);
                BusDTO busflag = null;
                foreach (var bus in _listBus)
                {
                    if (bus.Id.Equals(id))
                    {
                        busflag = bus;
                    }
                }
                _listBus.Remove((BusDTO)listBus.SelectedItem);
                loadListBus();
                if(_listBus.Count != 0)
                {
                    listBus.SelectedIndex = 0;
                    dto = _listBus[0];
                    FillBusDetail();
                }
                else
                {
                    MessageBox.Show("Delete successful");
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBus_Click(object sender, EventArgs e)
        {
            foreach (var bus in _listBus)
            {
                if (bus.Id.Equals(listBus.SelectedValue))
                {
                    dto = bus;
                }
            }
            FillBusDetail();
        }

        private void cbbRouteID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTuyenDuong.Text = cbbRouteID.SelectedValue.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
