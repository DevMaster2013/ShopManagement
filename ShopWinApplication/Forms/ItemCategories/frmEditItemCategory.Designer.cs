namespace ShopWinApplication.Forms.ItemCategories
{
    partial class frmEditItemCategory
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
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.grbItemCategoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbItemCategoryData
            // 
            this.grbItemCategoryData.Controls.Add(this.txtDescription);
            this.grbItemCategoryData.Controls.Add(this.txtName);
            this.grbItemCategoryData.Controls.Add(this.lblDescription);
            this.grbItemCategoryData.Controls.Add(this.lblName);
            this.grbItemCategoryData.Location = new System.Drawing.Point(12, 13);
            this.grbItemCategoryData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemCategoryData.Name = "grbItemCategoryData";
            this.grbItemCategoryData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbItemCategoryData.Size = new System.Drawing.Size(546, 159);
            this.grbItemCategoryData.TabIndex = 0;
            this.grbItemCategoryData.TabStop = false;
            this.grbItemCategoryData.Text = "بيانات التصنيف";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 51);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 179);
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
            this.linkReturn.Location = new System.Drawing.Point(395, 179);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(163, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة التصنيفات";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // frmEditItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 225);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbItemCategoryData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditItemCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل بيانات التصنيف";
            this.Activated += new System.EventHandler(this.frmEditItemCategory_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditItemCategory_FormClosed);
            this.Load += new System.EventHandler(this.frmEditItemCategory_Load);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkReturn;
    }
}