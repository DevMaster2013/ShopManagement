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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = DBManagement.GetDB().Suppliers.ToList();
            if (supplierBindingSource.List.Count <= 0)
            {
                dtGridSuppliers.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridSuppliers.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddSupplier frm = new frmAddSupplier();
            frm.Show();
        }

        private void frmSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void dtGridLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            Supplier sub = supplierBindingSource.List[rowIndex] as Supplier;
            frmEditSupplier frm = new frmEditSupplier(sub);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            Supplier sub = supplierBindingSource.List[rowIndex] as Supplier;
            frmViewSupplier frm = new frmViewSupplier(sub);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                Supplier sub = supplierBindingSource.List[rowIndex] as Supplier;
                DBManagement.GetDB().ItemCategorySuppliers.RemoveRange(sub.ItemCategorySuppliers);
                DBManagement.GetDB().Suppliers.Remove(sub);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    supplierBindingSource.DataSource = DBManagement.GetDB().Suppliers.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
