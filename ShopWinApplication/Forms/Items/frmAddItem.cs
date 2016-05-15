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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);
        }

        private void linkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            Form frmItems = OpenForms.GetForm("frmItems");
            if (frmItems != null)
                frmItems.Activate();
            else
            {
                frmItems frm = new frmItems();
                frm.Show();
            }
        }

        private void frmAddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;

            Item item = new Item();
            item.Name = txtName.Text;
            item.Description = txtDescription.Text;            
            item.ItemCategoryID = (long)comboCategories.SelectedValue;
            if ((long)comboLocations.SelectedValue != -1)
                item.LocationID = (long)comboLocations.SelectedValue;
            else
                item.LocationID = null;

            if (chkHasExpire.Checked)
            {
                item.ExpireDate = dateExpire.Value;
                item.ProductionDate = dateProduction.Value;
            }
            item.ReorderLevel = (int)numReorderLevel.Value;
            for (int i = 0; i < dtGridItemUnits.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtGridItemUnits.Rows[i];

                ItemUnit itemUnit = new ItemUnit();
                itemUnit.Item = item;
                itemUnit.UnitID = (long)row.Cells["ItemUnit"].Value;

                ItemQuantity itemQuant = new ItemQuantity();
                itemQuant.ItemUnit = itemUnit;
                itemQuant.Quantity = Double.Parse(row.Cells["Quantity"].Value.ToString());

                ItemPrice itemPrice = new ItemPrice();
                itemPrice.ItemUnit = itemUnit;
                itemPrice.BuyPrice = Decimal.Parse(row.Cells["BuyPrice"].Value.ToString());
                itemPrice.SellPrice = Decimal.Parse(row.Cells["SellPrice"].Value.ToString());

                itemUnit.ItemQuantities.Add(itemQuant);
                itemUnit.ItemPrices.Add(itemPrice);

                item.ItemUnits.Add(itemUnit);                
            }

            DBManagement.GetDB().Items.Add(item);
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للصنف", txtName);
                return false;
            }
            return true;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetDB().Units.ToList();
            itemCategoryBindingSource.DataSource = DBManagement.GetDB().ItemCategories.ToList();
            locationBindingSource.DataSource = DBManagement.GetLocationsForItem();
        }

        private void chkHasExpire_CheckedChanged(object sender, EventArgs e)
        {
            dateExpire.Enabled = chkHasExpire.Checked;
            dateProduction.Enabled = chkHasExpire.Checked;
        }
    }
}
