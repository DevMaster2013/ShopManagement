namespace ShopWinApplication.Forms.Locations
{
    partial class frmViewLocation
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
            this.grbLocationData = new System.Windows.Forms.GroupBox();
            this.dataItemCount = new System.Windows.Forms.LinkLabel();
            this.lblNoOfItems = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.grbLocationData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLocationData
            // 
            this.grbLocationData.Controls.Add(this.dataItemCount);
            this.grbLocationData.Controls.Add(this.lblNoOfItems);
            this.grbLocationData.Controls.Add(this.txtDescription);
            this.grbLocationData.Controls.Add(this.txtName);
            this.grbLocationData.Controls.Add(this.lblDescription);
            this.grbLocationData.Controls.Add(this.lblName);
            this.grbLocationData.Location = new System.Drawing.Point(12, 13);
            this.grbLocationData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLocationData.Name = "grbLocationData";
            this.grbLocationData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLocationData.Size = new System.Drawing.Size(546, 192);
            this.grbLocationData.TabIndex = 0;
            this.grbLocationData.TabStop = false;
            this.grbLocationData.Text = "بيانات المكان";
            // 
            // dataItemCount
            // 
            this.dataItemCount.Location = new System.Drawing.Point(237, 162);
            this.dataItemCount.Name = "dataItemCount";
            this.dataItemCount.Size = new System.Drawing.Size(109, 17);
            this.dataItemCount.TabIndex = 8;
            this.dataItemCount.TabStop = true;
            this.dataItemCount.Text = "0 صنف";
            this.dataItemCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataItemCount_LinkClicked);
            // 
            // lblNoOfItems
            // 
            this.lblNoOfItems.AutoSize = true;
            this.lblNoOfItems.Location = new System.Drawing.Point(369, 162);
            this.lblNoOfItems.Name = "lblNoOfItems";
            this.lblNoOfItems.Size = new System.Drawing.Size(157, 17);
            this.lblNoOfItems.TabIndex = 6;
            this.lblNoOfItems.Text = "الأصناف الموجودة بالمكان:";
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
            this.lblDescription.Size = new System.Drawing.Size(135, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على المكان:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم المكان:";
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(395, 209);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(149, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الأماكن";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(9, 209);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(41, 17);
            this.linkEdit.TabIndex = 3;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "تعديل";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // frmViewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 237);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.grbLocationData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewLocation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض بيانات المكان";
            this.Activated += new System.EventHandler(this.frmViewLocation_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewLocation_FormClosed);
            this.Load += new System.EventHandler(this.frmViewLocation_Load);
            this.grbLocationData.ResumeLayout(false);
            this.grbLocationData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLocationData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.LinkLabel dataItemCount;
        private System.Windows.Forms.Label lblNoOfItems;
        private System.Windows.Forms.LinkLabel linkEdit;
    }
}