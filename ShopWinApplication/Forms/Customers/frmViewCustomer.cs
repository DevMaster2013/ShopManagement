using ShopWinApplication.Data;
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

namespace ShopWinApplication.Forms.Customers
{
    public partial class frmViewCustomer : Form
    {
        Customer currentCustomer;

        public frmViewCustomer(Customer cust)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentCustomer = DBManagement.GetDB().Customers.Find(cust.ID);            
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Form frmCustomers = OpenForms.GetForm("frmCustomers");
            if (frmCustomers != null)
                frmCustomers.Activate();
            else
            {
                frmCustomers frm = new frmCustomers();
                frm.Show();
            }
        }

        private void frmViewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void PopulateFormData()
        {
            txtName.Text = currentCustomer.Name;
            txtDescription.Text = currentCustomer.Description;
            txtAddress.Text = currentCustomer.Address;
            txtTelNo.Text = currentCustomer.MobileNo;
            dataSellOrderCount.Text = currentCustomer.SellOrders.Count().ToString() + " عملية";

            dataCreditTotal.Text = DBManagement.GetTotalDebitForCustomer(currentCustomer).ToString() + " جنيه مصرى";
        }

        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditCustomer frm = new frmEditCustomer(currentCustomer);
            frm.Show();
        }

        private void dataCreditTotal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataSellOrderCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
