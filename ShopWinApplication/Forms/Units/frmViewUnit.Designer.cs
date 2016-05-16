namespace ShopWinApplication.Forms.Units
{
    partial class frmViewUnit
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
            this.grbUnitData = new System.Windows.Forms.GroupBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBaseUnit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtBaseUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.grbUnitData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUnitData
            // 
            this.grbUnitData.Controls.Add(this.lblMultiplier);
            this.grbUnitData.Controls.Add(this.lblBaseUnit);
            this.grbUnitData.Controls.Add(this.txtDescription);
            this.grbUnitData.Controls.Add(this.txtMultiplier);
            this.grbUnitData.Controls.Add(this.txtBaseUnit);
            this.grbUnitData.Controls.Add(this.txtName);
            this.grbUnitData.Controls.Add(this.lblDescription);
            this.grbUnitData.Controls.Add(this.lblName);
            this.grbUnitData.Location = new System.Drawing.Point(12, 13);
            this.grbUnitData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUnitData.Name = "grbUnitData";
            this.grbUnitData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUnitData.Size = new System.Drawing.Size(546, 219);
            this.grbUnitData.TabIndex = 0;
            this.grbUnitData.TabStop = false;
            this.grbUnitData.Text = "بيانات الوحدة";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(440, 186);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(83, 17);
            this.lblMultiplier.TabIndex = 7;
            this.lblMultiplier.Text = "كمية الوحدة:";
            // 
            // lblBaseUnit
            // 
            this.lblBaseUnit.AutoSize = true;
            this.lblBaseUnit.Location = new System.Drawing.Point(419, 160);
            this.lblBaseUnit.Name = "lblBaseUnit";
            this.lblBaseUnit.Size = new System.Drawing.Size(104, 17);
            this.lblBaseUnit.TabIndex = 8;
            this.lblBaseUnit.Text = "الوحدة الرئيسية:";
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
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(287, 183);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.ReadOnly = true;
            this.txtMultiplier.Size = new System.Drawing.Size(99, 24);
            this.txtMultiplier.TabIndex = 1;
            // 
            // txtBaseUnit
            // 
            this.txtBaseUnit.Location = new System.Drawing.Point(18, 157);
            this.txtBaseUnit.Name = "txtBaseUnit";
            this.txtBaseUnit.ReadOnly = true;
            this.txtBaseUnit.Size = new System.Drawing.Size(368, 24);
            this.txtBaseUnit.TabIndex = 1;
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
            this.lblDescription.Size = new System.Drawing.Size(136, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على الوحدة:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم الوحدة:";
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(389, 236);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(152, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الوحدات";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(9, 236);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(41, 17);
            this.linkEdit.TabIndex = 9;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "تعديل";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // frmViewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.grbUnitData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض بيانات الوحدة";
            this.Activated += new System.EventHandler(this.frmViewUnit_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewUnit_FormClosed);
            this.Load += new System.EventHandler(this.frmViewUnit_Load);
            this.grbUnitData.ResumeLayout(false);
            this.grbUnitData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUnitData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblBaseUnit;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtBaseUnit;
        private System.Windows.Forms.LinkLabel linkEdit;
    }
}