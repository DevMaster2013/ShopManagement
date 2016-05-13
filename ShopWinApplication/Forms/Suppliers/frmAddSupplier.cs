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

namespace ShopWinApplication.Forms.Suppliers
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
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

        private void frmAddSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            Supplier sub = new Supplier();
            sub.Name = txtName.Text;
            sub.Description = txtDescription.Text;
            sub.Address = txtAddress.Text;
            sub.MobileNo = txtTelNo.Text;

            var selectedCategories = itemCategoryForSupplierBindingSource.List;
            foreach (var item in selectedCategories)
            {
                ItemCategoryForSupplier itCat = item as ItemCategoryForSupplier;
                if (itCat.IsSupplied)
                {
                    ItemCategorySupplier itCatSup = new ItemCategorySupplier();
                    itCatSup.Supplier = sub;
                    itCatSup.ItemCategoryID = itCat.CategoryID;
                    itCatSup.Rate = itCat.Rate;
                    sub.ItemCategorySuppliers.Add(itCatSup);
                }
            }
            DBManagement.GetDB().Suppliers.Add(sub);

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                MessageManager.SaveDataSuccessMessage("لقد تم حفظ البيانات بنجاح");                
                txtName.Text = txtDescription.Text = "";
                txtAddress.Text = txtTelNo.Text = "";
                itemCategoryForSupplierBindingSource.DataSource = DBManagement.GetItemCategoriesForSuppliers(-1);
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للمورد", txtName);
                return false;
            }
            return true;
        }

        private void grbSupplierData_Enter(object sender, EventArgs e)
        {
            itemCategoryForSupplierBindingSource.DataSource = DBManagement.GetItemCategoriesForSuppliers(-1);
        }
    }
}
