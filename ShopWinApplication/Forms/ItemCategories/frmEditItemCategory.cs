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

namespace ShopWinApplication.Forms.ItemCategories
{
    public partial class frmEditItemCategory : Form
    {
        ItemCategory currentItemCategory;

        public frmEditItemCategory(ItemCategory itCat)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentItemCategory = DBManagement.GetDB().ItemCategories.Find(itCat.ID);            
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Form frmCategories = OpenForms.GetForm("frmItemCategories");
            if (frmCategories != null)
                frmCategories.Activate();
            else
            {
                frmItemCategories frm = new frmItemCategories();
                frm.Show();
            }
        }

        private void frmEditItemCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            currentItemCategory.Name = txtName.Text;
            currentItemCategory.Description = txtDescription.Text;

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة التصنيفات؟"))
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للتصنيف", txtName);
                return false;
            }
            return true;
        }

        private void PopulateFormData()
        {
            txtName.Text = currentItemCategory.Name;
            txtDescription.Text = currentItemCategory.Description;
        }

        private void frmEditItemCategory_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }
    }
}
