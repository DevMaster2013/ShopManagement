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
    public partial class frmAddUnit : Form
    {
        public frmAddUnit()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
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

        private void frmAddUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            Unit unit = new Unit();
            unit.Name = txtName.Text;
            unit.Description = txtDescription.Text;
            if ((long)comboBaseUnit.SelectedValue != -1)
            {
                unit.BaseUnitID = comboBaseUnit.SelectedValue as long?;
                unit.Multiplier = (int)numMultiplier.Value;
            }
            else
            {
                unit.BaseUnitID = null;
                unit.Multiplier = null;
            }

            DBManagement.GetDB().Units.Add(unit);

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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للوحدة", txtName);
                return false;
            }
            return true;
        }

        private void frmAddUnit_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetBaseUnitsExcept(-1);
            comboBaseUnit_SelectedIndexChanged(comboBaseUnit, null);
        }

        private void comboBaseUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMultiplier.Enabled = (comboBaseUnit.SelectedValue != null) && (long)comboBaseUnit.SelectedValue != -1;
        }
    }
}
