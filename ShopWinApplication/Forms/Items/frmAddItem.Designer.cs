namespace ShopWinApplication.Forms.Items
{
    partial class frmAddItem
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
            this.grbItemData = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grbItemUnits = new System.Windows.Forms.GroupBox();
            this.dtGridItemUnits = new System.Windows.Forms.DataGridView();
            this.ItemUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.numReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.dateExpire = new System.Windows.Forms.DateTimePicker();
            this.dateProduction = new System.Windows.Forms.DateTimePicker();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.grbItemData.SuspendLayout();
            this.grbItemUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItemUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbItemData
            // 
            this.grbItemData.Controls.Add(this.btnBrowse);
            this.grbItemData.Controls.Add(this.grbItemUnits);
            this.grbItemData.Controls.Add(this.picImage);
            this.grbItemData.Controls.Add(this.numReorderLevel);
            this.grbItemData.Controls.Add(this.dateExpire);
            this.grbItemData.Controls.Add(this.dateProduction);
            this.grbItemData.Controls.Add(this.comboLocations);
            this.grbItemData.Controls.Add(this.comboCategories);
            this.grbItemData.Controls.Add(this.txtDescription);
            this.grbItemData.Controls.Add(this.txtName);
            this.grbItemData.Controls.Add(this.lblDescription);
            this.grbItemData.Controls.Add(this.lblExpireDate);
            this.grbItemData.Controls.Add(this.lblProductionDate);
            this.grbItemData.Controls.Add(this.lblLocation);
            this.grbItemData.Controls.Add(this.lblCategory);
            this.grbItemData.Controls.Add(this.lblReorderLevel);
            this.grbItemData.Controls.Add(this.lblName);
            this.grbItemData.Location = new System.Drawing.Point(12, 13);
            this.grbItemData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemData.Name = "grbItemData";
            this.grbItemData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemData.Size = new System.Drawing.Size(546, 538);
            this.grbItemData.TabIndex = 0;
            this.grbItemData.TabStop = false;
            this.grbItemData.Text = "بيانات الصنف الجديد";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(18, 164);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 29);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "تحميل";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // grbItemUnits
            // 
            this.grbItemUnits.Controls.Add(this.dtGridItemUnits);
            this.grbItemUnits.Location = new System.Drawing.Point(18, 203);
            this.grbItemUnits.Name = "grbItemUnits";
            this.grbItemUnits.Size = new System.Drawing.Size(501, 224);
            this.grbItemUnits.TabIndex = 7;
            this.grbItemUnits.TabStop = false;
            this.grbItemUnits.Text = "وحدات وأسعار الصنف";
            // 
            // dtGridItemUnits
            // 
            this.dtGridItemUnits.AllowUserToOrderColumns = true;
            this.dtGridItemUnits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridItemUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridItemUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItemUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemUnit,
            this.Quantity,
            this.BuyPrice,
            this.SellPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridItemUnits.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridItemUnits.Location = new System.Drawing.Point(6, 23);
            this.dtGridItemUnits.MultiSelect = false;
            this.dtGridItemUnits.Name = "dtGridItemUnits";
            this.dtGridItemUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridItemUnits.Size = new System.Drawing.Size(489, 195);
            this.dtGridItemUnits.TabIndex = 2;
            // 
            // ItemUnit
            // 
            this.ItemUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnit.DataSource = this.unitBindingSource;
            this.ItemUnit.DisplayMember = "Name";
            this.ItemUnit.HeaderText = "الوحدة";
            this.ItemUnit.Name = "ItemUnit";
            this.ItemUnit.ValueMember = "ID";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(ShopWinApplication.Data.Unit);
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // BuyPrice
            // 
            this.BuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BuyPrice.HeaderText = "سعر الشراء";
            this.BuyPrice.Name = "BuyPrice";
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellPrice.HeaderText = "سعر البيع";
            this.SellPrice.Name = "SellPrice";
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(18, 57);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 100);
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.Location = new System.Drawing.Point(265, 143);
            this.numReorderLevel.Name = "numReorderLevel";
            this.numReorderLevel.Size = new System.Drawing.Size(120, 24);
            this.numReorderLevel.TabIndex = 5;
            // 
            // dateExpire
            // 
            this.dateExpire.Location = new System.Drawing.Point(185, 113);
            this.dateExpire.Name = "dateExpire";
            this.dateExpire.Size = new System.Drawing.Size(200, 24);
            this.dateExpire.TabIndex = 4;
            // 
            // dateProduction
            // 
            this.dateProduction.Location = new System.Drawing.Point(185, 83);
            this.dateProduction.Name = "dateProduction";
            this.dateProduction.Size = new System.Drawing.Size(200, 24);
            this.dateProduction.TabIndex = 4;
            // 
            // comboLocations
            // 
            this.comboLocations.DataSource = this.locationBindingSource;
            this.comboLocations.DisplayMember = "Name";
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Location = new System.Drawing.Point(200, 173);
            this.comboLocations.Name = "comboLocations";
            this.comboLocations.Size = new System.Drawing.Size(185, 24);
            this.comboLocations.TabIndex = 3;
            this.comboLocations.ValueMember = "ID";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(ShopWinApplication.Data.Location);
            // 
            // comboCategories
            // 
            this.comboCategories.DataSource = this.itemCategoryBindingSource;
            this.comboCategories.DisplayMember = "Name";
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Location = new System.Drawing.Point(200, 54);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(185, 24);
            this.comboCategories.TabIndex = 3;
            this.comboCategories.ValueMember = "ID";
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(ShopWinApplication.Data.ItemCategory);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 433);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(367, 96);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(368, 24);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(387, 433);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على الصنف:";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Location = new System.Drawing.Point(395, 119);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(127, 17);
            this.lblExpireDate.TabIndex = 0;
            this.lblExpireDate.Text = "تاريخ انتهاء الصلاحية:";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(444, 89);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(78, 17);
            this.lblProductionDate.TabIndex = 0;
            this.lblProductionDate.Text = "تاريخ الإنتاج:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(442, 176);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 17);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "مكان الصنف:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(463, 57);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "التصنيف:";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(417, 145);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(105, 17);
            this.lblReorderLevel.TabIndex = 0;
            this.lblReorderLevel.Text = "أقل كمية ممكنة:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم الصنف:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(395, 558);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(152, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الأصناف";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 604);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbItemData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة صنف جديد";
            this.Activated += new System.EventHandler(this.frmAddItem_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddItem_FormClosed);
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.grbItemData.ResumeLayout(false);
            this.grbItemData.PerformLayout();
            this.grbItemUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItemUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbItemData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.DateTimePicker dateExpire;
        private System.Windows.Forms.DateTimePicker dateProduction;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.NumericUpDown numReorderLevel;
        private System.Windows.Forms.ComboBox comboLocations;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox grbItemUnits;
        private System.Windows.Forms.DataGridView dtGridItemUnits;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemUnit;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.Button btnBrowse;
    }
}