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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolbarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolbarToolStripMenuItem1.Checked;
        }

        private void statusBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem1.Checked;

        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Muốn tắt không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void routeMenu_Click(object sender, EventArgs e)
        {
            Route form = new Route();
            form.ShowDialog();
        }

        private void ownerMenu_Click(object sender, EventArgs e)
        {
            Owner form = new Owner();
            form.ShowDialog();
        }

        private void busMenu_Click(object sender, EventArgs e)
        {
            Bus form = new Bus();
            form.ShowDialog();
        }

        private void staffMenu_Click(object sender, EventArgs e)
        {
            StaffView form = new StaffView();
            form.ShowDialog();
        }

        private void schedulingMenu_Click(object sender, EventArgs e)
        {
            Schudeling form = new Schudeling();
            form.ShowDialog();
        }
    }
}
