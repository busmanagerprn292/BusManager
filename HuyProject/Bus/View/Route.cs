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
    public partial class Route : Form
    {
        private RouteBLL bll;
        public Route()
        {
            InitializeComponent();
            bll = new RouteBLL();
        }
        public bool KiemTraDuLieu()
        {
            bool check = true;
            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(txtTuyenDuong.Text))
            {
                errorProvider1.SetError(txtTuyenDuong, "Không được để trống");
                check = false;
            }
            return check;
        }
        private void Route_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            gvRouteList.DataSource = bll.GetRouteList();
            gvRouteList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtID.Text = "";
            txtTuyenDuong.Text = "";
            txtID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                if (!txtID.ReadOnly)
                {
                    try
                    {
                        bll.InsertRoute(int.Parse(txtID.Text), txtTuyenDuong.Text);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Click new before add");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly)
            {
                if (KiemTraDuLieu())
                {
                    try
                    {
                        bll.UpdateRoute(int.Parse(txtID.Text), txtTuyenDuong.Text);
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
                MessageBox.Show("Please choose route before update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly)
            {
                try
                {
                    bll.DeleteRoute(int.Parse(txtID.Text));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose route before delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtID.ReadOnly)
            {
                if (!String.IsNullOrWhiteSpace(txtID.Text))
                {
                    try
                    {
                        RouteDTO dto = bll.GetRouteById(int.Parse(txtID.Text));
                        if (dto != null)
                        {
                            txtTuyenDuong.Text = dto.TuyenDuong;
                        }
                        else
                        {
                            MessageBox.Show("Route does not exist!");
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
                MessageBox.Show("Please Click new to enter ID for search");
            }
        }

        private void gvRouteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = gvRouteList.CurrentRow.Index;
            //txtID.Text = gvRouteList.Rows[index].Cells["Id"].Value.ToString();
            //txtTuyenDuong.Text = gvRouteList.Rows[index].Cells["TuyenDuong"].Value.ToString();
        }

        private void gvRouteList_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            int index = gvRouteList.CurrentRow.Index;
            txtID.Text = gvRouteList.Rows[index].Cells["Id"].Value.ToString();
            txtTuyenDuong.Text = gvRouteList.Rows[index].Cells["TuyenDuong"].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
