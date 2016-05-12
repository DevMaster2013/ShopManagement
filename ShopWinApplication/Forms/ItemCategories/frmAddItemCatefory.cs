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
    public partial class frmAddItemCatefory : Form
    {
        public frmAddItemCatefory()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
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

        private void frmAddItemCatefory_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            ItemCategory itCat = new ItemCategory();
            itCat.Name = txtName.Text;
            itCat.Description = txtDescription.Text;
            DBManagement.GetDB().ItemCategories.Add(itCat);

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                MessageManager.SaveDataSuccessMessage("لقد تم حفظ البيانات بنجاح");                
                txtName.Text = txtDescription.Text = "";
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للتصنيف", txtName);
                return false;
            }
            return true;
        }
    }
}
