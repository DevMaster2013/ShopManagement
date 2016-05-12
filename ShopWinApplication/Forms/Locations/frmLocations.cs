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

namespace ShopWinApplication.Forms.Locations
{
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            locationBindingSource.DataSource = DBManagement.GetDB().Locations.ToList();
            if (locationBindingSource.List.Count <= 0)
            {
                dtGridLocations.Visible = false;
                lblError.Visible = true;
            }
            else
            {
                dtGridLocations.Visible = true;
                lblError.Visible = false;
            }
        }

        private void linkAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddLocation frm = new frmAddLocation();
            frm.Show();
        }

        private void frmLocations_FormClosed(object sender, FormClosedEventArgs e)
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
            Location loc = locationBindingSource.List[rowIndex] as Location;
            frmEditLocation frm = new frmEditLocation(loc);
            frm.Show();
        }

        private void HandleDetailsButton(int rowIndex)
        {
            Location loc = locationBindingSource.List[rowIndex] as Location;
            frmViewLocation frm = new frmViewLocation(loc);
            frm.Show();
        }

        private void HandleDeleteButton(int rowIndex)
        {
            if (MessageManager.YesNoMessage("هل تريد مسح هذا السجل؟"))
            {
                Location loc = locationBindingSource.List[rowIndex] as Location;
                DBManagement.GetDB().Locations.Remove(loc);
                if (DBManagement.GetDB().SaveChanges() > 0)
                {
                    MessageManager.SaveDataSuccessMessage("لقد تم مسح البيانات بنجاح");
                    locationBindingSource.DataSource = DBManagement.GetDB().Locations.ToList();
                }
                else
                    MessageManager.SaveDataFailureMessage("لم يتم مسح البانات");
            }
        }
    }
}
