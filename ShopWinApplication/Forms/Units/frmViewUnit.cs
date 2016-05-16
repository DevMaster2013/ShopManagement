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
    public partial class frmViewUnit : Form
    {
        Unit currentUnit;

        public frmViewUnit(Unit unit)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentUnit = DBManagement.GetDB().Units.Find(unit.ID);            
        }

        private void PopulateFormData()
        {
            if (currentUnit.BaseUnit != null)
            {
                txtBaseUnit.Text = currentUnit.BaseUnit.Name;
                txtMultiplier.Text = currentUnit.Multiplier.Value.ToString();
            }
            else
            {
                txtBaseUnit.Text = "";
                txtMultiplier.Text = "";
            }

            txtName.Text = currentUnit.Name;
            txtDescription.Text = currentUnit.Description;
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Form frmUnits = OpenForms.GetForm("frmUnits");
            if (frmUnits != null)
                frmUnits.Activate();
            else
            {
                frmUnits frm = new frmUnits();
                frm.Show();
            }
        }

        private void frmViewUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void frmViewUnit_Load(object sender, EventArgs e)
        {
            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditUnit frm = new frmEditUnit(currentUnit);
            frm.Show();
        }
    }
}
