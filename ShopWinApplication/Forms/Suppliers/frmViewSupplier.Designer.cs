﻿namespace ShopWinApplication.Forms.Suppliers
{
    partial class frmViewSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbSupplierData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridSuppliers = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryForSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataDebitTotal = new System.Windows.Forms.LinkLabel();
            this.dataBuyOrderCount = new System.Windows.Forms.LinkLabel();
            this.dataItemCategoryCount = new System.Windows.Forms.LinkLabel();
            this.lblDebitTotal = new System.Windows.Forms.Label();
            this.lblNoOfBuyOrder = new System.Windows.Forms.Label();
            this.lblNoOfItemCategories = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.grbSupplierData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryForSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSupplierData
            // 
            this.grbSupplierData.Controls.Add(this.label1);
            this.grbSupplierData.Controls.Add(this.dtGridSuppliers);
            this.grbSupplierData.Controls.Add(this.txtTelNo);
            this.grbSupplierData.Controls.Add(this.txtAddress);
            this.grbSupplierData.Controls.Add(this.lblTelNo);
            this.grbSupplierData.Controls.Add(this.lblAddress);
            this.grbSupplierData.Controls.Add(this.dataDebitTotal);
            this.grbSupplierData.Controls.Add(this.dataBuyOrderCount);
            this.grbSupplierData.Controls.Add(this.dataItemCategoryCount);
            this.grbSupplierData.Controls.Add(this.lblDebitTotal);
            this.grbSupplierData.Controls.Add(this.lblNoOfBuyOrder);
            this.grbSupplierData.Controls.Add(this.lblNoOfItemCategories);
            this.grbSupplierData.Controls.Add(this.txtDescription);
            this.grbSupplierData.Controls.Add(this.txtName);
            this.grbSupplierData.Controls.Add(this.lblDescription);
            this.grbSupplierData.Controls.Add(this.lblName);
            this.grbSupplierData.Location = new System.Drawing.Point(12, 13);
            this.grbSupplierData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSupplierData.Name = "grbSupplierData";
            this.grbSupplierData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSupplierData.Size = new System.Drawing.Size(546, 456);
            this.grbSupplierData.TabIndex = 0;
            this.grbSupplierData.TabStop = false;
            this.grbSupplierData.Text = "بيانات المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "التصنيفات التى يوردها المورد للمحل:";
            // 
            // dtGridSuppliers
            // 
            this.dtGridSuppliers.AllowUserToAddRows = false;
            this.dtGridSuppliers.AllowUserToDeleteRows = false;
            this.dtGridSuppliers.AutoGenerateColumns = false;
            this.dtGridSuppliers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dtGridSuppliers.DataSource = this.itemCategoryForSupplierBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridSuppliers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridSuppliers.Location = new System.Drawing.Point(18, 223);
            this.dtGridSuppliers.MultiSelect = false;
            this.dtGridSuppliers.Name = "dtGridSuppliers";
            this.dtGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridSuppliers.Size = new System.Drawing.Size(499, 146);
            this.dtGridSuppliers.TabIndex = 14;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.FillWeight = 60F;
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "اسم التصنيف";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.FillWeight = 20F;
            this.rateDataGridViewTextBoxColumn.HeaderText = "التقييم";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // itemCategoryForSupplierBindingSource
            // 
            this.itemCategoryForSupplierBindingSource.DataSource = typeof(ShopWinApplication.Data.ViewModels.ItemCategoryForSupplier);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(201, 77);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.ReadOnly = true;
            this.txtTelNo.Size = new System.Drawing.Size(184, 24);
            this.txtTelNo.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(368, 24);
            this.txtAddress.TabIndex = 12;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(438, 80);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(82, 17);
            this.lblTelNo.TabIndex = 9;
            this.lblTelNo.Text = "رقم التليفون:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(438, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "عنوان المورد:";
            // 
            // dataDebitTotal
            // 
            this.dataDebitTotal.Location = new System.Drawing.Point(99, 427);
            this.dataDebitTotal.Name = "dataDebitTotal";
            this.dataDebitTotal.Size = new System.Drawing.Size(211, 17);
            this.dataDebitTotal.TabIndex = 8;
            this.dataDebitTotal.TabStop = true;
            this.dataDebitTotal.Text = "0.0 جنيه مصرى";
            this.dataDebitTotal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataDebitTotal_LinkClicked);
            // 
            // dataBuyOrderCount
            // 
            this.dataBuyOrderCount.Location = new System.Drawing.Point(99, 400);
            this.dataBuyOrderCount.Name = "dataBuyOrderCount";
            this.dataBuyOrderCount.Size = new System.Drawing.Size(211, 17);
            this.dataBuyOrderCount.TabIndex = 8;
            this.dataBuyOrderCount.TabStop = true;
            this.dataBuyOrderCount.Text = "0 عملية";
            this.dataBuyOrderCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataBuyOrderCount_LinkClicked);
            // 
            // dataItemCategoryCount
            // 
            this.dataItemCategoryCount.Location = new System.Drawing.Point(115, 372);
            this.dataItemCategoryCount.Name = "dataItemCategoryCount";
            this.dataItemCategoryCount.Size = new System.Drawing.Size(195, 17);
            this.dataItemCategoryCount.TabIndex = 8;
            this.dataItemCategoryCount.TabStop = true;
            this.dataItemCategoryCount.Text = "0 تصنيف";
            this.dataItemCategoryCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataItemCategoryCount_LinkClicked);
            // 
            // lblDebitTotal
            // 
            this.lblDebitTotal.AutoSize = true;
            this.lblDebitTotal.Location = new System.Drawing.Point(359, 427);
            this.lblDebitTotal.Name = "lblDebitTotal";
            this.lblDebitTotal.Size = new System.Drawing.Size(157, 17);
            this.lblDebitTotal.TabIndex = 6;
            this.lblDebitTotal.Text = "إجمالى مستحقات المورد:";
            // 
            // lblNoOfBuyOrder
            // 
            this.lblNoOfBuyOrder.AutoSize = true;
            this.lblNoOfBuyOrder.Location = new System.Drawing.Point(337, 400);
            this.lblNoOfBuyOrder.Name = "lblNoOfBuyOrder";
            this.lblNoOfBuyOrder.Size = new System.Drawing.Size(179, 17);
            this.lblNoOfBuyOrder.TabIndex = 6;
            this.lblNoOfBuyOrder.Text = "عمليات الشراء من هذا المورد:";
            // 
            // lblNoOfItemCategories
            // 
            this.lblNoOfItemCategories.AutoSize = true;
            this.lblNoOfItemCategories.Location = new System.Drawing.Point(321, 372);
            this.lblNoOfItemCategories.Name = "lblNoOfItemCategories";
            this.lblNoOfItemCategories.Size = new System.Drawing.Size(199, 17);
            this.lblNoOfItemCategories.TabIndex = 6;
            this.lblNoOfItemCategories.Text = "التصنيفات التى يوردها هذا المورد:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(367, 96);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 25);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(368, 24);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(387, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على المورد:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم المورد:";
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(383, 473);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(157, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الموردين";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(9, 473);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(41, 17);
            this.linkEdit.TabIndex = 3;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "تعديل";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // frmViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 499);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.grbSupplierData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض بيانات المورد";
            this.Activated += new System.EventHandler(this.frmViewSupplier_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewSupplier_FormClosed);
            this.Load += new System.EventHandler(this.frmViewSupplier_Load);
            this.grbSupplierData.ResumeLayout(false);
            this.grbSupplierData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryForSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSupplierData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.LinkLabel dataItemCategoryCount;
        private System.Windows.Forms.Label lblNoOfItemCategories;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.LinkLabel dataBuyOrderCount;
        private System.Windows.Forms.Label lblNoOfBuyOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridSuppliers;
        private System.Windows.Forms.BindingSource itemCategoryForSupplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkEdit;
        private System.Windows.Forms.LinkLabel dataDebitTotal;
        private System.Windows.Forms.Label lblDebitTotal;
    }
}