namespace ShopWinApplication.Forms.Units
{
    partial class frmEditUnit
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
            this.grbUnitData = new System.Windows.Forms.GroupBox();
            this.numMultiplier = new System.Windows.Forms.NumericUpDown();
            this.comboBaseUnit = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBaseUnit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.grbUnitData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUnitData
            // 
            this.grbUnitData.Controls.Add(this.numMultiplier);
            this.grbUnitData.Controls.Add(this.comboBaseUnit);
            this.grbUnitData.Controls.Add(this.lblMultiplier);
            this.grbUnitData.Controls.Add(this.lblBaseUnit);
            this.grbUnitData.Controls.Add(this.txtDescription);
            this.grbUnitData.Controls.Add(this.txtName);
            this.grbUnitData.Controls.Add(this.lblDescription);
            this.grbUnitData.Controls.Add(this.lblName);
            this.grbUnitData.Location = new System.Drawing.Point(12, 13);
            this.grbUnitData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUnitData.Name = "grbUnitData";
            this.grbUnitData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUnitData.Size = new System.Drawing.Size(546, 214);
            this.grbUnitData.TabIndex = 0;
            this.grbUnitData.TabStop = false;
            this.grbUnitData.Text = "بيانات الوحدة";
            // 
            // numMultiplier
            // 
            this.numMultiplier.Location = new System.Drawing.Point(265, 177);
            this.numMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMultiplier.Name = "numMultiplier";
            this.numMultiplier.Size = new System.Drawing.Size(120, 24);
            this.numMultiplier.TabIndex = 8;
            this.numMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBaseUnit
            // 
            this.comboBaseUnit.DataSource = this.unitBindingSource;
            this.comboBaseUnit.DisplayMember = "Name";
            this.comboBaseUnit.FormattingEnabled = true;
            this.comboBaseUnit.Location = new System.Drawing.Point(182, 150);
            this.comboBaseUnit.Name = "comboBaseUnit";
            this.comboBaseUnit.Size = new System.Drawing.Size(203, 24);
            this.comboBaseUnit.TabIndex = 7;
            this.comboBaseUnit.ValueMember = "ID";
            this.comboBaseUnit.SelectedIndexChanged += new System.EventHandler(this.comboBaseUnit_SelectedIndexChanged);
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(ShopWinApplication.Data.Unit);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(440, 179);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(83, 17);
            this.lblMultiplier.TabIndex = 5;
            this.lblMultiplier.Text = "كمية الوحدة:";
            // 
            // lblBaseUnit
            // 
            this.lblBaseUnit.AutoSize = true;
            this.lblBaseUnit.Location = new System.Drawing.Point(419, 153);
            this.lblBaseUnit.Name = "lblBaseUnit";
            this.lblBaseUnit.Size = new System.Drawing.Size(104, 17);
            this.lblBaseUnit.TabIndex = 6;
            this.lblBaseUnit.Text = "الوحدة الرئيسية:";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 231);
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
            this.linkReturn.Location = new System.Drawing.Point(395, 231);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(152, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة الوحدات";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // frmEditUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 277);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbUnitData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل بيانات المكان";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditUnit_FormClosed);
            this.Load += new System.EventHandler(this.frmEditUnit_Load);
            this.grbUnitData.ResumeLayout(false);
            this.grbUnitData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUnitData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.NumericUpDown numMultiplier;
        private System.Windows.Forms.ComboBox comboBaseUnit;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblBaseUnit;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}