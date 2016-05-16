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
    public partial class frmEditCustomer : Form
    {
        Customer currentCustomer;

        public frmEditCustomer(Customer cust)
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

        private void frmEditCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            currentCustomer.Name = txtName.Text;
            currentCustomer.Description = txtDescription.Text;
            currentCustomer.Address = txtAddress.Text;
            currentCustomer.MobileNo = txtTelNo.Text;

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة العملاء؟"))
                {
                    linkReturn_LinkClicked(linkReturn, new LinkLabelLinkClickedEventArgs(linkReturn.Links[0]));
                }                
            }
            else
            {
                MessageManager.SaveDataSuccessMessage("لم يتم حفظ البيانات بنجاح");
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

        private void PopulateFormData()
        {
            txtName.Text = currentCustomer.Name;
            txtDescription.Text = currentCustomer.Description;
            txtAddress.Text = currentCustomer.Address;
            txtTelNo.Text = currentCustomer.MobileNo;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }
    }
}
