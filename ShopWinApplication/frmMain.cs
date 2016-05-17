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

        private void linkSuppliers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Suppliers.frmSuppliers frm = new Forms.Suppliers.frmSuppliers();
            frm.Show();
        }

        private void linkItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Items.frmItems frm = new Forms.Items.frmItems();
            frm.Show();
        }

        private void linkCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Customers.frmCustomers frm = new Forms.Customers.frmCustomers();
            frm.Show();
        }

        private void linkSellOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkBuyOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkDebits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
