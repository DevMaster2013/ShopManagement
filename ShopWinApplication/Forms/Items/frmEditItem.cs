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
    public partial class frmEditItem : Form
    {
        Item currentItem;

        public frmEditItem(Item item)
        {
            InitializeComponent();
            OpenForms.AddOpenedForm(this);

            currentItem = DBManagement.GetDB().Items.Find(item.ID);
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

            currentItem.Name = txtName.Text;
            currentItem.Description = txtDescription.Text;            
            currentItem.ItemCategoryID = (long)comboCategories.SelectedValue;
            if ((long)comboLocations.SelectedValue != -1)
                currentItem.LocationID = (long)comboLocations.SelectedValue;
            else
                currentItem.LocationID = null;

            if (chkHasExpire.Checked)
            {
                currentItem.ExpireDate = dateExpire.Value;
                currentItem.ProductionDate = dateProduction.Value;
            }
            else
            {
                currentItem.ExpireDate = null;
                currentItem.ProductionDate = null;
            }

            currentItem.ReorderLevel = (int)numReorderLevel.Value;
            
            foreach (var it in currentItem.ItemUnits)
            {
                DBManagement.GetDB().ItemPrices.RemoveRange(it.ItemPrices);
                DBManagement.GetDB().ItemQuantities.RemoveRange(it.ItemQuantities);
            }
            DBManagement.GetDB().ItemUnits.RemoveRange(currentItem.ItemUnits);
            
            for (int i = 0; i < dtGridItemUnits.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtGridItemUnits.Rows[i];

                ItemUnit itemUnit = new ItemUnit();
                itemUnit.Item = currentItem;
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

                currentItem.ItemUnits.Add(itemUnit);                
            }

            if (DBManagement.GetDB().SaveChanges() > 0)
            {
                if (MessageManager.YesNoMessage("لقد تم حفظ البيانات بنجاح ، هل تريد الرجوع لقائمة الأصناف؟"))
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
                MessageManager.ValidationMessage("يجب إدخال اسم معرف للصنف", txtName);
                return false;
            }
            return true;
        }

        private void PopulateFormData()
        {
            txtName.Text = currentItem.Name;
            txtDescription.Text = currentItem.Description;
            comboCategories.SelectedValue = currentItem.ItemCategoryID;
            chkHasExpire.Checked = currentItem.ProductionDate.HasValue;

            if (currentItem.LocationID.HasValue)
                comboLocations.SelectedValue = currentItem.LocationID;

            if (currentItem.ProductionDate.HasValue)
                dateProduction.Value = currentItem.ProductionDate.Value;
            if (currentItem.ExpireDate.HasValue)
                dateExpire.Value = currentItem.ExpireDate.Value;
            if (currentItem.ReorderLevel.HasValue)
                numReorderLevel.Value = (decimal)currentItem.ReorderLevel.Value;
            dtGridItemUnits.Rows.Clear();
            foreach (var it in currentItem.ItemUnits)
            {
                ItemQuantity itQuat = it.ItemQuantities.FirstOrDefault();
                ItemPrice itPrice = it.ItemPrices.FirstOrDefault();
                dtGridItemUnits.Rows.Add(itQuat.Quantity.ToString(), it.UnitID, itPrice.BuyPrice.ToString(), itPrice.SellPrice.ToString());
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetDB().Units.ToList();
            itemCategoryBindingSource.DataSource = DBManagement.GetDB().ItemCategories.ToList();
            locationBindingSource.DataSource = DBManagement.GetLocationsForItem();

            PopulateFormData();
        }

        private void chkHasExpire_CheckedChanged(object sender, EventArgs e)
        {
            dateExpire.Enabled = chkHasExpire.Checked;
            dateProduction.Enabled = chkHasExpire.Checked;
        }
    }
}
