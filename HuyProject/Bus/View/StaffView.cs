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
    public partial class StaffView : Form
    {
        StaffBLL bll;
        public StaffView()
        {
            InitializeComponent();
            bll = new StaffBLL();
            LoadView();
            LoadComboBox();
        }

        int Number = 0;
        private void StaffView_Load(object sender, EventArgs e)
        {
            gvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadView()
        {
            gvStaff.DataSource = bll.getAll();
            gvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var a = bll.getAll();
            string ID = a.ElementAt(a.Count - 1).MSNV;
            CreateID(ID);
        }
        public void CreateID(string id)
        {
            Number = int.Parse(id.Substring(id.Length - 2));
        }
        public void LoadComboBox()
        {
            List<RoleDTO> list = bll.getAllR();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (var item in list)
            {
                comboSource.Add(item.RoleID, item.RoleName);
            }                   //    key    -   values
            cbStaffRole.DataSource = new BindingSource(comboSource, null);
            cbStaffRole.DisplayMember = "Value";
            cbStaffRole.ValueMember = "Key";
            //string key = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
            //string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string CheckValidate()
        {
            string error = "";
            if (txtStaffCMND.MaskCompleted == false)
            {
                ErrorCmnd.ForeColor = Color.Red;
                ErrorCmnd.Text = "Validate Error";
                error += "Error";
            }
            else
            {
                ErrorCmnd.ForeColor = Color.White;
                ErrorCmnd.Text = "";
                error += "";

            }

            if (txtStaffPhone.MaskCompleted == false)
            {
                ErrorPhone.ForeColor = Color.Red;
                ErrorPhone.Text = "Validate Error";
                error += "Error";

            }
            else
            {
                ErrorPhone.ForeColor = Color.White;
                ErrorPhone.Text = "";
                error += "";

            }

            if (txtStaffName.Text.Length == 0)
            {
                ErrorName.ForeColor = Color.Red;
                ErrorName.Text = "Validate Error";
                error += "Error";
            }
            else
            {
                ErrorName.ForeColor = Color.White;
                ErrorName.Text = "";
                error += "";
            }

            return error;
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            string check = CheckValidate();
            if (check.Equals(""))
            {
                if (Number < 10)
                {
                    if (bll.InsertStaff(new StaffDTO()
                    {
                        RoleID = ((KeyValuePair<string, string>)cbStaffRole.SelectedItem).Key,
                        CMND = txtStaffCMND.Text,
                        Date = dtpStaffDateOfBirth.Text,
                        MSNV = "ST000" + ++Number,
                        Name = txtStaffName.Text,
                        Phone = txtStaffPhone.Text
                    }))
                    {
                        MessageBox.Show("Success");
                        LoadView();
                    }
                }
                else
                {
                    if (bll.InsertStaff(new StaffDTO()
                    {
                        RoleID = ((KeyValuePair<string, string>)cbStaffRole.SelectedItem).Key,
                        CMND = txtStaffCMND.Text,
                        Date = dtpStaffDateOfBirth.Text,
                        MSNV = "ST00" + ++Number,
                        Name = txtStaffName.Text,
                        Phone = txtStaffPhone.Text
                    }))
                    {
                        MessageBox.Show("Success");
                        LoadView();
                    }
                }
            }
        }


        private void btnStaffNew_Click_1(object sender, EventArgs e)
        {
            txtStaffMSNV.Text = "";
            txtStaffCMND.Text = "";
            txtStaffName.Text = "";
            txtStaffPhone.Text = "";
            cbStaffRole.SelectedIndex = 0;
        }

        private void btnStaffUpdate_Click_1(object sender, EventArgs e)
        {
            if (CheckValidate().Equals(""))
            {
                if (bll.UpdateStaff(new StaffDTO()
                {
                    RoleID = ((KeyValuePair<string, string>)cbStaffRole.SelectedItem).Key,
                    CMND = txtStaffCMND.Text,
                    Date = dtpStaffDateOfBirth.Text,
                    MSNV = txtStaffMSNV.Text,
                    Name = txtStaffName.Text,
                    Phone = txtStaffPhone.Text
                }))
                {
                    MessageBox.Show("Success");
                    LoadView();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void btnStaffDelete_Click_1(object sender, EventArgs e)
        {
            if (bll.DeleteStaff(txtStaffMSNV.Text))
            {
                MessageBox.Show("Successs");
                LoadView();
            }
            else { MessageBox.Show("Error"); }
        }

        private void txtStaffCMND_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvStaff_Click_1(object sender, EventArgs e)
        {
            if (gvStaff.SelectedRows.Count > 0)
            {
                string id = gvStaff.SelectedRows[0].Cells[0].Value.ToString();
                var List = bll.getAll().Where(s => s.MSNV.Equals(id));
                var St = List.ElementAt(0);
                if (St != null)
                {
                    txtStaffCMND.Text = St.CMND.ToString();
                    txtStaffMSNV.Text = St.MSNV.ToString();
                    txtStaffName.Text = St.Name.ToString();
                    txtStaffPhone.Text = St.Phone.ToString();
                    cbStaffRole.SelectedValue = St.RoleID.ToString();
                    dtpStaffDateOfBirth.Text = St.Date.ToString();
                }
            }
        }
    }
}
