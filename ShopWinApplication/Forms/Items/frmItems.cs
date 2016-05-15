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

namespace ShopWinApplication.Forms.Items
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = DBManagement.GetDB().Items.ToList();
            if (itemBindingSource.List.Count <= 0)
            {
                dtGridItems.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridItems.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddItem frm = new frmAddItem();
            frm.Show();
        }

        private void frmItems_FormClosed(object sender, FormClosedEventArgs e)
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
            Item item = itemBindingSource.List[rowIndex] as Item;
            frmEditItem frm = new frmEditItem(item);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            Item item = itemBindingSource.List[rowIndex] as Item;
            frmViewItem frm = new frmViewItem(item);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                Item item = itemBindingSource.List[rowIndex] as Item;

                foreach (var it in item.ItemUnits)
                {
                    DBManagement.GetDB().ItemPrices.RemoveRange(it.ItemPrices);
                    DBManagement.GetDB().ItemQuantities.RemoveRange(it.ItemQuantities);
                }

                DBManagement.GetDB().ItemUnits.RemoveRange(item.ItemUnits);
                DBManagement.GetDB().Items.Remove(item);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    itemBindingSource.DataSource = DBManagement.GetDB().Items.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
