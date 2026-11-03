namespace PresentationLayer
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.rdoCheck = new System.Windows.Forms.RadioButton();
            this.rdoCard = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.grpCashPayment = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtCartTotal = new System.Windows.Forms.TextBox();
            this.txtReceivedAmount = new System.Windows.Forms.TextBox();
            this.lblReceivedAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchByCode = new System.Windows.Forms.Button();
            this.btnSearchByDescription = new System.Windows.Forms.Button();
            this.lblSearchByDescription = new System.Windows.Forms.Label();
            this.txtSearchDescription = new System.Windows.Forms.TextBox();
            this.lblSearchByCode = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.grpEndOfDay = new System.Windows.Forms.GroupBox();
            this.btnEndDay = new System.Windows.Forms.Button();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.listCart = new System.Windows.Forms.ListView();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.gridSaleProducts = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomerByPhone = new System.Windows.Forms.Button();
            this.btnSearchCustomerByName = new System.Windows.Forms.Button();
            this.lblSearchByPhone = new System.Windows.Forms.Label();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerNationalId = new System.Windows.Forms.TextBox();
            this.lblCustomerNationalId = new System.Windows.Forms.Label();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tabDailyReports = new System.Windows.Forms.TabPage();
            this.grpDailyReport = new System.Windows.Forms.GroupBox();
            this.txtReportId = new System.Windows.Forms.TextBox();
            this.lblReportId = new System.Windows.Forms.Label();
            this.btnDeleteDailyReport = new System.Windows.Forms.Button();
            this.btnUpdateDailyReport = new System.Windows.Forms.Button();
            this.lblCashTotal = new System.Windows.Forms.Label();
            this.txtReportDate = new System.Windows.Forms.TextBox();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.btnSaveDailyReport = new System.Windows.Forms.Button();
            this.txtCardTotal = new System.Windows.Forms.TextBox();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.txtCashTotal = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtCheckTotal = new System.Windows.Forms.TextBox();
            this.lblCheckTotal = new System.Windows.Forms.Label();
            this.gridDailyReports = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.txtVatRate = new System.Windows.Forms.TextBox();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.tabBrands = new System.Windows.Forms.TabPage();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.gridBrands = new System.Windows.Forms.DataGridView();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.lblBrandId = new System.Windows.Forms.Label();
            this.tabUnits = new System.Windows.Forms.TabPage();
            this.btnUpdateUnit = new System.Windows.Forms.Button();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.gridUnits = new System.Windows.Forms.DataGridView();
            this.txtUnitId = new System.Windows.Forms.TextBox();
            this.lblUnitId = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.grpCategories = new System.Windows.Forms.GroupBox();
            this.grpSuppliers = new System.Windows.Forms.GroupBox();
            this.grpBrands = new System.Windows.Forms.GroupBox();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.grpPaymentType.SuspendLayout();
            this.grpCashPayment.SuspendLayout();
            this.grpProductSearch.SuspendLayout();
            this.grpEndOfDay.SuspendLayout();
            this.grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleProducts)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.grpCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.tabDailyReports.SuspendLayout();
            this.grpDailyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDailyReports)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.tabBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrands)).BeginInit();
            this.tabUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.grpProducts.SuspendLayout();
            this.grpCategories.SuspendLayout();
            this.grpSuppliers.SuspendLayout();
            this.grpBrands.SuspendLayout();
            this.grpUnits.SuspendLayout();
            this.grpUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.menuStrip.Size = new System.Drawing.Size(956, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(62, 24);
            this.helpMenuItem.Text = "Yardım";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(48, 24);
            this.exitMenuItem.Text = "Çıkış";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSales);
            this.tabControl.Controls.Add(this.tabCustomers);
            this.tabControl.Controls.Add(this.tabDailyReports);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabCategories);
            this.tabControl.Controls.Add(this.tabSuppliers);
            this.tabControl.Controls.Add(this.tabBrands);
            this.tabControl.Controls.Add(this.tabUnits);
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(956, 569);
            this.tabControl.TabIndex = 1;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.btnRemoveFromCart);
            this.tabSales.Controls.Add(this.btnAddToCart);
            this.tabSales.Controls.Add(this.grpPaymentType);
            this.tabSales.Controls.Add(this.grpCashPayment);
            this.tabSales.Controls.Add(this.grpProductSearch);
            this.tabSales.Controls.Add(this.grpEndOfDay);
            this.tabSales.Controls.Add(this.grpCart);
            this.tabSales.Controls.Add(this.gridSaleProducts);
            this.tabSales.Location = new System.Drawing.Point(4, 25);
            this.tabSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSales.Size = new System.Drawing.Size(948, 540);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Satış & Kasa";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(484, 150);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(103, 123);
            this.btnRemoveFromCart.TabIndex = 11;
            this.btnRemoveFromCart.Text = "ÜRÜNÜ SEPETTEN ÇIKAR";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(362, 150);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(103, 123);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "ÜRÜNÜ SEPETE EKLE";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.Controls.Add(this.rdoCheck);
            this.grpPaymentType.Controls.Add(this.rdoCard);
            this.grpPaymentType.Controls.Add(this.rdoCash);
            this.grpPaymentType.Location = new System.Drawing.Point(229, 150);
            this.grpPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Padding = new System.Windows.Forms.Padding(4);
            this.grpPaymentType.Size = new System.Drawing.Size(107, 123);
            this.grpPaymentType.TabIndex = 9;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "SATIŞ TÜRÜ";
            // 
            // rdoCheck
            // 
            this.rdoCheck.AutoSize = true;
            this.rdoCheck.Location = new System.Drawing.Point(21, 91);
            this.rdoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCheck.Name = "rdoCheck";
            this.rdoCheck.Size = new System.Drawing.Size(54, 20);
            this.rdoCheck.TabIndex = 2;
            this.rdoCheck.TabStop = true;
            this.rdoCheck.Text = "ÇEK";
            this.rdoCheck.UseVisualStyleBackColor = true;
            this.rdoCheck.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoCard
            // 
            this.rdoCard.AutoSize = true;
            this.rdoCard.Location = new System.Drawing.Point(21, 63);
            this.rdoCard.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCard.Name = "rdoCard";
            this.rdoCard.Size = new System.Drawing.Size(64, 20);
            this.rdoCard.TabIndex = 1;
            this.rdoCard.TabStop = true;
            this.rdoCard.Text = "KART";
            this.rdoCard.UseVisualStyleBackColor = true;
            this.rdoCard.CheckedChanged += new System.EventHandler(this.rdoCard_CheckedChanged);
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(21, 34);
            this.rdoCash.Margin = new System.Windows.Forms.Padding(4);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(67, 20);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "NAKİT";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // grpCashPayment
            // 
            this.grpCashPayment.Controls.Add(this.txtChange);
            this.grpCashPayment.Controls.Add(this.txtCartTotal);
            this.grpCashPayment.Controls.Add(this.txtReceivedAmount);
            this.grpCashPayment.Controls.Add(this.lblReceivedAmount);
            this.grpCashPayment.Controls.Add(this.lblChange);
            this.grpCashPayment.Controls.Add(this.lblCartTotal);
            this.grpCashPayment.Enabled = false;
            this.grpCashPayment.Location = new System.Drawing.Point(229, 273);
            this.grpCashPayment.Margin = new System.Windows.Forms.Padding(4);
            this.grpCashPayment.Name = "grpCashPayment";
            this.grpCashPayment.Padding = new System.Windows.Forms.Padding(4);
            this.grpCashPayment.Size = new System.Drawing.Size(358, 79);
            this.grpCashPayment.TabIndex = 8;
            this.grpCashPayment.TabStop = false;
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(255, 39);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(87, 22);
            this.txtChange.TabIndex = 10;
            // 
            // txtCartTotal
            // 
            this.txtCartTotal.Enabled = false;
            this.txtCartTotal.Location = new System.Drawing.Point(132, 39);
            this.txtCartTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCartTotal.Name = "txtCartTotal";
            this.txtCartTotal.Size = new System.Drawing.Size(107, 22);
            this.txtCartTotal.TabIndex = 9;
            // 
            // txtReceivedAmount
            // 
            this.txtReceivedAmount.Location = new System.Drawing.Point(18, 39);
            this.txtReceivedAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceivedAmount.Name = "txtReceivedAmount";
            this.txtReceivedAmount.Size = new System.Drawing.Size(99, 22);
            this.txtReceivedAmount.TabIndex = 8;
            // 
            // lblReceivedAmount
            // 
            this.lblReceivedAmount.AutoSize = true;
            this.lblReceivedAmount.Location = new System.Drawing.Point(15, 20);
            this.lblReceivedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedAmount.Name = "lblReceivedAmount";
            this.lblReceivedAmount.Size = new System.Drawing.Size(95, 16);
            this.lblReceivedAmount.TabIndex = 7;
            this.lblReceivedAmount.Text = "ALINAN PARA";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(251, 20);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(85, 16);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "PARA ÜSTÜ";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Location = new System.Drawing.Point(128, 20);
            this.lblCartTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(105, 16);
            this.lblCartTotal.TabIndex = 0;
            this.lblCartTotal.Text = "SEPET TUTARI";
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.btnSearchByCode);
            this.grpProductSearch.Controls.Add(this.btnSearchByDescription);
            this.grpProductSearch.Controls.Add(this.lblSearchByDescription);
            this.grpProductSearch.Controls.Add(this.txtSearchDescription);
            this.grpProductSearch.Controls.Add(this.lblSearchByCode);
            this.grpProductSearch.Controls.Add(this.txtSearchCode);
            this.grpProductSearch.Location = new System.Drawing.Point(228, 5);
            this.grpProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpProductSearch.Size = new System.Drawing.Size(359, 137);
            this.grpProductSearch.TabIndex = 5;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "ÜRÜN ARA";
            // 
            // btnSearchByCode
            // 
            this.btnSearchByCode.Location = new System.Drawing.Point(199, 90);
            this.btnSearchByCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchByCode.Name = "btnSearchByCode";
            this.btnSearchByCode.Size = new System.Drawing.Size(135, 28);
            this.btnSearchByCode.TabIndex = 6;
            this.btnSearchByCode.Text = "ARA";
            this.btnSearchByCode.UseVisualStyleBackColor = true;
            this.btnSearchByCode.Click += new System.EventHandler(this.btnSearchByCode_Click);
            // 
            // btnSearchByDescription
            // 
            this.btnSearchByDescription.Location = new System.Drawing.Point(22, 90);
            this.btnSearchByDescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchByDescription.Name = "btnSearchByDescription";
            this.btnSearchByDescription.Size = new System.Drawing.Size(135, 28);
            this.btnSearchByDescription.TabIndex = 5;
            this.btnSearchByDescription.Text = "ARA";
            this.btnSearchByDescription.UseVisualStyleBackColor = true;
            this.btnSearchByDescription.Click += new System.EventHandler(this.btnSearchByDescription_Click);
            // 
            // lblSearchByDescription
            // 
            this.lblSearchByDescription.AutoSize = true;
            this.lblSearchByDescription.Location = new System.Drawing.Point(26, 38);
            this.lblSearchByDescription.Name = "lblSearchByDescription";
            this.lblSearchByDescription.Size = new System.Drawing.Size(125, 16);
            this.lblSearchByDescription.TabIndex = 4;
            this.lblSearchByDescription.Text = "AÇIKLAMA İLE ARA";
            // 
            // txtSearchDescription
            // 
            this.txtSearchDescription.Location = new System.Drawing.Point(22, 59);
            this.txtSearchDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchDescription.Name = "txtSearchDescription";
            this.txtSearchDescription.Size = new System.Drawing.Size(133, 22);
            this.txtSearchDescription.TabIndex = 3;
            // 
            // lblSearchByCode
            // 
            this.lblSearchByCode.AutoSize = true;
            this.lblSearchByCode.Location = new System.Drawing.Point(221, 38);
            this.lblSearchByCode.Name = "lblSearchByCode";
            this.lblSearchByCode.Size = new System.Drawing.Size(88, 16);
            this.lblSearchByCode.TabIndex = 2;
            this.lblSearchByCode.Text = "KOD İLE ARA";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(199, 59);
            this.txtSearchCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(133, 22);
            this.txtSearchCode.TabIndex = 1;
            // 
            // grpEndOfDay
            // 
            this.grpEndOfDay.Controls.Add(this.btnEndDay);
            this.grpEndOfDay.Location = new System.Drawing.Point(8, 5);
            this.grpEndOfDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndOfDay.Name = "grpEndOfDay";
            this.grpEndOfDay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEndOfDay.Size = new System.Drawing.Size(213, 348);
            this.grpEndOfDay.TabIndex = 4;
            this.grpEndOfDay.TabStop = false;
            this.grpEndOfDay.Text = "GÜN SONU İŞLEMLERİ";
            // 
            // btnEndDay
            // 
            this.btnEndDay.Location = new System.Drawing.Point(0, 21);
            this.btnEndDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Size = new System.Drawing.Size(213, 320);
            this.btnEndDay.TabIndex = 12;
            this.btnEndDay.Text = "GÜNÜ BİTİR";
            this.btnEndDay.UseVisualStyleBackColor = true;
            this.btnEndDay.Click += new System.EventHandler(this.btnEndDay_Click);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.listCart);
            this.grpCart.Controls.Add(this.btnCompleteSale);
            this.grpCart.Location = new System.Drawing.Point(594, 5);
            this.grpCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCart.Name = "grpCart";
            this.grpCart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCart.Size = new System.Drawing.Size(348, 348);
            this.grpCart.TabIndex = 3;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "SEPET";
            // 
            // listCart
            // 
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(8, 18);
            this.listCart.Margin = new System.Windows.Forms.Padding(4);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(333, 282);
            this.listCart.TabIndex = 6;
            this.listCart.UseCompatibleStateImageBehavior = false;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Location = new System.Drawing.Point(7, 308);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(334, 33);
            this.btnCompleteSale.TabIndex = 5;
            this.btnCompleteSale.Text = "SEPETİ TAMAMLA";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // gridSaleProducts
            // 
            this.gridSaleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaleProducts.Location = new System.Drawing.Point(4, 358);
            this.gridSaleProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSaleProducts.Name = "gridSaleProducts";
            this.gridSaleProducts.RowHeadersWidth = 51;
            this.gridSaleProducts.RowTemplate.Height = 24;
            this.gridSaleProducts.Size = new System.Drawing.Size(936, 176);
            this.gridSaleProducts.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.grpCustomerSearch);
            this.tabCustomers.Controls.Add(this.txtCustomerPhone);
            this.tabCustomers.Controls.Add(this.lblCustomerPhone);
            this.tabCustomers.Controls.Add(this.txtCustomerAddress);
            this.tabCustomers.Controls.Add(this.lblCustomerAddress);
            this.tabCustomers.Controls.Add(this.txtCustomerName);
            this.tabCustomers.Controls.Add(this.lblCustomerName);
            this.tabCustomers.Controls.Add(this.btnUpdateCustomer);
            this.tabCustomers.Controls.Add(this.btnDeleteCustomer);
            this.tabCustomers.Controls.Add(this.btnAddCustomer);
            this.tabCustomers.Controls.Add(this.txtCustomerNationalId);
            this.tabCustomers.Controls.Add(this.lblCustomerNationalId);
            this.tabCustomers.Controls.Add(this.gridCustomers);
            this.tabCustomers.Controls.Add(this.txtCustomerId);
            this.tabCustomers.Controls.Add(this.lblCustomerId);
            this.tabCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCustomers.Size = new System.Drawing.Size(948, 540);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Müşteri";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.Controls.Add(this.btnSearchCustomerByPhone);
            this.grpCustomerSearch.Controls.Add(this.btnSearchCustomerByName);
            this.grpCustomerSearch.Controls.Add(this.lblSearchByPhone);
            this.grpCustomerSearch.Controls.Add(this.txtSearchPhone);
            this.grpCustomerSearch.Controls.Add(this.txtSearchName);
            this.grpCustomerSearch.Controls.Add(this.lblSearchByName);
            this.grpCustomerSearch.Location = new System.Drawing.Point(68, 343);
            this.grpCustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomerSearch.Size = new System.Drawing.Size(320, 117);
            this.grpCustomerSearch.TabIndex = 70;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "MÜŞTERİ ARA";
            // 
            // btnSearchCustomerByPhone
            // 
            this.btnSearchCustomerByPhone.Location = new System.Drawing.Point(173, 78);
            this.btnSearchCustomerByPhone.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomerByPhone.Name = "btnSearchCustomerByPhone";
            this.btnSearchCustomerByPhone.Size = new System.Drawing.Size(116, 28);
            this.btnSearchCustomerByPhone.TabIndex = 8;
            this.btnSearchCustomerByPhone.Text = "ARA";
            this.btnSearchCustomerByPhone.UseVisualStyleBackColor = true;
            this.btnSearchCustomerByPhone.Click += new System.EventHandler(this.btnSearchCustomerByPhone_Click);
            // 
            // btnSearchCustomerByName
            // 
            this.btnSearchCustomerByName.Location = new System.Drawing.Point(45, 78);
            this.btnSearchCustomerByName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomerByName.Name = "btnSearchCustomerByName";
            this.btnSearchCustomerByName.Size = new System.Drawing.Size(84, 28);
            this.btnSearchCustomerByName.TabIndex = 7;
            this.btnSearchCustomerByName.Text = "ARA";
            this.btnSearchCustomerByName.UseVisualStyleBackColor = true;
            this.btnSearchCustomerByName.Click += new System.EventHandler(this.btnSearchCustomerByName_Click);
            // 
            // lblSearchByPhone
            // 
            this.lblSearchByPhone.AutoSize = true;
            this.lblSearchByPhone.Location = new System.Drawing.Point(169, 28);
            this.lblSearchByPhone.Name = "lblSearchByPhone";
            this.lblSearchByPhone.Size = new System.Drawing.Size(108, 16);
            this.lblSearchByPhone.TabIndex = 8;
            this.lblSearchByPhone.Text = "TEL NO İLE ARA";
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(173, 47);
            this.txtSearchPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(115, 22);
            this.txtSearchPhone.TabIndex = 7;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(45, 47);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(83, 22);
            this.txtSearchName.TabIndex = 5;
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(41, 28);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(79, 16);
            this.lblSearchByName.TabIndex = 6;
            this.lblSearchByName.Text = "AD İLE ARA";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(105, 161);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerPhone.TabIndex = 69;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(65, 164);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(27, 16);
            this.lblCustomerPhone.TabIndex = 68;
            this.lblCustomerPhone.Text = "Tel";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(105, 130);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerAddress.TabIndex = 67;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(51, 134);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(43, 16);
            this.lblCustomerAddress.TabIndex = 66;
            this.lblCustomerAddress.Text = "Adres";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(105, 101);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerName.TabIndex = 65;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(65, 103);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(27, 16);
            this.lblCustomerName.TabIndex = 64;
            this.lblCustomerName.Text = "Adı";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(157, 215);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(133, 103);
            this.btnUpdateCustomer.TabIndex = 63;
            this.btnUpdateCustomer.Text = "Müşteri Düzenle";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(293, 215);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(133, 103);
            this.btnDeleteCustomer.TabIndex = 62;
            this.btnDeleteCustomer.Text = "Müşteri Sil";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 215);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(133, 103);
            this.btnAddCustomer.TabIndex = 61;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerNationalId
            // 
            this.txtCustomerNationalId.Location = new System.Drawing.Point(105, 71);
            this.txtCustomerNationalId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerNationalId.Name = "txtCustomerNationalId";
            this.txtCustomerNationalId.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerNationalId.TabIndex = 60;
            // 
            // lblCustomerNationalId
            // 
            this.lblCustomerNationalId.AutoSize = true;
            this.lblCustomerNationalId.Location = new System.Drawing.Point(67, 74);
            this.lblCustomerNationalId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerNationalId.Name = "lblCustomerNationalId";
            this.lblCustomerNationalId.Size = new System.Drawing.Size(25, 16);
            this.lblCustomerNationalId.TabIndex = 59;
            this.lblCustomerNationalId.Text = "TC";
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(468, 9);
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.RowHeadersWidth = 51;
            this.gridCustomers.Size = new System.Drawing.Size(471, 520);
            this.gridCustomers.TabIndex = 58;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(105, 39);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(245, 22);
            this.txtCustomerId.TabIndex = 57;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(73, 42);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(20, 16);
            this.lblCustomerId.TabIndex = 56;
            this.lblCustomerId.Text = "ID";
            // 
            // tabDailyReports
            // 
            this.tabDailyReports.Controls.Add(this.grpDailyReport);
            this.tabDailyReports.Controls.Add(this.gridDailyReports);
            this.tabDailyReports.Location = new System.Drawing.Point(4, 25);
            this.tabDailyReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDailyReports.Name = "tabDailyReports";
            this.tabDailyReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDailyReports.Size = new System.Drawing.Size(948, 540);
            this.tabDailyReports.TabIndex = 2;
            this.tabDailyReports.Text = "Günlük Rapor";
            this.tabDailyReports.UseVisualStyleBackColor = true;
            // 
            // grpDailyReport
            // 
            this.grpDailyReport.Controls.Add(this.txtReportId);
            this.grpDailyReport.Controls.Add(this.lblReportId);
            this.grpDailyReport.Controls.Add(this.btnDeleteDailyReport);
            this.grpDailyReport.Controls.Add(this.btnUpdateDailyReport);
            this.grpDailyReport.Controls.Add(this.lblCashTotal);
            this.grpDailyReport.Controls.Add(this.txtReportDate);
            this.grpDailyReport.Controls.Add(this.lblReportDate);
            this.grpDailyReport.Controls.Add(this.btnSaveDailyReport);
            this.grpDailyReport.Controls.Add(this.txtCardTotal);
            this.grpDailyReport.Controls.Add(this.lblCardTotal);
            this.grpDailyReport.Controls.Add(this.lblRevenue);
            this.grpDailyReport.Controls.Add(this.txtCashTotal);
            this.grpDailyReport.Controls.Add(this.txtRevenue);
            this.grpDailyReport.Controls.Add(this.txtCheckTotal);
            this.grpDailyReport.Controls.Add(this.lblCheckTotal);
            this.grpDailyReport.Location = new System.Drawing.Point(8, 5);
            this.grpDailyReport.Name = "grpDailyReport";
            this.grpDailyReport.Size = new System.Drawing.Size(927, 242);
            this.grpDailyReport.TabIndex = 16;
            this.grpDailyReport.TabStop = false;
            this.grpDailyReport.Text = "GÜNLÜK İŞLEMLER";
            // 
            // txtReportId
            // 
            this.txtReportId.Location = new System.Drawing.Point(288, 32);
            this.txtReportId.Margin = new System.Windows.Forms.Padding(4);
            this.txtReportId.Name = "txtReportId";
            this.txtReportId.Size = new System.Drawing.Size(133, 22);
            this.txtReportId.TabIndex = 19;
            // 
            // lblReportId
            // 
            this.lblReportId.AutoSize = true;
            this.lblReportId.Location = new System.Drawing.Point(252, 34);
            this.lblReportId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportId.Name = "lblReportId";
            this.lblReportId.Size = new System.Drawing.Size(20, 16);
            this.lblReportId.TabIndex = 18;
            this.lblReportId.Text = "ID";
            // 
            // btnDeleteDailyReport
            // 
            this.btnDeleteDailyReport.Location = new System.Drawing.Point(440, 169);
            this.btnDeleteDailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDailyReport.Name = "btnDeleteDailyReport";
            this.btnDeleteDailyReport.Size = new System.Drawing.Size(289, 41);
            this.btnDeleteDailyReport.TabIndex = 17;
            this.btnDeleteDailyReport.Text = "GÜNÜ SİL";
            this.btnDeleteDailyReport.UseVisualStyleBackColor = true;
            this.btnDeleteDailyReport.Click += new System.EventHandler(this.btnDeleteDailyReport_Click);
            // 
            // btnUpdateDailyReport
            // 
            this.btnUpdateDailyReport.Location = new System.Drawing.Point(440, 100);
            this.btnUpdateDailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDailyReport.Name = "btnUpdateDailyReport";
            this.btnUpdateDailyReport.Size = new System.Drawing.Size(289, 41);
            this.btnUpdateDailyReport.TabIndex = 16;
            this.btnUpdateDailyReport.Text = "GÜNÜ DÜZENLE";
            this.btnUpdateDailyReport.UseVisualStyleBackColor = true;
            this.btnUpdateDailyReport.Click += new System.EventHandler(this.btnUpdateDailyReport_Click);
            // 
            // lblCashTotal
            // 
            this.lblCashTotal.AutoSize = true;
            this.lblCashTotal.Location = new System.Drawing.Point(132, 130);
            this.lblCashTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashTotal.Name = "lblCashTotal";
            this.lblCashTotal.Size = new System.Drawing.Size(139, 16);
            this.lblCashTotal.TabIndex = 8;
            this.lblCashTotal.Text = "Toplam Nakit Ödenen";
            // 
            // txtReportDate
            // 
            this.txtReportDate.Location = new System.Drawing.Point(288, 62);
            this.txtReportDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Size = new System.Drawing.Size(133, 22);
            this.txtReportDate.TabIndex = 15;
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.Location = new System.Drawing.Point(238, 62);
            this.lblReportDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(38, 16);
            this.lblReportDate.TabIndex = 1;
            this.lblReportDate.Text = "Tarih";
            // 
            // btnSaveDailyReport
            // 
            this.btnSaveDailyReport.Location = new System.Drawing.Point(440, 32);
            this.btnSaveDailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDailyReport.Name = "btnSaveDailyReport";
            this.btnSaveDailyReport.Size = new System.Drawing.Size(289, 41);
            this.btnSaveDailyReport.TabIndex = 14;
            this.btnSaveDailyReport.Text = "GÜNÜ BİTİR";
            this.btnSaveDailyReport.UseVisualStyleBackColor = true;
            this.btnSaveDailyReport.Click += new System.EventHandler(this.btnSaveDailyReport_Click);
            // 
            // txtCardTotal
            // 
            this.txtCardTotal.Location = new System.Drawing.Point(288, 94);
            this.txtCardTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardTotal.Name = "txtCardTotal";
            this.txtCardTotal.Size = new System.Drawing.Size(132, 22);
            this.txtCardTotal.TabIndex = 5;
            // 
            // lblCardTotal
            // 
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Location = new System.Drawing.Point(129, 98);
            this.lblCardTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Size = new System.Drawing.Size(142, 16);
            this.lblCardTotal.TabIndex = 6;
            this.lblCardTotal.Text = "Toplam Kartla Ödenen";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(246, 194);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(31, 16);
            this.lblRevenue.TabIndex = 12;
            this.lblRevenue.Text = "Ciro";
            // 
            // txtCashTotal
            // 
            this.txtCashTotal.Location = new System.Drawing.Point(288, 126);
            this.txtCashTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashTotal.Name = "txtCashTotal";
            this.txtCashTotal.Size = new System.Drawing.Size(132, 22);
            this.txtCashTotal.TabIndex = 7;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(288, 190);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(132, 22);
            this.txtRevenue.TabIndex = 11;
            // 
            // txtCheckTotal
            // 
            this.txtCheckTotal.Location = new System.Drawing.Point(288, 158);
            this.txtCheckTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckTotal.Name = "txtCheckTotal";
            this.txtCheckTotal.Size = new System.Drawing.Size(132, 22);
            this.txtCheckTotal.TabIndex = 9;
            // 
            // lblCheckTotal
            // 
            this.lblCheckTotal.AutoSize = true;
            this.lblCheckTotal.Location = new System.Drawing.Point(140, 162);
            this.lblCheckTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckTotal.Name = "lblCheckTotal";
            this.lblCheckTotal.Size = new System.Drawing.Size(132, 16);
            this.lblCheckTotal.TabIndex = 10;
            this.lblCheckTotal.Text = "Toplam Cek Ödenen";
            // 
            // gridDailyReports
            // 
            this.gridDailyReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDailyReports.Location = new System.Drawing.Point(7, 254);
            this.gridDailyReports.Margin = new System.Windows.Forms.Padding(4);
            this.gridDailyReports.Name = "gridDailyReports";
            this.gridDailyReports.RowHeadersWidth = 51;
            this.gridDailyReports.Size = new System.Drawing.Size(928, 277);
            this.gridDailyReports.TabIndex = 13;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.grpProducts);
            this.tabProducts.Controls.Add(this.gridProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 25);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducts.Size = new System.Drawing.Size(948, 540);
            this.tabProducts.TabIndex = 3;
            this.tabProducts.Text = "Ürün İşlemleri";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(288, 325);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(133, 103);
            this.btnUpdateProduct.TabIndex = 32;
            this.btnUpdateProduct.Text = "Ürün Düzenle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(288, 207);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(133, 103);
            this.btnDeleteProduct.TabIndex = 31;
            this.btnDeleteProduct.Text = "Ürün Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(106, 377);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(137, 24);
            this.cmbSupplier.TabIndex = 30;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(106, 347);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(137, 24);
            this.cmbBrand.TabIndex = 29;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(106, 317);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(137, 24);
            this.cmbCategory.TabIndex = 28;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(106, 286);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(137, 24);
            this.cmbUnit.TabIndex = 27;
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(40, 380);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(60, 16);
            this.lblProductSupplier.TabIndex = 25;
            this.lblProductSupplier.Text = "Toptancı";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(55, 350);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(45, 16);
            this.lblProductBrand.TabIndex = 23;
            this.lblProductBrand.Text = "Marka";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(43, 320);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(57, 16);
            this.lblProductCategory.TabIndex = 21;
            this.lblProductCategory.Text = "Kategori";
            // 
            // lblProductUnit
            // 
            this.lblProductUnit.AutoSize = true;
            this.lblProductUnit.Location = new System.Drawing.Point(63, 290);
            this.lblProductUnit.Name = "lblProductUnit";
            this.lblProductUnit.Size = new System.Drawing.Size(37, 16);
            this.lblProductUnit.TabIndex = 19;
            this.lblProductUnit.Text = "Birim";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(66, 261);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(34, 16);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stok";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(106, 258);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(137, 22);
            this.txtStock.TabIndex = 14;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(36, 235);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(64, 16);
            this.lblPurchasePrice.TabIndex = 13;
            this.lblPurchasePrice.Text = "Alış Fiyatı";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(106, 230);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(137, 22);
            this.txtPurchasePrice.TabIndex = 10;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(28, 205);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(72, 16);
            this.lblSalePrice.TabIndex = 9;
            this.lblSalePrice.Text = "Satış Fiyatı";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(106, 202);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(137, 22);
            this.txtSalePrice.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Açıklama";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 174);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(137, 22);
            this.txtDescription.TabIndex = 6;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(68, 149);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(31, 16);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Kod";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(106, 145);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(137, 22);
            this.txtCode.TabIndex = 4;
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(468, 6);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(472, 525);
            this.gridProducts.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(288, 90);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 103);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(80, 121);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(20, 16);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "ID";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(106, 118);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(137, 22);
            this.txtProductId.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.grpCategories);
            this.tabCategories.Controls.Add(this.gridCategories);
            this.tabCategories.Location = new System.Drawing.Point(4, 25);
            this.tabCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCategories.Size = new System.Drawing.Size(948, 540);
            this.tabCategories.TabIndex = 4;
            this.tabCategories.Text = "Kategori İşlemleri";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // txtVatRate
            // 
            this.txtVatRate.Location = new System.Drawing.Point(119, 150);
            this.txtVatRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtVatRate.Name = "txtVatRate";
            this.txtVatRate.Size = new System.Drawing.Size(245, 22);
            this.txtVatRate.TabIndex = 45;
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Location = new System.Drawing.Point(81, 152);
            this.lblVatRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(34, 16);
            this.lblVatRate.TabIndex = 44;
            this.lblVatRate.Text = "KDV";
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(231, 195);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(133, 103);
            this.btnUpdateCategory.TabIndex = 43;
            this.btnUpdateCategory.Text = "Kategori Düzenle";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(84, 311);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(280, 103);
            this.btnDeleteCategory.TabIndex = 42;
            this.btnDeleteCategory.Text = "Kategori Sil";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(84, 195);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(133, 103);
            this.btnAddCategory.TabIndex = 41;
            this.btnAddCategory.Text = "Kategori Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(119, 119);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(245, 22);
            this.txtCategoryName.TabIndex = 40;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(81, 122);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(27, 16);
            this.lblCategoryName.TabIndex = 39;
            this.lblCategoryName.Text = "Adı";
            // 
            // gridCategories
            // 
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Location = new System.Drawing.Point(472, 6);
            this.gridCategories.Margin = new System.Windows.Forms.Padding(4);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.RowHeadersWidth = 51;
            this.gridCategories.Size = new System.Drawing.Size(468, 528);
            this.gridCategories.TabIndex = 38;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(119, 87);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(245, 22);
            this.txtCategoryId.TabIndex = 37;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(87, 90);
            this.lblCategoryId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(20, 16);
            this.lblCategoryId.TabIndex = 36;
            this.lblCategoryId.Text = "ID";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.grpSuppliers);
            this.tabSuppliers.Controls.Add(this.gridSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSuppliers.Size = new System.Drawing.Size(948, 540);
            this.tabSuppliers.TabIndex = 5;
            this.tabSuppliers.Text = "Toptancı İşlemleri";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(122, 151);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(245, 22);
            this.txtSupplierPhone.TabIndex = 55;
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Location = new System.Drawing.Point(84, 154);
            this.lblSupplierPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(27, 16);
            this.lblSupplierPhone.TabIndex = 54;
            this.lblSupplierPhone.Text = "Tel";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(122, 122);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(245, 22);
            this.txtSupplierAddress.TabIndex = 53;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Location = new System.Drawing.Point(68, 124);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(43, 16);
            this.lblSupplierAddress.TabIndex = 52;
            this.lblSupplierAddress.Text = "Adres";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(220, 190);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(147, 103);
            this.btnUpdateSupplier.TabIndex = 51;
            this.btnUpdateSupplier.Text = "Toptancı Düzenle";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(71, 299);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(296, 103);
            this.btnDeleteSupplier.TabIndex = 50;
            this.btnDeleteSupplier.Text = "Toptancı Sil";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(71, 190);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(143, 103);
            this.btnAddSupplier.TabIndex = 49;
            this.btnAddSupplier.Text = "Toptancı Ekle";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(122, 91);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(245, 22);
            this.txtSupplierName.TabIndex = 48;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(84, 95);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(27, 16);
            this.lblSupplierName.TabIndex = 47;
            this.lblSupplierName.Text = "Adı";
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Location = new System.Drawing.Point(468, 5);
            this.gridSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.RowHeadersWidth = 51;
            this.gridSuppliers.Size = new System.Drawing.Size(471, 529);
            this.gridSuppliers.TabIndex = 46;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(122, 59);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(245, 22);
            this.txtSupplierId.TabIndex = 45;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(90, 63);
            this.lblSupplierId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(20, 16);
            this.lblSupplierId.TabIndex = 44;
            this.lblSupplierId.Text = "ID";
            // 
            // tabBrands
            // 
            this.tabBrands.Controls.Add(this.grpBrands);
            this.tabBrands.Controls.Add(this.gridBrands);
            this.tabBrands.Location = new System.Drawing.Point(4, 25);
            this.tabBrands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBrands.Name = "tabBrands";
            this.tabBrands.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBrands.Size = new System.Drawing.Size(948, 540);
            this.tabBrands.TabIndex = 6;
            this.tabBrands.Text = "Marka İşlemleri";
            this.tabBrands.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(226, 176);
            this.btnUpdateBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(133, 103);
            this.btnUpdateBrand.TabIndex = 43;
            this.btnUpdateBrand.Text = "Marka Düzenle";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Location = new System.Drawing.Point(80, 293);
            this.btnDeleteBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(279, 103);
            this.btnDeleteBrand.TabIndex = 42;
            this.btnDeleteBrand.Text = "Marka Sil";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(80, 176);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(133, 103);
            this.btnAddBrand.TabIndex = 41;
            this.btnAddBrand.Text = "Marka Ekle";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(114, 135);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(245, 22);
            this.txtBrandName.TabIndex = 40;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(77, 138);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(27, 16);
            this.lblBrandName.TabIndex = 39;
            this.lblBrandName.Text = "Adı";
            // 
            // gridBrands
            // 
            this.gridBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBrands.Location = new System.Drawing.Point(457, 9);
            this.gridBrands.Margin = new System.Windows.Forms.Padding(4);
            this.gridBrands.Name = "gridBrands";
            this.gridBrands.RowHeadersWidth = 51;
            this.gridBrands.Size = new System.Drawing.Size(482, 520);
            this.gridBrands.TabIndex = 38;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Location = new System.Drawing.Point(114, 103);
            this.txtBrandId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(245, 22);
            this.txtBrandId.TabIndex = 37;
            // 
            // lblBrandId
            // 
            this.lblBrandId.AutoSize = true;
            this.lblBrandId.Location = new System.Drawing.Point(82, 106);
            this.lblBrandId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrandId.Name = "lblBrandId";
            this.lblBrandId.Size = new System.Drawing.Size(20, 16);
            this.lblBrandId.TabIndex = 36;
            this.lblBrandId.Text = "ID";
            // 
            // tabUnits
            // 
            this.tabUnits.Controls.Add(this.grpUnits);
            this.tabUnits.Controls.Add(this.gridUnits);
            this.tabUnits.Location = new System.Drawing.Point(4, 25);
            this.tabUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUnits.Name = "tabUnits";
            this.tabUnits.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUnits.Size = new System.Drawing.Size(948, 540);
            this.tabUnits.TabIndex = 7;
            this.tabUnits.Text = "Birim İşlemleri";
            this.tabUnits.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.Location = new System.Drawing.Point(227, 177);
            this.btnUpdateUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(133, 103);
            this.btnUpdateUnit.TabIndex = 35;
            this.btnUpdateUnit.Text = "Birim Düzenle";
            this.btnUpdateUnit.UseVisualStyleBackColor = true;
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Location = new System.Drawing.Point(80, 294);
            this.btnDeleteUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(280, 103);
            this.btnDeleteUnit.TabIndex = 34;
            this.btnDeleteUnit.Text = "Birim Sil";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(80, 177);
            this.btnAddUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(133, 103);
            this.btnAddUnit.TabIndex = 33;
            this.btnAddUnit.Text = "Birim Ekle";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(115, 131);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(245, 22);
            this.txtUnitName.TabIndex = 8;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(77, 134);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(27, 16);
            this.lblUnitName.TabIndex = 7;
            this.lblUnitName.Text = "Adı";
            // 
            // gridUnits
            // 
            this.gridUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnits.Location = new System.Drawing.Point(467, 6);
            this.gridUnits.Margin = new System.Windows.Forms.Padding(4);
            this.gridUnits.Name = "gridUnits";
            this.gridUnits.RowHeadersWidth = 51;
            this.gridUnits.Size = new System.Drawing.Size(471, 525);
            this.gridUnits.TabIndex = 6;
            // 
            // txtUnitId
            // 
            this.txtUnitId.Location = new System.Drawing.Point(115, 99);
            this.txtUnitId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitId.Name = "txtUnitId";
            this.txtUnitId.Size = new System.Drawing.Size(245, 22);
            this.txtUnitId.TabIndex = 4;
            // 
            // lblUnitId
            // 
            this.lblUnitId.AutoSize = true;
            this.lblUnitId.Location = new System.Drawing.Point(83, 102);
            this.lblUnitId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitId.Name = "lblUnitId";
            this.lblUnitId.Size = new System.Drawing.Size(20, 16);
            this.lblUnitId.TabIndex = 3;
            this.lblUnitId.Text = "ID";
            // 
            // tabUsers
            // 
            this.tabUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabUsers.Controls.Add(this.grpUsers);
            this.tabUsers.Controls.Add(this.gridUsers);
            this.tabUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabUsers.Location = new System.Drawing.Point(4, 25);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Size = new System.Drawing.Size(948, 540);
            this.tabUsers.TabIndex = 8;
            this.tabUsers.Text = "Kullanıcı İşlemleri";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(466, 7);
            this.gridUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RowHeadersWidth = 51;
            this.gridUsers.RowTemplate.Height = 24;
            this.gridUsers.Size = new System.Drawing.Size(472, 524);
            this.gridUsers.TabIndex = 18;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(183, 186);
            this.chkIsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(59, 20);
            this.chkIsAdmin.TabIndex = 17;
            this.chkIsAdmin.Text = "Yetki";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(222, 226);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(108, 108);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Kullanıcı Ekle";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(143, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Şifre";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(97, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 147);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(147, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(183, 108);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.txtProductId);
            this.grpProducts.Controls.Add(this.btnUpdateProduct);
            this.grpProducts.Controls.Add(this.lblProductId);
            this.grpProducts.Controls.Add(this.btnDeleteProduct);
            this.grpProducts.Controls.Add(this.btnAddProduct);
            this.grpProducts.Controls.Add(this.cmbSupplier);
            this.grpProducts.Controls.Add(this.txtCode);
            this.grpProducts.Controls.Add(this.cmbBrand);
            this.grpProducts.Controls.Add(this.lblCode);
            this.grpProducts.Controls.Add(this.cmbCategory);
            this.grpProducts.Controls.Add(this.txtDescription);
            this.grpProducts.Controls.Add(this.cmbUnit);
            this.grpProducts.Controls.Add(this.lblDescription);
            this.grpProducts.Controls.Add(this.lblProductSupplier);
            this.grpProducts.Controls.Add(this.txtSalePrice);
            this.grpProducts.Controls.Add(this.lblProductBrand);
            this.grpProducts.Controls.Add(this.lblSalePrice);
            this.grpProducts.Controls.Add(this.lblProductCategory);
            this.grpProducts.Controls.Add(this.txtPurchasePrice);
            this.grpProducts.Controls.Add(this.lblProductUnit);
            this.grpProducts.Controls.Add(this.lblPurchasePrice);
            this.grpProducts.Controls.Add(this.lblStock);
            this.grpProducts.Controls.Add(this.txtStock);
            this.grpProducts.Location = new System.Drawing.Point(8, 6);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(454, 525);
            this.grpProducts.TabIndex = 33;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // grpCategories
            // 
            this.grpCategories.Controls.Add(this.lblCategoryId);
            this.grpCategories.Controls.Add(this.txtVatRate);
            this.grpCategories.Controls.Add(this.txtCategoryId);
            this.grpCategories.Controls.Add(this.lblVatRate);
            this.grpCategories.Controls.Add(this.lblCategoryName);
            this.grpCategories.Controls.Add(this.btnUpdateCategory);
            this.grpCategories.Controls.Add(this.txtCategoryName);
            this.grpCategories.Controls.Add(this.btnDeleteCategory);
            this.grpCategories.Controls.Add(this.btnAddCategory);
            this.grpCategories.Location = new System.Drawing.Point(8, 6);
            this.grpCategories.Name = "grpCategories";
            this.grpCategories.Size = new System.Drawing.Size(457, 528);
            this.grpCategories.TabIndex = 46;
            this.grpCategories.TabStop = false;
            this.grpCategories.Text = "KATEGORİ İŞLEMLERİ";
            // 
            // grpSuppliers
            // 
            this.grpSuppliers.Controls.Add(this.txtSupplierId);
            this.grpSuppliers.Controls.Add(this.txtSupplierPhone);
            this.grpSuppliers.Controls.Add(this.lblSupplierId);
            this.grpSuppliers.Controls.Add(this.lblSupplierPhone);
            this.grpSuppliers.Controls.Add(this.lblSupplierName);
            this.grpSuppliers.Controls.Add(this.txtSupplierAddress);
            this.grpSuppliers.Controls.Add(this.txtSupplierName);
            this.grpSuppliers.Controls.Add(this.lblSupplierAddress);
            this.grpSuppliers.Controls.Add(this.btnAddSupplier);
            this.grpSuppliers.Controls.Add(this.btnUpdateSupplier);
            this.grpSuppliers.Controls.Add(this.btnDeleteSupplier);
            this.grpSuppliers.Location = new System.Drawing.Point(6, 5);
            this.grpSuppliers.Name = "grpSuppliers";
            this.grpSuppliers.Size = new System.Drawing.Size(455, 530);
            this.grpSuppliers.TabIndex = 56;
            this.grpSuppliers.TabStop = false;
            this.grpSuppliers.Text = "TOPTANCI İŞLEMLERİ";
            // 
            // grpBrands
            // 
            this.grpBrands.Controls.Add(this.txtBrandId);
            this.grpBrands.Controls.Add(this.btnUpdateBrand);
            this.grpBrands.Controls.Add(this.lblBrandId);
            this.grpBrands.Controls.Add(this.btnDeleteBrand);
            this.grpBrands.Controls.Add(this.lblBrandName);
            this.grpBrands.Controls.Add(this.btnAddBrand);
            this.grpBrands.Controls.Add(this.txtBrandName);
            this.grpBrands.Location = new System.Drawing.Point(8, 5);
            this.grpBrands.Name = "grpBrands";
            this.grpBrands.Size = new System.Drawing.Size(442, 525);
            this.grpBrands.TabIndex = 44;
            this.grpBrands.TabStop = false;
            this.grpBrands.Text = "MARKA İŞLEMLERİ";
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.txtUnitId);
            this.grpUnits.Controls.Add(this.btnUpdateUnit);
            this.grpUnits.Controls.Add(this.lblUnitId);
            this.grpUnits.Controls.Add(this.btnDeleteUnit);
            this.grpUnits.Controls.Add(this.lblUnitName);
            this.grpUnits.Controls.Add(this.btnAddUnit);
            this.grpUnits.Controls.Add(this.txtUnitName);
            this.grpUnits.Location = new System.Drawing.Point(8, 6);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(449, 525);
            this.grpUnits.TabIndex = 36;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "BİRİM İŞLEMLERİ";
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.btnUpdateUser);
            this.grpUsers.Controls.Add(this.txtUserId);
            this.grpUsers.Controls.Add(this.lblUserId);
            this.grpUsers.Controls.Add(this.btnDeleteUser);
            this.grpUsers.Controls.Add(this.txtUsername);
            this.grpUsers.Controls.Add(this.txtPassword);
            this.grpUsers.Controls.Add(this.chkIsAdmin);
            this.grpUsers.Controls.Add(this.lblUsername);
            this.grpUsers.Controls.Add(this.btnAddUser);
            this.grpUsers.Controls.Add(this.lblPassword);
            this.grpUsers.Location = new System.Drawing.Point(6, 5);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(454, 525);
            this.grpUsers.TabIndex = 19;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "KULLANICI İŞLEMLERİ";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(100, 226);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(108, 108);
            this.btnDeleteUser.TabIndex = 18;
            this.btnDeleteUser.Text = "Kullanıcı Sil";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(156, 72);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(20, 16);
            this.lblUserId.TabIndex = 19;
            this.lblUserId.Text = "ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(183, 69);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(147, 22);
            this.txtUserId.TabIndex = 20;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(100, 348);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(230, 108);
            this.btnUpdateUser.TabIndex = 21;
            this.btnUpdateUser.Text = "Kullanıcı Güncelle";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 594);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Market Otomasyonu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            this.grpCashPayment.ResumeLayout(false);
            this.grpCashPayment.PerformLayout();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            this.grpEndOfDay.ResumeLayout(false);
            this.grpCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleProducts)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.tabDailyReports.ResumeLayout(false);
            this.grpDailyReport.ResumeLayout(false);
            this.grpDailyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDailyReports)).EndInit();
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.tabCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.tabBrands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBrands)).EndInit();
            this.tabUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnits)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            this.grpCategories.ResumeLayout(false);
            this.grpCategories.PerformLayout();
            this.grpSuppliers.ResumeLayout(false);
            this.grpSuppliers.PerformLayout();
            this.grpBrands.ResumeLayout(false);
            this.grpBrands.PerformLayout();
            this.grpUnits.ResumeLayout(false);
            this.grpUnits.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView gridUnits;
        private System.Windows.Forms.TextBox txtUnitId;
        private System.Windows.Forms.Label lblUnitId;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Button btnUpdateUnit;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtVatRate;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.DataGridView gridBrands;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Label lblBrandId;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.DataGridView gridSuppliers;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerNationalId;
        private System.Windows.Forms.Label lblCustomerNationalId;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.DataGridView gridUsers;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabSales;
        public System.Windows.Forms.TabPage tabCustomers;
        public System.Windows.Forms.TabPage tabDailyReports;
        public System.Windows.Forms.TabPage tabProducts;
        public System.Windows.Forms.TabPage tabCategories;
        public System.Windows.Forms.TabPage tabSuppliers;
        public System.Windows.Forms.TabPage tabBrands;
        public System.Windows.Forms.TabPage tabUnits;
        public System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.GroupBox grpEndOfDay;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label lblSearchByCode;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.DataGridView gridSaleProducts;
        private System.Windows.Forms.GroupBox grpCashPayment;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.Label lblSearchByDescription;
        private System.Windows.Forms.TextBox txtSearchDescription;
        private System.Windows.Forms.TextBox txtReceivedAmount;
        private System.Windows.Forms.Label lblReceivedAmount;
        private System.Windows.Forms.Button btnSearchByCode;
        private System.Windows.Forms.Button btnSearchByDescription;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.Button btnSearchCustomerByPhone;
        private System.Windows.Forms.Button btnSearchCustomerByName;
        private System.Windows.Forms.Label lblSearchByPhone;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtCartTotal;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.RadioButton rdoCheck;
        private System.Windows.Forms.RadioButton rdoCard;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.DataGridView gridDailyReports;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCheckTotal;
        private System.Windows.Forms.Label lblCashTotal;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.Button btnEndDay;
        private System.Windows.Forms.Button btnSaveDailyReport;
        private System.Windows.Forms.TextBox txtReportDate;
        private System.Windows.Forms.GroupBox grpDailyReport;
        private System.Windows.Forms.TextBox txtReportId;
        private System.Windows.Forms.Label lblReportId;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.GroupBox grpCategories;
        private System.Windows.Forms.GroupBox grpSuppliers;
        private System.Windows.Forms.GroupBox grpBrands;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnUpdateUser;
        public System.Windows.Forms.TextBox txtRevenue;
        public System.Windows.Forms.TextBox txtCheckTotal;
        public System.Windows.Forms.TextBox txtCashTotal;
        public System.Windows.Forms.TextBox txtCardTotal;
        public System.Windows.Forms.Button btnDeleteDailyReport;
        public System.Windows.Forms.Button btnUpdateDailyReport;
    }
}