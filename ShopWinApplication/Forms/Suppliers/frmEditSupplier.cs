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
    public partial class frmEditSupplier : Form
    {
        Supplier currentSupplier;

        public frmEditSupplier(Supplier sub)
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

        private void frmEditSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            currentSupplier.Name = txtName.Text;
            currentSupplier.Description = txtDescription.Text;
            currentSupplier.Address = txtAddress.Text;
            currentSupplier.MobileNo = txtTelNo.Text;

            DBManagement.GetDB().ItemCategorySuppliers.RemoveRange(currentSupplier.ItemCategorySuppliers);
            var selectedCategories = itemCategoryForSupplierBindingSource.List;

            foreach (var item in selectedCategories)
            {
                ItemCategoryForSupplier itCat = item as ItemCategoryForSupplier;
                if (itCat.IsSupplied)
                {
                    ItemCategorySupplier itCatSup = new ItemCategorySupplier();
                    itCatSup.Supplier = currentSupplier;
                    itCatSup.ItemCategoryID = itCat.CategoryID;
                    itCatSup.Rate = itCat.Rate;
                    currentSupplier.ItemCategorySuppliers.Add(itCatSup);
                }
            }

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة الموردين؟"))
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للمورد", txtName);
                return false;
            }
            return true;
        }

        private void PopulateFormData()
        {
            itemCategoryForSupplierBindingSource.DataSource = DBManagement.GetItemCategoriesForSuppliers(currentSupplier.ID, true);

            txtName.Text = currentSupplier.Name;
            txtDescription.Text = currentSupplier.Description;
            txtAddress.Text = currentSupplier.Address;
            txtTelNo.Text = currentSupplier.MobileNo;
        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }
    }
}
