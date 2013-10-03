namespace CSIT2220_Lab3
{
    partial class uiMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDrinkType = new System.Windows.Forms.GroupBox();
            this.rbtTypeNone = new System.Windows.Forms.RadioButton();
            this.grpSmoothie = new System.Windows.Forms.GroupBox();
            this.rbtTypeWheatBerry = new System.Windows.Forms.RadioButton();
            this.rbtTypeStrawberryBanana = new System.Windows.Forms.RadioButton();
            this.rbtTypePomegranate = new System.Windows.Forms.RadioButton();
            this.grpJuice = new System.Windows.Forms.GroupBox();
            this.rbtTypeVegetable = new System.Windows.Forms.RadioButton();
            this.rbtTypeFruit = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbtSizeNone = new System.Windows.Forms.RadioButton();
            this.rbtSize20 = new System.Windows.Forms.RadioButton();
            this.rbtSize16 = new System.Windows.Forms.RadioButton();
            this.rbtSize12 = new System.Windows.Forms.RadioButton();
            this.grpAdditives = new System.Windows.Forms.GroupBox();
            this.cbxAddCoolDownRemedey = new System.Windows.Forms.CheckBox();
            this.cbxAddEnergyBooster = new System.Windows.Forms.CheckBox();
            this.cbxAddVitaminPack = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnDrinkAdd = new System.Windows.Forms.Button();
            this.btnDrinkClear = new System.Windows.Forms.Button();
            this.grpDrinkInfo = new System.Windows.Forms.GroupBox();
            this.tbxDrinkPrice = new System.Windows.Forms.TextBox();
            this.lblDrinkPrice = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.btnOrderClear = new System.Windows.Forms.Button();
            this.tbxOrdertTotal = new System.Windows.Forms.TextBox();
            this.btnOrderSubmit = new System.Windows.Forms.Button();
            this.tbxOrderItems = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpDrinkType.SuspendLayout();
            this.grpSmoothie.SuspendLayout();
            this.grpJuice.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpAdditives.SuspendLayout();
            this.grpDrinkInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.veiwToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.clearDrinkToolStripMenuItem,
            this.submitOrderToolStripMenuItem,
            this.clearOrderToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addToOrderToolStripMenuItem.Text = "&Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderToolStripMenuItem_Click);
            // 
            // clearDrinkToolStripMenuItem
            // 
            this.clearDrinkToolStripMenuItem.Name = "clearDrinkToolStripMenuItem";
            this.clearDrinkToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clearDrinkToolStripMenuItem.Text = "C&lear Drink";
            this.clearDrinkToolStripMenuItem.Click += new System.EventHandler(this.clearDrinkToolStripMenuItem_Click);
            // 
            // submitOrderToolStripMenuItem
            // 
            this.submitOrderToolStripMenuItem.Name = "submitOrderToolStripMenuItem";
            this.submitOrderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.submitOrderToolStripMenuItem.Text = "Submit &Order";
            this.submitOrderToolStripMenuItem.Click += new System.EventHandler(this.submitOrderToolStripMenuItem_Click);
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clearOrderToolStripMenuItem.Text = "&Clear Order";
            this.clearOrderToolStripMenuItem.Click += new System.EventHandler(this.clearOrderToolStripMenuItem_Click);
            // 
            // veiwToolStripMenuItem
            // 
            this.veiwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.veiwToolStripMenuItem.Name = "veiwToolStripMenuItem";
            this.veiwToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.veiwToolStripMenuItem.Text = "&Veiw";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpDrinkType
            // 
            this.grpDrinkType.Controls.Add(this.rbtTypeNone);
            this.grpDrinkType.Controls.Add(this.grpSmoothie);
            this.grpDrinkType.Controls.Add(this.grpJuice);
            this.grpDrinkType.Location = new System.Drawing.Point(14, 42);
            this.grpDrinkType.Name = "grpDrinkType";
            this.grpDrinkType.Size = new System.Drawing.Size(336, 136);
            this.grpDrinkType.TabIndex = 1;
            this.grpDrinkType.TabStop = false;
            this.grpDrinkType.Text = "Drink Type";
            // 
            // rbtTypeNone
            // 
            this.rbtTypeNone.AutoCheck = false;
            this.rbtTypeNone.AutoSize = true;
            this.rbtTypeNone.Checked = true;
            this.rbtTypeNone.Location = new System.Drawing.Point(76, 9);
            this.rbtTypeNone.Name = "rbtTypeNone";
            this.rbtTypeNone.Size = new System.Drawing.Size(67, 17);
            this.rbtTypeNone.TabIndex = 2;
            this.rbtTypeNone.TabStop = true;
            this.rbtTypeNone.Text = "No Drink";
            this.rbtTypeNone.UseVisualStyleBackColor = true;
            this.rbtTypeNone.Visible = false;
            // 
            // grpSmoothie
            // 
            this.grpSmoothie.Controls.Add(this.rbtTypeWheatBerry);
            this.grpSmoothie.Controls.Add(this.rbtTypeStrawberryBanana);
            this.grpSmoothie.Controls.Add(this.rbtTypePomegranate);
            this.grpSmoothie.Location = new System.Drawing.Point(177, 21);
            this.grpSmoothie.Name = "grpSmoothie";
            this.grpSmoothie.Size = new System.Drawing.Size(137, 96);
            this.grpSmoothie.TabIndex = 1;
            this.grpSmoothie.TabStop = false;
            this.grpSmoothie.Text = "Smoothies";
            // 
            // rbtTypeWheatBerry
            // 
            this.rbtTypeWheatBerry.AutoCheck = false;
            this.rbtTypeWheatBerry.AutoSize = true;
            this.rbtTypeWheatBerry.Location = new System.Drawing.Point(15, 65);
            this.rbtTypeWheatBerry.Name = "rbtTypeWheatBerry";
            this.rbtTypeWheatBerry.Size = new System.Drawing.Size(84, 17);
            this.rbtTypeWheatBerry.TabIndex = 2;
            this.rbtTypeWheatBerry.Text = "Wheat Berry";
            this.rbtTypeWheatBerry.UseVisualStyleBackColor = true;
            // 
            // rbtTypeStrawberryBanana
            // 
            this.rbtTypeStrawberryBanana.AutoCheck = false;
            this.rbtTypeStrawberryBanana.AutoSize = true;
            this.rbtTypeStrawberryBanana.Location = new System.Drawing.Point(15, 42);
            this.rbtTypeStrawberryBanana.Name = "rbtTypeStrawberryBanana";
            this.rbtTypeStrawberryBanana.Size = new System.Drawing.Size(115, 17);
            this.rbtTypeStrawberryBanana.TabIndex = 1;
            this.rbtTypeStrawberryBanana.Text = "Strawberry-Banana";
            this.rbtTypeStrawberryBanana.UseVisualStyleBackColor = true;
            // 
            // rbtTypePomegranate
            // 
            this.rbtTypePomegranate.AutoCheck = false;
            this.rbtTypePomegranate.AutoSize = true;
            this.rbtTypePomegranate.Location = new System.Drawing.Point(15, 19);
            this.rbtTypePomegranate.Name = "rbtTypePomegranate";
            this.rbtTypePomegranate.Size = new System.Drawing.Size(88, 17);
            this.rbtTypePomegranate.TabIndex = 0;
            this.rbtTypePomegranate.Text = "Pomegranate";
            this.rbtTypePomegranate.UseVisualStyleBackColor = true;
            // 
            // grpJuice
            // 
            this.grpJuice.Controls.Add(this.rbtTypeVegetable);
            this.grpJuice.Controls.Add(this.rbtTypeFruit);
            this.grpJuice.Location = new System.Drawing.Point(18, 21);
            this.grpJuice.Name = "grpJuice";
            this.grpJuice.Size = new System.Drawing.Size(143, 96);
            this.grpJuice.TabIndex = 0;
            this.grpJuice.TabStop = false;
            this.grpJuice.Text = "Juices";
            // 
            // rbtTypeVegetable
            // 
            this.rbtTypeVegetable.AutoCheck = false;
            this.rbtTypeVegetable.AutoSize = true;
            this.rbtTypeVegetable.Location = new System.Drawing.Point(15, 42);
            this.rbtTypeVegetable.Name = "rbtTypeVegetable";
            this.rbtTypeVegetable.Size = new System.Drawing.Size(73, 17);
            this.rbtTypeVegetable.TabIndex = 1;
            this.rbtTypeVegetable.Text = "Vegetable";
            this.rbtTypeVegetable.UseVisualStyleBackColor = true;
            // 
            // rbtTypeFruit
            // 
            this.rbtTypeFruit.AutoCheck = false;
            this.rbtTypeFruit.AutoSize = true;
            this.rbtTypeFruit.Location = new System.Drawing.Point(15, 19);
            this.rbtTypeFruit.Name = "rbtTypeFruit";
            this.rbtTypeFruit.Size = new System.Drawing.Size(45, 17);
            this.rbtTypeFruit.TabIndex = 0;
            this.rbtTypeFruit.Text = "Fruit";
            this.rbtTypeFruit.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rbtSizeNone);
            this.grpSize.Controls.Add(this.rbtSize20);
            this.grpSize.Controls.Add(this.rbtSize16);
            this.grpSize.Controls.Add(this.rbtSize12);
            this.grpSize.Location = new System.Drawing.Point(14, 184);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(158, 105);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rbtSizeNone
            // 
            this.rbtSizeNone.AutoCheck = false;
            this.rbtSizeNone.AutoSize = true;
            this.rbtSizeNone.Checked = true;
            this.rbtSizeNone.Location = new System.Drawing.Point(76, 19);
            this.rbtSizeNone.Name = "rbtSizeNone";
            this.rbtSizeNone.Size = new System.Drawing.Size(62, 17);
            this.rbtSizeNone.TabIndex = 3;
            this.rbtSizeNone.TabStop = true;
            this.rbtSizeNone.Text = "No Size";
            this.rbtSizeNone.UseVisualStyleBackColor = true;
            this.rbtSizeNone.Visible = false;
            // 
            // rbtSize20
            // 
            this.rbtSize20.AutoCheck = false;
            this.rbtSize20.AutoSize = true;
            this.rbtSize20.Location = new System.Drawing.Point(16, 65);
            this.rbtSize20.Name = "rbtSize20";
            this.rbtSize20.Size = new System.Drawing.Size(54, 17);
            this.rbtSize20.TabIndex = 2;
            this.rbtSize20.Text = "20 oz.";
            this.rbtSize20.UseVisualStyleBackColor = true;
            // 
            // rbtSize16
            // 
            this.rbtSize16.AutoCheck = false;
            this.rbtSize16.AutoSize = true;
            this.rbtSize16.Location = new System.Drawing.Point(16, 42);
            this.rbtSize16.Name = "rbtSize16";
            this.rbtSize16.Size = new System.Drawing.Size(54, 17);
            this.rbtSize16.TabIndex = 1;
            this.rbtSize16.Text = "16 oz.";
            this.rbtSize16.UseVisualStyleBackColor = true;
            // 
            // rbtSize12
            // 
            this.rbtSize12.AutoCheck = false;
            this.rbtSize12.AutoSize = true;
            this.rbtSize12.Location = new System.Drawing.Point(16, 19);
            this.rbtSize12.Name = "rbtSize12";
            this.rbtSize12.Size = new System.Drawing.Size(54, 17);
            this.rbtSize12.TabIndex = 0;
            this.rbtSize12.Text = "12 oz.";
            this.rbtSize12.UseVisualStyleBackColor = true;
            // 
            // grpAdditives
            // 
            this.grpAdditives.Controls.Add(this.cbxAddCoolDownRemedey);
            this.grpAdditives.Controls.Add(this.cbxAddEnergyBooster);
            this.grpAdditives.Controls.Add(this.cbxAddVitaminPack);
            this.grpAdditives.Location = new System.Drawing.Point(191, 184);
            this.grpAdditives.Name = "grpAdditives";
            this.grpAdditives.Size = new System.Drawing.Size(156, 105);
            this.grpAdditives.TabIndex = 3;
            this.grpAdditives.TabStop = false;
            this.grpAdditives.Text = "Additives";
            // 
            // cbxAddCoolDownRemedey
            // 
            this.cbxAddCoolDownRemedey.AutoSize = true;
            this.cbxAddCoolDownRemedey.Location = new System.Drawing.Point(8, 65);
            this.cbxAddCoolDownRemedey.Name = "cbxAddCoolDownRemedey";
            this.cbxAddCoolDownRemedey.Size = new System.Drawing.Size(120, 17);
            this.cbxAddCoolDownRemedey.TabIndex = 2;
            this.cbxAddCoolDownRemedey.Text = "Cool Down Remedy";
            this.cbxAddCoolDownRemedey.UseVisualStyleBackColor = true;
            this.cbxAddCoolDownRemedey.CheckedChanged += new System.EventHandler(this.rbtAddCoolDownRemedey_CheckedChanged);
            // 
            // cbxAddEnergyBooster
            // 
            this.cbxAddEnergyBooster.AutoSize = true;
            this.cbxAddEnergyBooster.Location = new System.Drawing.Point(8, 43);
            this.cbxAddEnergyBooster.Name = "cbxAddEnergyBooster";
            this.cbxAddEnergyBooster.Size = new System.Drawing.Size(98, 17);
            this.cbxAddEnergyBooster.TabIndex = 1;
            this.cbxAddEnergyBooster.Text = "Energy Booster";
            this.cbxAddEnergyBooster.UseVisualStyleBackColor = true;
            this.cbxAddEnergyBooster.CheckedChanged += new System.EventHandler(this.rbtAddEnergyBooster_CheckedChanged);
            // 
            // cbxAddVitaminPack
            // 
            this.cbxAddVitaminPack.AutoSize = true;
            this.cbxAddVitaminPack.Location = new System.Drawing.Point(8, 20);
            this.cbxAddVitaminPack.Name = "cbxAddVitaminPack";
            this.cbxAddVitaminPack.Size = new System.Drawing.Size(88, 17);
            this.cbxAddVitaminPack.TabIndex = 0;
            this.cbxAddVitaminPack.Text = "Vitamin Pack";
            this.cbxAddVitaminPack.UseVisualStyleBackColor = true;
            this.cbxAddVitaminPack.CheckedChanged += new System.EventHandler(this.rbtAddVitaminPack_CheckedChanged);
            // 
            // btnDrinkAdd
            // 
            this.btnDrinkAdd.Location = new System.Drawing.Point(30, 57);
            this.btnDrinkAdd.Name = "btnDrinkAdd";
            this.btnDrinkAdd.Size = new System.Drawing.Size(118, 23);
            this.btnDrinkAdd.TabIndex = 4;
            this.btnDrinkAdd.Text = "Add to Order";
            this.btnDrinkAdd.UseVisualStyleBackColor = true;
            this.btnDrinkAdd.Click += new System.EventHandler(this.btnDrinkAdd_Click);
            // 
            // btnDrinkClear
            // 
            this.btnDrinkClear.Location = new System.Drawing.Point(30, 94);
            this.btnDrinkClear.Name = "btnDrinkClear";
            this.btnDrinkClear.Size = new System.Drawing.Size(118, 23);
            this.btnDrinkClear.TabIndex = 5;
            this.btnDrinkClear.Text = "Clear Drink";
            this.btnDrinkClear.UseVisualStyleBackColor = true;
            this.btnDrinkClear.Click += new System.EventHandler(this.btnDrinkClear_Click);
            // 
            // grpDrinkInfo
            // 
            this.grpDrinkInfo.Controls.Add(this.tbxDrinkPrice);
            this.grpDrinkInfo.Controls.Add(this.lblDrinkPrice);
            this.grpDrinkInfo.Controls.Add(this.btnDrinkAdd);
            this.grpDrinkInfo.Controls.Add(this.btnDrinkClear);
            this.grpDrinkInfo.Location = new System.Drawing.Point(361, 42);
            this.grpDrinkInfo.Name = "grpDrinkInfo";
            this.grpDrinkInfo.Size = new System.Drawing.Size(167, 136);
            this.grpDrinkInfo.TabIndex = 6;
            this.grpDrinkInfo.TabStop = false;
            this.grpDrinkInfo.Text = "Current Drink";
            // 
            // tbxDrinkPrice
            // 
            this.tbxDrinkPrice.Location = new System.Drawing.Point(63, 21);
            this.tbxDrinkPrice.Name = "tbxDrinkPrice";
            this.tbxDrinkPrice.ReadOnly = true;
            this.tbxDrinkPrice.Size = new System.Drawing.Size(85, 20);
            this.tbxDrinkPrice.TabIndex = 1;
            // 
            // lblDrinkPrice
            // 
            this.lblDrinkPrice.AutoSize = true;
            this.lblDrinkPrice.Location = new System.Drawing.Point(27, 21);
            this.lblDrinkPrice.Name = "lblDrinkPrice";
            this.lblDrinkPrice.Size = new System.Drawing.Size(31, 13);
            this.lblDrinkPrice.TabIndex = 0;
            this.lblDrinkPrice.Text = "Price";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.btnOrderClear);
            this.grpOrderInfo.Controls.Add(this.tbxOrdertTotal);
            this.grpOrderInfo.Controls.Add(this.btnOrderSubmit);
            this.grpOrderInfo.Controls.Add(this.tbxOrderItems);
            this.grpOrderInfo.Controls.Add(this.lblOrderTotal);
            this.grpOrderInfo.Controls.Add(this.lblOrderItems);
            this.grpOrderInfo.Location = new System.Drawing.Point(361, 184);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(167, 105);
            this.grpOrderInfo.TabIndex = 7;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Current Order";
            // 
            // btnOrderClear
            // 
            this.btnOrderClear.Location = new System.Drawing.Point(88, 73);
            this.btnOrderClear.Name = "btnOrderClear";
            this.btnOrderClear.Size = new System.Drawing.Size(73, 23);
            this.btnOrderClear.TabIndex = 9;
            this.btnOrderClear.Text = "Clear Order";
            this.btnOrderClear.UseVisualStyleBackColor = true;
            this.btnOrderClear.Click += new System.EventHandler(this.btnOrderClear_Click);
            // 
            // tbxOrdertTotal
            // 
            this.tbxOrdertTotal.Location = new System.Drawing.Point(66, 47);
            this.tbxOrdertTotal.Name = "tbxOrdertTotal";
            this.tbxOrdertTotal.ReadOnly = true;
            this.tbxOrdertTotal.Size = new System.Drawing.Size(85, 20);
            this.tbxOrdertTotal.TabIndex = 3;
            // 
            // btnOrderSubmit
            // 
            this.btnOrderSubmit.Location = new System.Drawing.Point(6, 73);
            this.btnOrderSubmit.Name = "btnOrderSubmit";
            this.btnOrderSubmit.Size = new System.Drawing.Size(76, 23);
            this.btnOrderSubmit.TabIndex = 8;
            this.btnOrderSubmit.Text = "Submit Order";
            this.btnOrderSubmit.UseVisualStyleBackColor = true;
            this.btnOrderSubmit.Click += new System.EventHandler(this.btnOrderSubmit_Click);
            // 
            // tbxOrderItems
            // 
            this.tbxOrderItems.Location = new System.Drawing.Point(66, 20);
            this.tbxOrderItems.Name = "tbxOrderItems";
            this.tbxOrderItems.ReadOnly = true;
            this.tbxOrderItems.Size = new System.Drawing.Size(85, 20);
            this.tbxOrderItems.TabIndex = 2;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(30, 47);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(31, 13);
            this.lblOrderTotal.TabIndex = 1;
            this.lblOrderTotal.Text = "Total";
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Location = new System.Drawing.Point(10, 21);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(51, 13);
            this.lblOrderItems.TabIndex = 0;
            this.lblOrderItems.Text = "Drink Qty";
            // 
            // uiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 300);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.grpDrinkInfo);
            this.Controls.Add(this.grpAdditives);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpDrinkType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "uiMain";
            this.Text = "Pellissippi State Fitness Center Juice Bar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDrinkType.ResumeLayout(false);
            this.grpDrinkType.PerformLayout();
            this.grpSmoothie.ResumeLayout(false);
            this.grpSmoothie.PerformLayout();
            this.grpJuice.ResumeLayout(false);
            this.grpJuice.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpAdditives.ResumeLayout(false);
            this.grpAdditives.PerformLayout();
            this.grpDrinkInfo.ResumeLayout(false);
            this.grpDrinkInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpDrinkType;
        private System.Windows.Forms.RadioButton rbtTypeNone;
        private System.Windows.Forms.GroupBox grpSmoothie;
        private System.Windows.Forms.RadioButton rbtTypeWheatBerry;
        private System.Windows.Forms.RadioButton rbtTypeStrawberryBanana;
        private System.Windows.Forms.RadioButton rbtTypePomegranate;
        private System.Windows.Forms.GroupBox grpJuice;
        private System.Windows.Forms.RadioButton rbtTypeVegetable;
        private System.Windows.Forms.RadioButton rbtTypeFruit;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbtSizeNone;
        private System.Windows.Forms.RadioButton rbtSize20;
        private System.Windows.Forms.RadioButton rbtSize16;
        private System.Windows.Forms.RadioButton rbtSize12;
        private System.Windows.Forms.GroupBox grpAdditives;
        private System.Windows.Forms.CheckBox cbxAddCoolDownRemedey;
        private System.Windows.Forms.CheckBox cbxAddEnergyBooster;
        private System.Windows.Forms.CheckBox cbxAddVitaminPack;
        private System.Windows.Forms.ToolStripMenuItem veiwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDrinkAdd;
        private System.Windows.Forms.Button btnDrinkClear;
        private System.Windows.Forms.GroupBox grpDrinkInfo;
        private System.Windows.Forms.TextBox tbxDrinkPrice;
        private System.Windows.Forms.Label lblDrinkPrice;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.TextBox tbxOrdertTotal;
        private System.Windows.Forms.TextBox tbxOrderItems;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.Button btnOrderSubmit;
        private System.Windows.Forms.Button btnOrderClear;
        private System.Windows.Forms.ToolStripMenuItem clearDrinkToolStripMenuItem;
    }
}

