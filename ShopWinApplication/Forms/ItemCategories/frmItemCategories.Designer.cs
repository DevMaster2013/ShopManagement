namespace ShopWinApplication.Forms.ItemCategories
{
    partial class frmItemCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dtGridItemCategories = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkAddNewItemCategory = new System.Windows.Forms.LinkLabel();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItemCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(14, 11);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(309, 17);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "هذه هى قائمة التصنيفات الموجودة فى المحل";
            // 
            // dtGridItemCategories
            // 
            this.dtGridItemCategories.AllowUserToAddRows = false;
            this.dtGridItemCategories.AllowUserToDeleteRows = false;
            this.dtGridItemCategories.AutoGenerateColumns = false;
            this.dtGridItemCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridItemCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridItemCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItemCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Edit,
            this.Details,
            this.Delete});
            this.dtGridItemCategories.DataSource = this.itemCategoryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridItemCategories.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridItemCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridItemCategories.Location = new System.Drawing.Point(17, 63);
            this.dtGridItemCategories.MultiSelect = false;
            this.dtGridItemCategories.Name = "dtGridItemCategories";
            this.dtGridItemCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridItemCategories.Size = new System.Drawing.Size(829, 258);
            this.dtGridItemCategories.TabIndex = 1;
            this.dtGridItemCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridItemCategories_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "اسم التصنيف";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "ملاحظات على التصنيف";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "تعديل";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FillWeight = 10F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Details
            // 
            dataGridViewCellStyle2.NullValue = "عرض";
            this.Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.Details.HeaderText = "";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.NullValue = "مسح";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(ShopWinApplication.Data.ItemCategory);
            // 
            // linkAddNewItemCategory
            // 
            this.linkAddNewItemCategory.AutoSize = true;
            this.linkAddNewItemCategory.Location = new System.Drawing.Point(14, 36);
            this.linkAddNewItemCategory.Name = "linkAddNewItemCategory";
            this.linkAddNewItemCategory.Size = new System.Drawing.Size(115, 17);
            this.linkAddNewItemCategory.TabIndex = 2;
            this.linkAddNewItemCategory.TabStop = true;
            this.linkAddNewItemCategory.Text = "إضافة تصنيف جديد";
            this.linkAddNewItemCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddNewItemCategory_LinkClicked);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(149, 36);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(415, 17);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "لا توجد تصنيفات الآن فى المحل ، قم بإضافة تصنيفات جديدة لعرضها هنا";
            this.lblError.Visible = false;
            // 
            // frmItemCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 334);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.linkAddNewItemCategory);
            this.Controls.Add(this.dtGridItemCategories);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmItemCategories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قائمة التصنيفات الموجودة بالمحل";
            this.Activated += new System.EventHandler(this.frmItemCategories_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmItemCategories_FormClosed);
            this.Load += new System.EventHandler(this.frmItemCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItemCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dtGridItemCategories;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.LinkLabel linkAddNewItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Label lblError;
    }
}