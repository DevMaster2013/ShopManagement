namespace ShopWinApplication.Forms.ItemCategories
{
    partial class frmViewItemCategory
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
            this.grbItemCategoryData = new System.Windows.Forms.GroupBox();
            this.dataSuppliersCount = new System.Windows.Forms.LinkLabel();
            this.dataItemCount = new System.Windows.Forms.LinkLabel();
            this.lblNoOfSuppliers = new System.Windows.Forms.Label();
            this.lblNoOfItems = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.lblBestSupplier = new System.Windows.Forms.Label();
            this.linkBestSupplier = new System.Windows.Forms.LinkLabel();
            this.grbItemCategoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbItemCategoryData
            // 
            this.grbItemCategoryData.Controls.Add(this.linkBestSupplier);
            this.grbItemCategoryData.Controls.Add(this.dataSuppliersCount);
            this.grbItemCategoryData.Controls.Add(this.dataItemCount);
            this.grbItemCategoryData.Controls.Add(this.lblBestSupplier);
            this.grbItemCategoryData.Controls.Add(this.lblNoOfSuppliers);
            this.grbItemCategoryData.Controls.Add(this.lblNoOfItems);
            this.grbItemCategoryData.Controls.Add(this.txtDescription);
            this.grbItemCategoryData.Controls.Add(this.txtName);
            this.grbItemCategoryData.Controls.Add(this.lblDescription);
            this.grbItemCategoryData.Controls.Add(this.lblName);
            this.grbItemCategoryData.Location = new System.Drawing.Point(12, 13);
            this.grbItemCategoryData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemCategoryData.Name = "grbItemCategoryData";
            this.grbItemCategoryData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemCategoryData.Size = new System.Drawing.Size(546, 268);
            this.grbItemCategoryData.TabIndex = 0;
            this.grbItemCategoryData.TabStop = false;
            this.grbItemCategoryData.Text = "بيانات التصنيف";
            // 
            // dataSuppliersCount
            // 
            this.dataSuppliersCount.Location = new System.Drawing.Point(177, 193);
            this.dataSuppliersCount.Name = "dataSuppliersCount";
            this.dataSuppliersCount.Size = new System.Drawing.Size(165, 17);
            this.dataSuppliersCount.TabIndex = 7;
            this.dataSuppliersCount.TabStop = true;
            this.dataSuppliersCount.Text = "0 مورد";
            this.dataSuppliersCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataSuppliersCount_LinkClicked);
            // 
            // dataItemCount
            // 
            this.dataItemCount.Location = new System.Drawing.Point(177, 162);
            this.dataItemCount.Name = "dataItemCount";
            this.dataItemCount.Size = new System.Drawing.Size(169, 17);
            this.dataItemCount.TabIndex = 8;
            this.dataItemCount.TabStop = true;
            this.dataItemCount.Text = "0 صنف";
            this.dataItemCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataItemCount_LinkClicked);
            // 
            // lblNoOfSuppliers
            // 
            this.lblNoOfSuppliers.AutoSize = true;
            this.lblNoOfSuppliers.Location = new System.Drawing.Point(405, 193);
            this.lblNoOfSuppliers.Name = "lblNoOfSuppliers";
            this.lblNoOfSuppliers.Size = new System.Drawing.Size(127, 17);
            this.lblNoOfSuppliers.TabIndex = 5;
            this.lblNoOfSuppliers.Text = "موردين هذا التصنيف:";
            // 
            // lblNoOfItems
            // 
            this.lblNoOfItems.AutoSize = true;
            this.lblNoOfItems.Location = new System.Drawing.Point(369, 162);
            this.lblNoOfItems.Name = "lblNoOfItems";
            this.lblNoOfItems.Size = new System.Drawing.Size(163, 17);
            this.lblNoOfItems.TabIndex = 6;
            this.lblNoOfItems.Text = "الأصناف الموجودةبالتصنيف:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 51);
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
            this.lblDescription.Location = new System.Drawing.Point(387, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على التصنيف:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم التصنيف:";
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(392, 285);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(163, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة التصنيفات";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(9, 285);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(41, 17);
            this.linkEdit.TabIndex = 2;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "تعديل";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // lblBestSupplier
            // 
            this.lblBestSupplier.AutoSize = true;
            this.lblBestSupplier.Location = new System.Drawing.Point(383, 225);
            this.lblBestSupplier.Name = "lblBestSupplier";
            this.lblBestSupplier.Size = new System.Drawing.Size(149, 17);
            this.lblBestSupplier.TabIndex = 5;
            this.lblBestSupplier.Text = "أفضل مورد لهذا التصنيف:";
            // 
            // linkBestSupplier
            // 
            this.linkBestSupplier.Location = new System.Drawing.Point(139, 225);
            this.linkBestSupplier.Name = "linkBestSupplier";
            this.linkBestSupplier.Size = new System.Drawing.Size(203, 17);
            this.linkBestSupplier.TabIndex = 7;
            this.linkBestSupplier.TabStop = true;
            this.linkBestSupplier.Text = "لا يوجد موردين لهذا التصنيف";
            this.linkBestSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBestSupplier_LinkClicked);
            // 
            // frmViewItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 311);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.grbItemCategoryData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewItemCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض بيانات التصنيف";
            this.Activated += new System.EventHandler(this.frmViewItemCategory_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewItemCategory_FormClosed);
            this.Load += new System.EventHandler(this.frmViewItemCategory_Load);
            this.grbItemCategoryData.ResumeLayout(false);
            this.grbItemCategoryData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbItemCategoryData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.LinkLabel dataSuppliersCount;
        private System.Windows.Forms.LinkLabel dataItemCount;
        private System.Windows.Forms.Label lblNoOfSuppliers;
        private System.Windows.Forms.Label lblNoOfItems;
        private System.Windows.Forms.LinkLabel linkEdit;
        private System.Windows.Forms.LinkLabel linkBestSupplier;
        private System.Windows.Forms.Label lblBestSupplier;
    }
}