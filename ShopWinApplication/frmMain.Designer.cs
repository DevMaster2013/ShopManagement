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
            this.linkCustomers = new System.Windows.Forms.LinkLabel();
            this.linkSuppliers = new System.Windows.Forms.LinkLabel();
            this.linkUnits = new System.Windows.Forms.LinkLabel();
            this.linkLocations = new System.Windows.Forms.LinkLabel();
            this.linkItemCategories = new System.Windows.Forms.LinkLabel();
            this.lblEssentialDataDescription = new System.Windows.Forms.Label();
            this.grbBuySellManagement = new System.Windows.Forms.GroupBox();
            this.linkCredits = new System.Windows.Forms.LinkLabel();
            this.linkBuyOrders = new System.Windows.Forms.LinkLabel();
            this.linkSellOrders = new System.Windows.Forms.LinkLabel();
            this.lblBuySellManagementTitle = new System.Windows.Forms.Label();
            this.linkDebits = new System.Windows.Forms.LinkLabel();
            this.grbExpensesAndExternal = new System.Windows.Forms.GroupBox();
            this.linkExternalCredits = new System.Windows.Forms.LinkLabel();
            this.linkExternalDebits = new System.Windows.Forms.LinkLabel();
            this.linkExpenses = new System.Windows.Forms.LinkLabel();
            this.lblExpensesAndExternalTitle = new System.Windows.Forms.Label();
            this.grbFastOperations = new System.Windows.Forms.GroupBox();
            this.linkPayDebit = new System.Windows.Forms.LinkLabel();
            this.linkAddSellOrder = new System.Windows.Forms.LinkLabel();
            this.linkAddBuyOrder = new System.Windows.Forms.LinkLabel();
            this.lblFastOperationsTitle = new System.Windows.Forms.Label();
            this.linkCollectCredit = new System.Windows.Forms.LinkLabel();
            this.linkPayExternalDebit = new System.Windows.Forms.LinkLabel();
            this.linkCollectExternalCredit = new System.Windows.Forms.LinkLabel();
            this.linkSearchItem = new System.Windows.Forms.LinkLabel();
            this.linkSearchBuyOrder = new System.Windows.Forms.LinkLabel();
            this.linkSearchSellOrder = new System.Windows.Forms.LinkLabel();
            this.linkAddExpense = new System.Windows.Forms.LinkLabel();
            this.grbDailyReports = new System.Windows.Forms.GroupBox();
            this.linkViewCurrentItems = new System.Windows.Forms.LinkLabel();
            this.linkViewExpiredItems = new System.Windows.Forms.LinkLabel();
            this.linkViewFinishedItems = new System.Windows.Forms.LinkLabel();
            this.linkViewNearlyFinishedItems = new System.Windows.Forms.LinkLabel();
            this.lblDailyReportsTitle = new System.Windows.Forms.Label();
            this.linkViewCustomerOperations = new System.Windows.Forms.LinkLabel();
            this.linkViewSupplierOperations = new System.Windows.Forms.LinkLabel();
            this.grbFinancialManagement = new System.Windows.Forms.GroupBox();
            this.linkViewDebitSummary = new System.Windows.Forms.LinkLabel();
            this.linkViewExpense = new System.Windows.Forms.LinkLabel();
            this.linkViewFinanceSummary = new System.Windows.Forms.LinkLabel();
            this.linkViewCreditSummary = new System.Windows.Forms.LinkLabel();
            this.linkViewFinanceDetails = new System.Windows.Forms.LinkLabel();
            this.lblFinancialTitle = new System.Windows.Forms.Label();
            this.grbEssentialData.SuspendLayout();
            this.grbBuySellManagement.SuspendLayout();
            this.grbExpensesAndExternal.SuspendLayout();
            this.grbFastOperations.SuspendLayout();
            this.grbDailyReports.SuspendLayout();
            this.grbFinancialManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEssentialData
            // 
            this.grbEssentialData.BackColor = System.Drawing.Color.Transparent;
            this.grbEssentialData.Controls.Add(this.linkItems);
            this.grbEssentialData.Controls.Add(this.linkCustomers);
            this.grbEssentialData.Controls.Add(this.linkSuppliers);
            this.grbEssentialData.Controls.Add(this.linkUnits);
            this.grbEssentialData.Controls.Add(this.linkLocations);
            this.grbEssentialData.Controls.Add(this.linkItemCategories);
            this.grbEssentialData.Controls.Add(this.lblEssentialDataDescription);
            this.grbEssentialData.Location = new System.Drawing.Point(14, 15);
            this.grbEssentialData.Name = "grbEssentialData";
            this.grbEssentialData.Size = new System.Drawing.Size(330, 173);
            this.grbEssentialData.TabIndex = 1;
            this.grbEssentialData.TabStop = false;
            this.grbEssentialData.Text = "البيانات الأساسية للمحل";
            // 
            // linkItems
            // 
            this.linkItems.AutoSize = true;
            this.linkItems.Location = new System.Drawing.Point(110, 146);
            this.linkItems.Name = "linkItems";
            this.linkItems.Size = new System.Drawing.Size(182, 17);
            this.linkItems.TabIndex = 1;
            this.linkItems.TabStop = true;
            this.linkItems.Text = "قائمة البضائع الموجودة بالمحل";
            this.linkItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
            // 
            // linkCustomers
            // 
            this.linkCustomers.AutoSize = true;
            this.linkCustomers.Location = new System.Drawing.Point(166, 129);
            this.linkCustomers.Name = "linkCustomers";
            this.linkCustomers.Size = new System.Drawing.Size(126, 17);
            this.linkCustomers.TabIndex = 1;
            this.linkCustomers.TabStop = true;
            this.linkCustomers.Text = "قائمة العملاء بالمحل";
            this.linkCustomers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCustomers_LinkClicked);
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
            // grbBuySellManagement
            // 
            this.grbBuySellManagement.BackColor = System.Drawing.Color.Transparent;
            this.grbBuySellManagement.Controls.Add(this.linkDebits);
            this.grbBuySellManagement.Controls.Add(this.linkCredits);
            this.grbBuySellManagement.Controls.Add(this.linkBuyOrders);
            this.grbBuySellManagement.Controls.Add(this.linkSellOrders);
            this.grbBuySellManagement.Controls.Add(this.lblBuySellManagementTitle);
            this.grbBuySellManagement.Location = new System.Drawing.Point(350, 15);
            this.grbBuySellManagement.Name = "grbBuySellManagement";
            this.grbBuySellManagement.Size = new System.Drawing.Size(199, 173);
            this.grbBuySellManagement.TabIndex = 1;
            this.grbBuySellManagement.TabStop = false;
            this.grbBuySellManagement.Text = "إدارة البيع والشراء";
            // 
            // linkCredits
            // 
            this.linkCredits.AutoSize = true;
            this.linkCredits.Location = new System.Drawing.Point(54, 112);
            this.linkCredits.Name = "linkCredits";
            this.linkCredits.Size = new System.Drawing.Size(105, 17);
            this.linkCredits.TabIndex = 1;
            this.linkCredits.TabStop = true;
            this.linkCredits.Text = "إدارة ديون العملاء";
            // 
            // linkBuyOrders
            // 
            this.linkBuyOrders.AutoSize = true;
            this.linkBuyOrders.Location = new System.Drawing.Point(52, 95);
            this.linkBuyOrders.Name = "linkBuyOrders";
            this.linkBuyOrders.Size = new System.Drawing.Size(107, 17);
            this.linkBuyOrders.TabIndex = 1;
            this.linkBuyOrders.TabStop = true;
            this.linkBuyOrders.Text = "إدارة  فواتيرالشراء";
            // 
            // linkSellOrders
            // 
            this.linkSellOrders.AutoSize = true;
            this.linkSellOrders.Location = new System.Drawing.Point(63, 78);
            this.linkSellOrders.Name = "linkSellOrders";
            this.linkSellOrders.Size = new System.Drawing.Size(96, 17);
            this.linkSellOrders.TabIndex = 1;
            this.linkSellOrders.TabStop = true;
            this.linkSellOrders.Text = "إدارة فواتير البيع";
            // 
            // lblBuySellManagementTitle
            // 
            this.lblBuySellManagementTitle.AutoSize = true;
            this.lblBuySellManagementTitle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblBuySellManagementTitle.Location = new System.Drawing.Point(17, 20);
            this.lblBuySellManagementTitle.Name = "lblBuySellManagementTitle";
            this.lblBuySellManagementTitle.Size = new System.Drawing.Size(176, 52);
            this.lblBuySellManagementTitle.TabIndex = 0;
            this.lblBuySellManagementTitle.Text = "إدارة البيع والشراء يتم من خلالها إدارة\r\n فواتير المحل بالكامل من فواتير بيع\r\n وش" +
    "راء وكذلك متابعة الديون\r\n والمستحقات المتعلقة بالمحل";
            // 
            // linkDebits
            // 
            this.linkDebits.AutoSize = true;
            this.linkDebits.Location = new System.Drawing.Point(10, 129);
            this.linkDebits.Name = "linkDebits";
            this.linkDebits.Size = new System.Drawing.Size(149, 17);
            this.linkDebits.TabIndex = 1;
            this.linkDebits.TabStop = true;
            this.linkDebits.Text = "إدارة مستحقات الموردين";
            // 
            // grbExpensesAndExternal
            // 
            this.grbExpensesAndExternal.BackColor = System.Drawing.Color.Transparent;
            this.grbExpensesAndExternal.Controls.Add(this.linkExternalCredits);
            this.grbExpensesAndExternal.Controls.Add(this.linkExternalDebits);
            this.grbExpensesAndExternal.Controls.Add(this.linkExpenses);
            this.grbExpensesAndExternal.Controls.Add(this.lblExpensesAndExternalTitle);
            this.grbExpensesAndExternal.Location = new System.Drawing.Point(555, 15);
            this.grbExpensesAndExternal.Name = "grbExpensesAndExternal";
            this.grbExpensesAndExternal.Size = new System.Drawing.Size(241, 173);
            this.grbExpensesAndExternal.TabIndex = 1;
            this.grbExpensesAndExternal.TabStop = false;
            this.grbExpensesAndExternal.Text = "إدارة المصاريف والديون الخارجية";
            // 
            // linkExternalCredits
            // 
            this.linkExternalCredits.AutoSize = true;
            this.linkExternalCredits.Location = new System.Drawing.Point(52, 112);
            this.linkExternalCredits.Name = "linkExternalCredits";
            this.linkExternalCredits.Size = new System.Drawing.Size(157, 17);
            this.linkExternalCredits.TabIndex = 1;
            this.linkExternalCredits.TabStop = true;
            this.linkExternalCredits.Text = "إدارة المستحقات الخارجية";
            // 
            // linkExternalDebits
            // 
            this.linkExternalDebits.AutoSize = true;
            this.linkExternalDebits.Location = new System.Drawing.Point(86, 95);
            this.linkExternalDebits.Name = "linkExternalDebits";
            this.linkExternalDebits.Size = new System.Drawing.Size(123, 17);
            this.linkExternalDebits.TabIndex = 1;
            this.linkExternalDebits.TabStop = true;
            this.linkExternalDebits.Text = "إدارة الديون الخارجية";
            // 
            // linkExpenses
            // 
            this.linkExpenses.AutoSize = true;
            this.linkExpenses.Location = new System.Drawing.Point(112, 78);
            this.linkExpenses.Name = "linkExpenses";
            this.linkExpenses.Size = new System.Drawing.Size(97, 17);
            this.linkExpenses.TabIndex = 1;
            this.linkExpenses.TabStop = true;
            this.linkExpenses.Text = "إدارة المصروفات";
            // 
            // lblExpensesAndExternalTitle
            // 
            this.lblExpensesAndExternalTitle.AutoSize = true;
            this.lblExpensesAndExternalTitle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblExpensesAndExternalTitle.Location = new System.Drawing.Point(17, 20);
            this.lblExpensesAndExternalTitle.Name = "lblExpensesAndExternalTitle";
            this.lblExpensesAndExternalTitle.Size = new System.Drawing.Size(218, 52);
            this.lblExpensesAndExternalTitle.TabIndex = 0;
            this.lblExpensesAndExternalTitle.Text = "إدارة المصاريف والديون الخارجية يتم فيها إدارة\r\nجميع المصروفات الخارجية التى ليس " +
    "لها علاقة \r\nببضاعة المحل وكذلك أى ديون أو مستحقات \r\nخارجية";
            // 
            // grbFastOperations
            // 
            this.grbFastOperations.BackColor = System.Drawing.Color.Transparent;
            this.grbFastOperations.Controls.Add(this.linkSearchSellOrder);
            this.grbFastOperations.Controls.Add(this.linkSearchBuyOrder);
            this.grbFastOperations.Controls.Add(this.linkAddExpense);
            this.grbFastOperations.Controls.Add(this.linkCollectExternalCredit);
            this.grbFastOperations.Controls.Add(this.linkPayExternalDebit);
            this.grbFastOperations.Controls.Add(this.linkSearchItem);
            this.grbFastOperations.Controls.Add(this.linkPayDebit);
            this.grbFastOperations.Controls.Add(this.linkCollectCredit);
            this.grbFastOperations.Controls.Add(this.linkAddSellOrder);
            this.grbFastOperations.Controls.Add(this.linkAddBuyOrder);
            this.grbFastOperations.Controls.Add(this.lblFastOperationsTitle);
            this.grbFastOperations.Location = new System.Drawing.Point(14, 194);
            this.grbFastOperations.Name = "grbFastOperations";
            this.grbFastOperations.Size = new System.Drawing.Size(330, 156);
            this.grbFastOperations.TabIndex = 1;
            this.grbFastOperations.TabStop = false;
            this.grbFastOperations.Text = "العمليات السريعة";
            // 
            // linkPayDebit
            // 
            this.linkPayDebit.AutoSize = true;
            this.linkPayDebit.Location = new System.Drawing.Point(184, 74);
            this.linkPayDebit.Name = "linkPayDebit";
            this.linkPayDebit.Size = new System.Drawing.Size(108, 17);
            this.linkPayDebit.TabIndex = 1;
            this.linkPayDebit.TabStop = true;
            this.linkPayDebit.Text = "تسديد دين لمورد";
            // 
            // linkAddSellOrder
            // 
            this.linkAddSellOrder.AutoSize = true;
            this.linkAddSellOrder.Location = new System.Drawing.Point(64, 57);
            this.linkAddSellOrder.Name = "linkAddSellOrder";
            this.linkAddSellOrder.Size = new System.Drawing.Size(97, 17);
            this.linkAddSellOrder.TabIndex = 1;
            this.linkAddSellOrder.TabStop = true;
            this.linkAddSellOrder.Text = "إضافة فاتورة بيع";
            // 
            // linkAddBuyOrder
            // 
            this.linkAddBuyOrder.AutoSize = true;
            this.linkAddBuyOrder.Location = new System.Drawing.Point(184, 57);
            this.linkAddBuyOrder.Name = "linkAddBuyOrder";
            this.linkAddBuyOrder.Size = new System.Drawing.Size(108, 17);
            this.linkAddBuyOrder.TabIndex = 1;
            this.linkAddBuyOrder.TabStop = true;
            this.linkAddBuyOrder.Text = "إضافة فاتورة شراء";
            // 
            // lblFastOperationsTitle
            // 
            this.lblFastOperationsTitle.AutoSize = true;
            this.lblFastOperationsTitle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblFastOperationsTitle.Location = new System.Drawing.Point(55, 21);
            this.lblFastOperationsTitle.Name = "lblFastOperationsTitle";
            this.lblFastOperationsTitle.Size = new System.Drawing.Size(269, 26);
            this.lblFastOperationsTitle.TabIndex = 0;
            this.lblFastOperationsTitle.Text = "العمليات السريعة هى مجموعة من العمليات التى يحتاجها\r\n المستخدم دائما موجودة مجمعة" +
    " هنا لسهولة الإستخدام";
            // 
            // linkCollectCredit
            // 
            this.linkCollectCredit.AutoSize = true;
            this.linkCollectCredit.Location = new System.Drawing.Point(6, 74);
            this.linkCollectCredit.Name = "linkCollectCredit";
            this.linkCollectCredit.Size = new System.Drawing.Size(155, 17);
            this.linkCollectCredit.TabIndex = 1;
            this.linkCollectCredit.TabStop = true;
            this.linkCollectCredit.Text = "جمع مستحقات من عميل";
            // 
            // linkPayExternalDebit
            // 
            this.linkPayExternalDebit.AutoSize = true;
            this.linkPayExternalDebit.Location = new System.Drawing.Point(174, 91);
            this.linkPayExternalDebit.Name = "linkPayExternalDebit";
            this.linkPayExternalDebit.Size = new System.Drawing.Size(118, 17);
            this.linkPayExternalDebit.TabIndex = 1;
            this.linkPayExternalDebit.TabStop = true;
            this.linkPayExternalDebit.Text = "تسديد دين خارجى";
            // 
            // linkCollectExternalCredit
            // 
            this.linkCollectExternalCredit.AutoSize = true;
            this.linkCollectExternalCredit.Location = new System.Drawing.Point(20, 91);
            this.linkCollectExternalCredit.Name = "linkCollectExternalCredit";
            this.linkCollectExternalCredit.Size = new System.Drawing.Size(141, 17);
            this.linkCollectExternalCredit.TabIndex = 1;
            this.linkCollectExternalCredit.TabStop = true;
            this.linkCollectExternalCredit.Text = "جمع مستحقات خارجية";
            // 
            // linkSearchItem
            // 
            this.linkSearchItem.AutoSize = true;
            this.linkSearchItem.Location = new System.Drawing.Point(70, 108);
            this.linkSearchItem.Name = "linkSearchItem";
            this.linkSearchItem.Size = new System.Drawing.Size(91, 17);
            this.linkSearchItem.TabIndex = 1;
            this.linkSearchItem.TabStop = true;
            this.linkSearchItem.Text = "بحث عن صنف";
            // 
            // linkSearchBuyOrder
            // 
            this.linkSearchBuyOrder.AutoSize = true;
            this.linkSearchBuyOrder.Location = new System.Drawing.Point(166, 125);
            this.linkSearchBuyOrder.Name = "linkSearchBuyOrder";
            this.linkSearchBuyOrder.Size = new System.Drawing.Size(126, 17);
            this.linkSearchBuyOrder.TabIndex = 1;
            this.linkSearchBuyOrder.TabStop = true;
            this.linkSearchBuyOrder.Text = "بحث عن فاتورة شراء";
            // 
            // linkSearchSellOrder
            // 
            this.linkSearchSellOrder.AutoSize = true;
            this.linkSearchSellOrder.Location = new System.Drawing.Point(46, 125);
            this.linkSearchSellOrder.Name = "linkSearchSellOrder";
            this.linkSearchSellOrder.Size = new System.Drawing.Size(115, 17);
            this.linkSearchSellOrder.TabIndex = 1;
            this.linkSearchSellOrder.TabStop = true;
            this.linkSearchSellOrder.Text = "بحث عن فاتورة بيع";
            // 
            // linkAddExpense
            // 
            this.linkAddExpense.AutoSize = true;
            this.linkAddExpense.Location = new System.Drawing.Point(197, 108);
            this.linkAddExpense.Name = "linkAddExpense";
            this.linkAddExpense.Size = new System.Drawing.Size(95, 17);
            this.linkAddExpense.TabIndex = 1;
            this.linkAddExpense.TabStop = true;
            this.linkAddExpense.Text = "إضافة مصروفات";
            // 
            // grbDailyReports
            // 
            this.grbDailyReports.BackColor = System.Drawing.Color.Transparent;
            this.grbDailyReports.Controls.Add(this.linkViewSupplierOperations);
            this.grbDailyReports.Controls.Add(this.linkViewCustomerOperations);
            this.grbDailyReports.Controls.Add(this.linkViewCurrentItems);
            this.grbDailyReports.Controls.Add(this.linkViewExpiredItems);
            this.grbDailyReports.Controls.Add(this.linkViewFinishedItems);
            this.grbDailyReports.Controls.Add(this.linkViewNearlyFinishedItems);
            this.grbDailyReports.Controls.Add(this.lblDailyReportsTitle);
            this.grbDailyReports.Location = new System.Drawing.Point(350, 194);
            this.grbDailyReports.Name = "grbDailyReports";
            this.grbDailyReports.Size = new System.Drawing.Size(446, 156);
            this.grbDailyReports.TabIndex = 1;
            this.grbDailyReports.TabStop = false;
            this.grbDailyReports.Text = "إدارة تقارير الحالة اليومية";
            // 
            // linkViewCurrentItems
            // 
            this.linkViewCurrentItems.AutoSize = true;
            this.linkViewCurrentItems.Location = new System.Drawing.Point(214, 105);
            this.linkViewCurrentItems.Name = "linkViewCurrentItems";
            this.linkViewCurrentItems.Size = new System.Drawing.Size(192, 17);
            this.linkViewCurrentItems.TabIndex = 1;
            this.linkViewCurrentItems.TabStop = true;
            this.linkViewCurrentItems.Text = "عرض الأصناف الحالية فى المحل";
            // 
            // linkViewExpiredItems
            // 
            this.linkViewExpiredItems.AutoSize = true;
            this.linkViewExpiredItems.Location = new System.Drawing.Point(194, 88);
            this.linkViewExpiredItems.Name = "linkViewExpiredItems";
            this.linkViewExpiredItems.Size = new System.Drawing.Size(212, 17);
            this.linkViewExpiredItems.TabIndex = 1;
            this.linkViewExpiredItems.TabStop = true;
            this.linkViewExpiredItems.Text = "عرض الأصناف التى صلاحياتها انتهت";
            // 
            // linkViewFinishedItems
            // 
            this.linkViewFinishedItems.AutoSize = true;
            this.linkViewFinishedItems.Location = new System.Drawing.Point(253, 71);
            this.linkViewFinishedItems.Name = "linkViewFinishedItems";
            this.linkViewFinishedItems.Size = new System.Drawing.Size(153, 17);
            this.linkViewFinishedItems.TabIndex = 1;
            this.linkViewFinishedItems.TabStop = true;
            this.linkViewFinishedItems.Text = "عرض الأصناف التى انتهت";
            // 
            // linkViewNearlyFinishedItems
            // 
            this.linkViewNearlyFinishedItems.AutoSize = true;
            this.linkViewNearlyFinishedItems.Location = new System.Drawing.Point(170, 54);
            this.linkViewNearlyFinishedItems.Name = "linkViewNearlyFinishedItems";
            this.linkViewNearlyFinishedItems.Size = new System.Drawing.Size(236, 17);
            this.linkViewNearlyFinishedItems.TabIndex = 1;
            this.linkViewNearlyFinishedItems.TabStop = true;
            this.linkViewNearlyFinishedItems.Text = "عرض الأصناف التى أوشكت على الانتهاء";
            // 
            // lblDailyReportsTitle
            // 
            this.lblDailyReportsTitle.AutoSize = true;
            this.lblDailyReportsTitle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblDailyReportsTitle.Location = new System.Drawing.Point(120, 20);
            this.lblDailyReportsTitle.Name = "lblDailyReportsTitle";
            this.lblDailyReportsTitle.Size = new System.Drawing.Size(320, 26);
            this.lblDailyReportsTitle.TabIndex = 0;
            this.lblDailyReportsTitle.Text = "مجموعة من التقارير التى يحتاجها  المستخدم بشكل دورى خلال عمل\r\n البرنامج";
            // 
            // linkViewCustomerOperations
            // 
            this.linkViewCustomerOperations.AutoSize = true;
            this.linkViewCustomerOperations.Location = new System.Drawing.Point(285, 122);
            this.linkViewCustomerOperations.Name = "linkViewCustomerOperations";
            this.linkViewCustomerOperations.Size = new System.Drawing.Size(121, 17);
            this.linkViewCustomerOperations.TabIndex = 1;
            this.linkViewCustomerOperations.TabStop = true;
            this.linkViewCustomerOperations.Text = "عرض حركات العميل";
            // 
            // linkViewSupplierOperations
            // 
            this.linkViewSupplierOperations.AutoSize = true;
            this.linkViewSupplierOperations.Location = new System.Drawing.Point(143, 122);
            this.linkViewSupplierOperations.Name = "linkViewSupplierOperations";
            this.linkViewSupplierOperations.Size = new System.Drawing.Size(117, 17);
            this.linkViewSupplierOperations.TabIndex = 1;
            this.linkViewSupplierOperations.TabStop = true;
            this.linkViewSupplierOperations.Text = "عرض حركات المورد";
            // 
            // grbFinancialManagement
            // 
            this.grbFinancialManagement.BackColor = System.Drawing.Color.Transparent;
            this.grbFinancialManagement.Controls.Add(this.linkViewDebitSummary);
            this.grbFinancialManagement.Controls.Add(this.linkViewExpense);
            this.grbFinancialManagement.Controls.Add(this.linkViewFinanceSummary);
            this.grbFinancialManagement.Controls.Add(this.linkViewCreditSummary);
            this.grbFinancialManagement.Controls.Add(this.linkViewFinanceDetails);
            this.grbFinancialManagement.Controls.Add(this.lblFinancialTitle);
            this.grbFinancialManagement.Location = new System.Drawing.Point(14, 356);
            this.grbFinancialManagement.Name = "grbFinancialManagement";
            this.grbFinancialManagement.Size = new System.Drawing.Size(782, 85);
            this.grbFinancialManagement.TabIndex = 1;
            this.grbFinancialManagement.TabStop = false;
            this.grbFinancialManagement.Text = "الإدارة المالية";
            // 
            // linkViewDebitSummary
            // 
            this.linkViewDebitSummary.AutoSize = true;
            this.linkViewDebitSummary.Location = new System.Drawing.Point(92, 43);
            this.linkViewDebitSummary.Name = "linkViewDebitSummary";
            this.linkViewDebitSummary.Size = new System.Drawing.Size(123, 17);
            this.linkViewDebitSummary.TabIndex = 1;
            this.linkViewDebitSummary.TabStop = true;
            this.linkViewDebitSummary.Text = "عرض إجمالى الديون";
            // 
            // linkViewExpense
            // 
            this.linkViewExpense.AutoSize = true;
            this.linkViewExpense.Location = new System.Drawing.Point(360, 60);
            this.linkViewExpense.Name = "linkViewExpense";
            this.linkViewExpense.Size = new System.Drawing.Size(102, 17);
            this.linkViewExpense.TabIndex = 1;
            this.linkViewExpense.TabStop = true;
            this.linkViewExpense.Text = "عرض المصروفات";
            // 
            // linkViewFinanceSummary
            // 
            this.linkViewFinanceSummary.AutoSize = true;
            this.linkViewFinanceSummary.Location = new System.Drawing.Point(558, 43);
            this.linkViewFinanceSummary.Name = "linkViewFinanceSummary";
            this.linkViewFinanceSummary.Size = new System.Drawing.Size(186, 17);
            this.linkViewFinanceSummary.TabIndex = 1;
            this.linkViewFinanceSummary.TabStop = true;
            this.linkViewFinanceSummary.Text = "عرض تقرير المحاسبة الإجمالى";
            // 
            // linkViewCreditSummary
            // 
            this.linkViewCreditSummary.AutoSize = true;
            this.linkViewCreditSummary.Location = new System.Drawing.Point(546, 60);
            this.linkViewCreditSummary.Name = "linkViewCreditSummary";
            this.linkViewCreditSummary.Size = new System.Drawing.Size(198, 17);
            this.linkViewCreditSummary.TabIndex = 1;
            this.linkViewCreditSummary.TabStop = true;
            this.linkViewCreditSummary.Text = "عرض إجمالى المستحقات المالية";
            // 
            // linkViewFinanceDetails
            // 
            this.linkViewFinanceDetails.AutoSize = true;
            this.linkViewFinanceDetails.Location = new System.Drawing.Point(274, 43);
            this.linkViewFinanceDetails.Name = "linkViewFinanceDetails";
            this.linkViewFinanceDetails.Size = new System.Drawing.Size(188, 17);
            this.linkViewFinanceDetails.TabIndex = 1;
            this.linkViewFinanceDetails.TabStop = true;
            this.linkViewFinanceDetails.Text = "عرض تقرير المحاسبة التفصيلى";
            // 
            // lblFinancialTitle
            // 
            this.lblFinancialTitle.AutoSize = true;
            this.lblFinancialTitle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblFinancialTitle.Location = new System.Drawing.Point(549, 20);
            this.lblFinancialTitle.Name = "lblFinancialTitle";
            this.lblFinancialTitle.Size = new System.Drawing.Size(227, 13);
            this.lblFinancialTitle.TabIndex = 0;
            this.lblFinancialTitle.Text = "مجموعة من التقارير المتعلقة بإدارة المحل المالية";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.grbFastOperations);
            this.Controls.Add(this.grbExpensesAndExternal);
            this.Controls.Add(this.grbFinancialManagement);
            this.Controls.Add(this.grbDailyReports);
            this.Controls.Add(this.grbBuySellManagement);
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
            this.grbBuySellManagement.ResumeLayout(false);
            this.grbBuySellManagement.PerformLayout();
            this.grbExpensesAndExternal.ResumeLayout(false);
            this.grbExpensesAndExternal.PerformLayout();
            this.grbFastOperations.ResumeLayout(false);
            this.grbFastOperations.PerformLayout();
            this.grbDailyReports.ResumeLayout(false);
            this.grbDailyReports.PerformLayout();
            this.grbFinancialManagement.ResumeLayout(false);
            this.grbFinancialManagement.PerformLayout();
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
        private System.Windows.Forms.LinkLabel linkCustomers;
        private System.Windows.Forms.GroupBox grbBuySellManagement;
        private System.Windows.Forms.LinkLabel linkDebits;
        private System.Windows.Forms.LinkLabel linkCredits;
        private System.Windows.Forms.LinkLabel linkBuyOrders;
        private System.Windows.Forms.LinkLabel linkSellOrders;
        private System.Windows.Forms.Label lblBuySellManagementTitle;
        private System.Windows.Forms.GroupBox grbExpensesAndExternal;
        private System.Windows.Forms.LinkLabel linkExternalCredits;
        private System.Windows.Forms.LinkLabel linkExternalDebits;
        private System.Windows.Forms.LinkLabel linkExpenses;
        private System.Windows.Forms.Label lblExpensesAndExternalTitle;
        private System.Windows.Forms.GroupBox grbFastOperations;
        private System.Windows.Forms.LinkLabel linkSearchSellOrder;
        private System.Windows.Forms.LinkLabel linkSearchBuyOrder;
        private System.Windows.Forms.LinkLabel linkAddExpense;
        private System.Windows.Forms.LinkLabel linkCollectExternalCredit;
        private System.Windows.Forms.LinkLabel linkPayExternalDebit;
        private System.Windows.Forms.LinkLabel linkSearchItem;
        private System.Windows.Forms.LinkLabel linkPayDebit;
        private System.Windows.Forms.LinkLabel linkCollectCredit;
        private System.Windows.Forms.LinkLabel linkAddSellOrder;
        private System.Windows.Forms.LinkLabel linkAddBuyOrder;
        private System.Windows.Forms.Label lblFastOperationsTitle;
        private System.Windows.Forms.GroupBox grbDailyReports;
        private System.Windows.Forms.LinkLabel linkViewCurrentItems;
        private System.Windows.Forms.LinkLabel linkViewExpiredItems;
        private System.Windows.Forms.LinkLabel linkViewFinishedItems;
        private System.Windows.Forms.LinkLabel linkViewNearlyFinishedItems;
        private System.Windows.Forms.Label lblDailyReportsTitle;
        private System.Windows.Forms.LinkLabel linkViewSupplierOperations;
        private System.Windows.Forms.LinkLabel linkViewCustomerOperations;
        private System.Windows.Forms.GroupBox grbFinancialManagement;
        private System.Windows.Forms.LinkLabel linkViewDebitSummary;
        private System.Windows.Forms.LinkLabel linkViewExpense;
        private System.Windows.Forms.LinkLabel linkViewFinanceSummary;
        private System.Windows.Forms.LinkLabel linkViewCreditSummary;
        private System.Windows.Forms.LinkLabel linkViewFinanceDetails;
        private System.Windows.Forms.Label lblFinancialTitle;
    }
}



