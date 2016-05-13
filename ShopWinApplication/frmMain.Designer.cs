namespace ShopWinApplication
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbEssentialData = new System.Windows.Forms.GroupBox();
            this.linkItems = new System.Windows.Forms.LinkLabel();
            this.linkSuppliers = new System.Windows.Forms.LinkLabel();
            this.linkUnits = new System.Windows.Forms.LinkLabel();
            this.linkLocations = new System.Windows.Forms.LinkLabel();
            this.linkItemCategories = new System.Windows.Forms.LinkLabel();
            this.lblEssentialDataDescription = new System.Windows.Forms.Label();
            this.grbEssentialData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEssentialData
            // 
            this.grbEssentialData.BackColor = System.Drawing.Color.Transparent;
            this.grbEssentialData.Controls.Add(this.linkItems);
            this.grbEssentialData.Controls.Add(this.linkSuppliers);
            this.grbEssentialData.Controls.Add(this.linkUnits);
            this.grbEssentialData.Controls.Add(this.linkLocations);
            this.grbEssentialData.Controls.Add(this.linkItemCategories);
            this.grbEssentialData.Controls.Add(this.lblEssentialDataDescription);
            this.grbEssentialData.Location = new System.Drawing.Point(14, 15);
            this.grbEssentialData.Name = "grbEssentialData";
            this.grbEssentialData.Size = new System.Drawing.Size(330, 153);
            this.grbEssentialData.TabIndex = 1;
            this.grbEssentialData.TabStop = false;
            this.grbEssentialData.Text = "البيانات الأساسية للمحل";
            // 
            // linkItems
            // 
            this.linkItems.AutoSize = true;
            this.linkItems.Location = new System.Drawing.Point(110, 129);
            this.linkItems.Name = "linkItems";
            this.linkItems.Size = new System.Drawing.Size(182, 17);
            this.linkItems.TabIndex = 1;
            this.linkItems.TabStop = true;
            this.linkItems.Text = "قائمة البضائع الموجودة بالمحل";
            this.linkItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
            // 
            // linkSuppliers
            // 
            this.linkSuppliers.AutoSize = true;
            this.linkSuppliers.Location = new System.Drawing.Point(110, 112);
            this.linkSuppliers.Name = "linkSuppliers";
            this.linkSuppliers.Size = new System.Drawing.Size(182, 17);
            this.linkSuppliers.TabIndex = 1;
            this.linkSuppliers.TabStop = true;
            this.linkSuppliers.Text = "قائمة الموردين للبضائع بالمحل";
            this.linkSuppliers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSuppliers_LinkClicked);
            // 
            // linkUnits
            // 
            this.linkUnits.AutoSize = true;
            this.linkUnits.Location = new System.Drawing.Point(87, 95);
            this.linkUnits.Name = "linkUnits";
            this.linkUnits.Size = new System.Drawing.Size(205, 17);
            this.linkUnits.TabIndex = 1;
            this.linkUnits.TabStop = true;
            this.linkUnits.Text = "قائمة الوحدات المستخدمة للبضائع";
            this.linkUnits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUnits_LinkClicked);
            // 
            // linkLocations
            // 
            this.linkLocations.AutoSize = true;
            this.linkLocations.Location = new System.Drawing.Point(38, 78);
            this.linkLocations.Name = "linkLocations";
            this.linkLocations.Size = new System.Drawing.Size(254, 17);
            this.linkLocations.TabIndex = 1;
            this.linkLocations.TabStop = true;
            this.linkLocations.Text = "قائمة أماكن الأرفف والأماكن الأخرى بالمحل";
            this.linkLocations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLocations_LinkClicked);
            // 
            // linkItemCategories
            // 
            this.linkItemCategories.AutoSize = true;
            this.linkItemCategories.Location = new System.Drawing.Point(94, 61);
            this.linkItemCategories.Name = "linkItemCategories";
            this.linkItemCategories.Size = new System.Drawing.Size(198, 17);
            this.linkItemCategories.TabIndex = 1;
            this.linkItemCategories.TabStop = true;
            this.linkItemCategories.Text = "قائمة التصنيفات الموجودة بالمحل";
            this.linkItemCategories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItemCategories_LinkClicked);
            // 
            // lblEssentialDataDescription
            // 
            this.lblEssentialDataDescription.AutoSize = true;
            this.lblEssentialDataDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblEssentialDataDescription.Location = new System.Drawing.Point(25, 20);
            this.lblEssentialDataDescription.Name = "lblEssentialDataDescription";
            this.lblEssentialDataDescription.Size = new System.Drawing.Size(299, 39);
            this.lblEssentialDataDescription.TabIndex = 0;
            this.lblEssentialDataDescription.Text = "البيانات الأساسية للمحل هى البيانات التى لا يتم تعديلها الا قليلا\r\nحيث يتم ادخاله" +
    "ا مرة واحدة فقط فى بداية التعامل مع البرنامج\r\nمثل (التصنيفات ، الأماكن ...)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 576);
            this.Controls.Add(this.grbEssentialData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "محلات الأمانة للوازم المعمار";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.grbEssentialData.ResumeLayout(false);
            this.grbEssentialData.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox grbEssentialData;
        private System.Windows.Forms.LinkLabel linkItemCategories;
        private System.Windows.Forms.Label lblEssentialDataDescription;
        private System.Windows.Forms.LinkLabel linkUnits;
        private System.Windows.Forms.LinkLabel linkLocations;
        private System.Windows.Forms.LinkLabel linkItems;
        private System.Windows.Forms.LinkLabel linkSuppliers;
    }
}



