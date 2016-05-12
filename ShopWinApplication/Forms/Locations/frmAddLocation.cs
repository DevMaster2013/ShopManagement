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
    public partial class frmAddLocation : Form
    {
        public frmAddLocation()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Form frmLocations = OpenForms.GetForm("frmLocations");
            if (frmLocations != null)
                frmLocations.Activate();
            else
            {
                frmLocations frm = new frmLocations();
                frm.Show();
            }
        }

        private void frmAddLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            Location loc = new Location();
            loc.Name = txtName.Text;
            loc.Description = txtDescription.Text;
            DBManagement.GetDB().Locations.Add(loc);

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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للمكان", txtName);
                return false;
            }
            return true;
        }
    }
}
