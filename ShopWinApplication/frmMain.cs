using ShopWinApplication.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWinApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            OpenForms.AddOpenedForm(this);
        }

        private void linkItemCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.ItemCategories.frmItemCategories frm = new Forms.ItemCategories.frmItemCategories();
            frm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void linkLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Locations.frmLocations frm = new Forms.Locations.frmLocations();
            frm.Show();
        }

        private void linkUnits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Units.frmUnits frm = new Forms.Units.frmUnits();
            frm.Show();
        }
    }
}
