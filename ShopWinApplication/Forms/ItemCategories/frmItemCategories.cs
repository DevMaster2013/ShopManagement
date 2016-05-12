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
    public partial class frmItemCategories : Form
    {
        public frmItemCategories()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmItemCategories_Load(object sender, EventArgs e)
        {
            itemCategoryBindingSource.DataSource = DBManagement.GetDB().ItemCategories.ToList();
            if (itemCategoryBindingSource.List.Count <= 0)
            {
                dtGridItemCategories.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridItemCategories.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewItemCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddItemCatefory frm = new frmAddItemCatefory();
            frm.Show();
        }

        private void frmItemCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void dtGridItemCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {                
                if (senderGrid.Columns[e.ColumnIndex].Name == "Edit")
                {
                    HandleEditButton(e.RowIndex);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Details")
                {
                    HandleDetailsButton(e.RowIndex);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == "Delete")
                {
                    HandleDeleteButton(e.RowIndex);
                }
            }
        }

        private void HandleEditButton(int rowIndex)
        {
            ItemCategory itCat = itemCategoryBindingSource.List[rowIndex] as ItemCategory;
            frmEditItemCategory frm = new frmEditItemCategory(itCat);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            ItemCategory itCat = itemCategoryBindingSource.List[rowIndex] as ItemCategory;
            frmViewItemCategory frm = new frmViewItemCategory(itCat);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                ItemCategory itCat = itemCategoryBindingSource.List[rowIndex] as ItemCategory;
                DBManagement.GetDB().ItemCategories.Remove(itCat);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    itemCategoryBindingSource.DataSource = DBManagement.GetDB().ItemCategories.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
