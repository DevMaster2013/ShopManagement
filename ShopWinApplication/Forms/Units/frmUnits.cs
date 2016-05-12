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

namespace ShopWinApplication.Forms.Units
{
    public partial class frmUnits : Form
    {
        public frmUnits()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetDB().Units.ToList();
            if (unitBindingSource.List.Count <= 0)
            {
                dtGridUnits.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridUnits.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewUnit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUnit frm = new frmAddUnit();
            frm.Show();
        }

        private void frmUnits_FormClosed(object sender, FormClosedEventArgs e)
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
            Unit unit = unitBindingSource.List[rowIndex] as Unit;
            frmEditUnit frm = new frmEditUnit(unit);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            Unit unit = unitBindingSource.List[rowIndex] as Unit;
            frmViewUnit frm = new frmViewUnit(unit);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                Unit unit = unitBindingSource.List[rowIndex] as Unit;
                DBManagement.GetDB().Units.Remove(unit);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    unitBindingSource.DataSource = DBManagement.GetDB().Units.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
