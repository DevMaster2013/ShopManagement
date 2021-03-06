﻿using ShopWinApplication.Data;
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
    public partial class frmViewItem : Form
    {
        Item currentItem;

        public frmViewItem(Item item)
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

        private void frmViewItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenForms.RemoveForm(this);
        }

        private void PopulateFormData()
        {
            txtName.Text = currentItem.Name;
            txtDescription.Text = currentItem.Description;
            txtItemCategory.Text = currentItem.ItemCategory.Name;
            txtExpire.Text = currentItem.ProductionDate.HasValue? "الصنف له صلاحية" : "الصنف ليس له صلاحية";

            if (currentItem.LocationID.HasValue)
                txtLocation.Text = currentItem.Location.Name;

            if (currentItem.ProductionDate.HasValue)
                dateProduction.Value = currentItem.ProductionDate.Value;
            if (currentItem.ExpireDate.HasValue)
                dateExpire.Value = currentItem.ExpireDate.Value;
            if (currentItem.ReorderLevel.HasValue)
                numReorderLevel.Text = currentItem.ReorderLevel.Value.ToString();
            dtGridItemUnits.Rows.Clear();
            foreach (var it in currentItem.ItemUnits)
            {
                ItemQuantity itQuat = it.ItemQuantities.FirstOrDefault();
                ItemPrice itPrice = it.ItemPrices.FirstOrDefault();
                dtGridItemUnits.Rows.Add(itQuat.Quantity.ToString(), it.UnitID, itPrice.BuyPrice.ToString(), itPrice.SellPrice.ToString());
            }

            int noSellOrders = currentItem.SellOrderItems.GroupBy(x => x.SellOrderID).Count();
            int noBuyOrders = currentItem.BuyOrderItems.GroupBy(x => x.BuyOrderID).Count();

            dataSellOrderCount.Text = noSellOrders.ToString() + " عملية";
            dataBuyOrdersCount.Text = noBuyOrders.ToString() + " عملية";
            var bestSupplier = DBManagement.GetBestItemCategorySupplier(currentItem.ItemCategory);
            if (bestSupplier != null)
            {
                linkBestSupplier.Text = bestSupplier.Name;
                linkBestSupplier.Enabled = true;
            }
            else
            {
                linkBestSupplier.Text = "لا يوجد موردين لهذا الصنف";
                linkBestSupplier.Enabled = false;
            }
        }

        private void frmViewItem_Load(object sender, EventArgs e)
        {
            unitBindingSource.DataSource = DBManagement.GetDB().Units.ToList();

            PopulateFormData();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditItem frm = new frmEditItem(currentItem);
            frm.Show();
        }

        private void dataSellOrderCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataBuyOrdersCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkBestSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
