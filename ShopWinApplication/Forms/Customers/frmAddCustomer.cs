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
using ShopWinApplication.Data.ViewModels;

namespace ShopWinApplication.Forms.Customers
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
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

        private void frmAddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            Customer cust = new Customer();
            cust.Name = txtName.Text;
            cust.Description = txtDescription.Text;
            cust.Address = txtAddress.Text;
            cust.MobileNo = txtTelNo.Text;

            DBManagement.GetDB().Customers.Add(cust);

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                MessageManager.SaveDataSuccessMessage("لقد تم حفظ البيانات بنجاح");                
                txtName.Text = txtDescription.Text = "";
                txtAddress.Text = txtTelNo.Text = "";
            }
            else
            {
                MessageManager.SaveDataFailureMessage("لم يتم حفظ البيانات بنجاح");
            }
        }

        private bool IsValidData()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للعميل", txtName);
                return false;
            }
            return true;
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
