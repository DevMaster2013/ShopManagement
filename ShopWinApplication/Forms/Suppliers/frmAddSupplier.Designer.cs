namespace ShopWinApplication.Forms.Suppliers
{
    partial class frmAddSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbSupplierData = new System.Windows.Forms.GroupBox();
            this.dtGridSuppliers = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSuppliedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryForSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.grbSupplierData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryForSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSupplierData
            // 
            this.grbSupplierData.Controls.Add(this.dtGridSuppliers);
            this.grbSupplierData.Controls.Add(this.txtDescription);
            this.grbSupplierData.Controls.Add(this.txtTelNo);
            this.grbSupplierData.Controls.Add(this.txtAddress);
            this.grbSupplierData.Controls.Add(this.txtName);
            this.grbSupplierData.Controls.Add(this.label1);
            this.grbSupplierData.Controls.Add(this.lblDescription);
            this.grbSupplierData.Controls.Add(this.lblTelNo);
            this.grbSupplierData.Controls.Add(this.lblAddress);
            this.grbSupplierData.Controls.Add(this.lblName);
            this.grbSupplierData.Location = new System.Drawing.Point(12, 13);
            this.grbSupplierData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSupplierData.Name = "grbSupplierData";
            this.grbSupplierData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSupplierData.Size = new System.Drawing.Size(546, 376);
            this.grbSupplierData.TabIndex = 0;
            this.grbSupplierData.TabStop = false;
            this.grbSupplierData.Text = "بيانات المورد الجديد";
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
            this.isSuppliedDataGridViewCheckBoxColumn,
            this.Rate});
            this.dtGridSuppliers.DataSource = this.itemCategoryForSupplierBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridSuppliers.Location = new System.Drawing.Point(18, 223);
            this.dtGridSuppliers.MultiSelect = false;
            this.dtGridSuppliers.Name = "dtGridSuppliers";
            this.dtGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridSuppliers.Size = new System.Drawing.Size(499, 146);
            this.dtGridSuppliers.TabIndex = 3;
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
            // isSuppliedDataGridViewCheckBoxColumn
            // 
            this.isSuppliedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isSuppliedDataGridViewCheckBoxColumn.DataPropertyName = "IsSupplied";
            this.isSuppliedDataGridViewCheckBoxColumn.FillWeight = 20F;
            this.isSuppliedDataGridViewCheckBoxColumn.HeaderText = "هل يورد؟";
            this.isSuppliedDataGridViewCheckBoxColumn.Name = "isSuppliedDataGridViewCheckBoxColumn";
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.DataPropertyName = "Rate";
            this.Rate.FillWeight = 20F;
            this.Rate.HeaderText = "التقييم";
            this.Rate.Name = "Rate";
            this.Rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemCategoryForSupplierBindingSource
            // 
            this.itemCategoryForSupplierBindingSource.DataSource = typeof(ShopWinApplication.Data.ViewModels.ItemCategoryForSupplier);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(367, 96);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(201, 77);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(184, 24);
            this.txtTelNo.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(368, 24);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(368, 24);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "التصنيفات التى يوردها المورد للمحل:";
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
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(438, 80);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(82, 17);
            this.lblTelNo.TabIndex = 0;
            this.lblTelNo.Text = "رقم التليفون:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(438, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "عنوان المورد:";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 396);
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
            this.linkReturn.Location = new System.Drawing.Point(395, 396);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(157, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الموردين";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 442);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbSupplierData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddSupplier";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة مورد جديد";
            this.Activated += new System.EventHandler(this.frmAddSupplier_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddSupplier_FormClosed);
            this.Load += new System.EventHandler(this.frmAddSupplier_Load);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridSuppliers;
        private System.Windows.Forms.BindingSource itemCategoryForSupplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSuppliedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}