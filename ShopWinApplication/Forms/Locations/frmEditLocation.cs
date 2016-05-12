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
    public partial class frmEditLocation : Form
    {
        Location currentLocation;

        public frmEditLocation(Location loc)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentLocation = DBManagement.GetDB().Locations.Find(loc.ID);            
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

        private void frmEditLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            currentLocation.Name = txtName.Text;
            currentLocation.Description = txtDescription.Text;

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة الأماكن؟"))
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للمكان", txtName);
                return false;
            }
            return true;
        }

        private void PopulateFormData()
        {
            txtName.Text = currentLocation.Name;
            txtDescription.Text = currentLocation.Description;
        }

        private void frmEditLocation_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }
    }
}
