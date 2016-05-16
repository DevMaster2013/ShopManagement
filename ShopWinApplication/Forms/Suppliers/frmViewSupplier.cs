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

namespace ShopWinApplication.Forms.Suppliers
{
    public partial class frmViewSupplier : Form
    {
        Supplier currentSupplier;

        public frmViewSupplier(Supplier sub)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentSupplier = DBManagement.GetDB().Suppliers.Find(sub.ID);            
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Form frmSuppliers = OpenForms.GetForm("frmSuppliers");
            if (frmSuppliers != null)
                frmSuppliers.Activate();
            else
            {
                frmSuppliers frm = new frmSuppliers();
                frm.Show();
            }
        }

        private void frmViewSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void PopulateFormData()
        {
            itemCategoryForSupplierBindingSource.DataSource = DBManagement.GetItemCategoriesForSuppliers(currentSupplier.ID, false);

            txtName.Text = currentSupplier.Name;
            txtDescription.Text = currentSupplier.Description;
            txtAddress.Text = currentSupplier.Address;
            txtTelNo.Text = currentSupplier.MobileNo;
            dataItemCategoryCount.Text = currentSupplier.ItemCategorySuppliers.Count().ToString() + " تصنيف";
            dataBuyOrderCount.Text = currentSupplier.BuyOrders.Count().ToString() + " عملية";
        }

        private void frmViewSupplier_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditSupplier frm = new frmEditSupplier(currentSupplier);
            frm.Show();
        }
    }
}
