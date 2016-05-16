namespace ShopWinApplication.Forms.Customers
{
    partial class frmViewCustomer
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
            this.grbCustomerData = new System.Windows.Forms.GroupBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataCreditTotal = new System.Windows.Forms.LinkLabel();
            this.dataSellOrderCount = new System.Windows.Forms.LinkLabel();
            this.lblCreditTotal = new System.Windows.Forms.Label();
            this.lblNoOfSellOrder = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.linkReturn = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.grbCustomerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCustomerData
            // 
            this.grbCustomerData.Controls.Add(this.txtTelNo);
            this.grbCustomerData.Controls.Add(this.txtAddress);
            this.grbCustomerData.Controls.Add(this.lblTelNo);
            this.grbCustomerData.Controls.Add(this.lblAddress);
            this.grbCustomerData.Controls.Add(this.dataCreditTotal);
            this.grbCustomerData.Controls.Add(this.dataSellOrderCount);
            this.grbCustomerData.Controls.Add(this.lblCreditTotal);
            this.grbCustomerData.Controls.Add(this.lblNoOfSellOrder);
            this.grbCustomerData.Controls.Add(this.txtDescription);
            this.grbCustomerData.Controls.Add(this.txtName);
            this.grbCustomerData.Controls.Add(this.lblDescription);
            this.grbCustomerData.Controls.Add(this.lblName);
            this.grbCustomerData.Location = new System.Drawing.Point(12, 13);
            this.grbCustomerData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCustomerData.Name = "grbCustomerData";
            this.grbCustomerData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCustomerData.Size = new System.Drawing.Size(546, 258);
            this.grbCustomerData.TabIndex = 0;
            this.grbCustomerData.TabStop = false;
            this.grbCustomerData.Text = "بيانات العميل";
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
            this.lblAddress.Size = new System.Drawing.Size(86, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "عنوان العميل:";
            // 
            // dataCreditTotal
            // 
            this.dataCreditTotal.Location = new System.Drawing.Point(132, 230);
            this.dataCreditTotal.Name = "dataCreditTotal";
            this.dataCreditTotal.Size = new System.Drawing.Size(211, 17);
            this.dataCreditTotal.TabIndex = 8;
            this.dataCreditTotal.TabStop = true;
            this.dataCreditTotal.Text = "0.0 جنيه مصرى";
            this.dataCreditTotal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataCreditTotal_LinkClicked);
            // 
            // dataSellOrderCount
            // 
            this.dataSellOrderCount.Location = new System.Drawing.Point(132, 203);
            this.dataSellOrderCount.Name = "dataSellOrderCount";
            this.dataSellOrderCount.Size = new System.Drawing.Size(211, 17);
            this.dataSellOrderCount.TabIndex = 8;
            this.dataSellOrderCount.TabStop = true;
            this.dataSellOrderCount.Text = "0 عملية";
            this.dataSellOrderCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dataSellOrderCount_LinkClicked);
            // 
            // lblCreditTotal
            // 
            this.lblCreditTotal.AutoSize = true;
            this.lblCreditTotal.Location = new System.Drawing.Point(396, 230);
            this.lblCreditTotal.Name = "lblCreditTotal";
            this.lblCreditTotal.Size = new System.Drawing.Size(128, 17);
            this.lblCreditTotal.TabIndex = 6;
            this.lblCreditTotal.Text = "إجمالى ديون العميل:";
            // 
            // lblNoOfSellOrder
            // 
            this.lblNoOfSellOrder.AutoSize = true;
            this.lblNoOfSellOrder.Location = new System.Drawing.Point(371, 203);
            this.lblNoOfSellOrder.Name = "lblNoOfSellOrder";
            this.lblNoOfSellOrder.Size = new System.Drawing.Size(153, 17);
            this.lblNoOfSellOrder.TabIndex = 6;
            this.lblNoOfSellOrder.Text = "عمليات البيع لهذا العميل:";
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
            this.lblDescription.Size = new System.Drawing.Size(137, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "ملاحظات على العميل:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(442, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم العميل:";
            // 
            // linkReturn
            // 
            this.linkReturn.AutoSize = true;
            this.linkReturn.Location = new System.Drawing.Point(383, 275);
            this.linkReturn.Name = "linkReturn";
            this.linkReturn.Size = new System.Drawing.Size(146, 17);
            this.linkReturn.TabIndex = 2;
            this.linkReturn.TabStop = true;
            this.linkReturn.Text = "الرجوع إلى قائمة العملاء";
            this.linkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReturn_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(9, 275);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(41, 17);
            this.linkEdit.TabIndex = 3;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "تعديل";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // frmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 305);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkReturn);
            this.Controls.Add(this.grbCustomerData);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض بيانات العميل";
            this.Activated += new System.EventHandler(this.frmViewCustomer_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViewCustomer_FormClosed);
            this.Load += new System.EventHandler(this.frmViewCustomer_Load);
            this.grbCustomerData.ResumeLayout(false);
            this.grbCustomerData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomerData;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkReturn;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.LinkLabel dataSellOrderCount;
        private System.Windows.Forms.Label lblNoOfSellOrder;
        private System.Windows.Forms.LinkLabel linkEdit;
        private System.Windows.Forms.LinkLabel dataCreditTotal;
        private System.Windows.Forms.Label lblCreditTotal;
    }
}