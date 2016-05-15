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
    public partial class frmEditUnit : Form
    {
        Unit currentUnit;

        public frmEditUnit(Unit unit)
        {
            InitializeComponent();           
            OpenForms.AddOpenedForm(this);

            currentUnit = DBManagement.GetDB().Units.Find(unit.ID);            
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

        private void frmEditUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            currentUnit.Name = txtName.Text;
            currentUnit.Description = txtDescription.Text;
            if ((long)comboBaseUnit.SelectedValue != -1)
            {
                currentUnit.BaseUnitID = comboBaseUnit.SelectedValue as long?;
                currentUnit.Multiplier = (int)numMultiplier.Value;
            }
            else
            {
                currentUnit.BaseUnitID = null;
                currentUnit.Multiplier = null;
            }

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة الوحدات؟"))
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للوحدة", txtName);
                return false;
            }
            return true;
        }

        private void PopulateFormData()
        {
            txtName.Text = currentUnit.Name;
            txtDescription.Text = currentUnit.Description;
            if (currentUnit.BaseUnitID.HasValue)
            {
                comboBaseUnit.SelectedValue = currentUnit.BaseUnitID;
                numMultiplier.Value = currentUnit.Multiplier.Value;
            }
            else
            {
                numMultiplier.Enabled = false;
            }
        }

        private void frmEditUnit_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetBaseUnitsExcept(currentUnit.ID);
            PopulateFormData();
        }

        private void comboBaseUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMultiplier.Enabled = (comboBaseUnit.SelectedValue != null) && (long)comboBaseUnit.SelectedValue != -1;
        }
    }
}
