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
    public partial class frmViewLocation : Form
    {
        Location currentLocation;

        public frmViewLocation(Location loc)
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

        private void frmViewLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void PopulateFormData()
        {
            txtName.Text = currentLocation.Name;
            txtDescription.Text = currentLocation.Description;
            dataItemCount.Text = currentLocation.Items.Count().ToString() + " صنف";
        }

        private void dataItemCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmViewLocation_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditLocation frm = new frmEditLocation(currentLocation);
            frm.Show();
        }
    }
}
