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
    public partial class frmViewItemCategory : Form
    {
        ItemCategory currentItemCategory;

        public frmViewItemCategory(ItemCategory itCat)
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

        private void frmViewItemCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void PopulateFormData()
        {
            txtName.Text = currentItemCategory.Name;
            txtDescription.Text = currentItemCategory.Description;
            dataItemCount.Text = currentItemCategory.Items.Count().ToString() + " صنف";
            dataSuppliersCount.Text = currentItemCategory.ItemCategorySuppliers.Count().ToString() + " مورد";

            var bestSupplier = DBManagement.GetBestItemCategorySupplier(currentItemCategory);
            if (bestSupplier != null)
            {
                linkBestSupplier.Text = bestSupplier.Name;
                linkBestSupplier.Enabled = true;
            }
            else
            {
                linkBestSupplier.Text = "لا يوجد موردين لهذا التصنيف";
                linkBestSupplier.Enabled = false;
            }
        }

        private void dataItemCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataSuppliersCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmViewItemCategory_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditItemCategory frm = new frmEditItemCategory(currentItemCategory);
            frm.Show();
        }

        private void linkBestSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
