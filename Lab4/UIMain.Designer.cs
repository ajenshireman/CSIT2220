namespace CSIT2220_Lab4
{
    partial class UIMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tbx_newItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCountItems = new System.Windows.Forms.Button();
            this.grpManageItems = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpSelectCoffeeFlavor = new System.Windows.Forms.GroupBox();
            this.lblCoffeeFlavor = new System.Windows.Forms.Label();
            this.cboCoffeeFlavor = new System.Windows.Forms.ComboBox();
            this.btnClearDrink = new System.Windows.Forms.Button();
            this.grpManageItems.SuspendLayout();
            this.grpSelectCoffeeFlavor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 227);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tbx_newItem
            // 
            this.tbx_newItem.Location = new System.Drawing.Point(6, 16);
            this.tbx_newItem.Name = "tbx_newItem";
            this.tbx_newItem.Size = new System.Drawing.Size(121, 20);
            this.tbx_newItem.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(52, 42);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(52, 101);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(75, 23);
            this.btnClearItems.TabIndex = 5;
            this.btnClearItems.Text = "Clear";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(133, 16);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(120, 147);
            this.lbxItems.Sorted = true;
            this.lbxItems.TabIndex = 6;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(52, 72);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 7;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCountItems
            // 
            this.btnCountItems.Location = new System.Drawing.Point(52, 131);
            this.btnCountItems.Name = "btnCountItems";
            this.btnCountItems.Size = new System.Drawing.Size(75, 23);
            this.btnCountItems.TabIndex = 8;
            this.btnCountItems.Text = "Count";
            this.btnCountItems.UseVisualStyleBackColor = true;
            this.btnCountItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // grpManageItems
            // 
            this.grpManageItems.Controls.Add(this.btnCountItems);
            this.grpManageItems.Controls.Add(this.btnRemoveItem);
            this.grpManageItems.Controls.Add(this.lbxItems);
            this.grpManageItems.Controls.Add(this.btnClearItems);
            this.grpManageItems.Controls.Add(this.btnAddItem);
            this.grpManageItems.Controls.Add(this.tbx_newItem);
            this.grpManageItems.Location = new System.Drawing.Point(7, 25);
            this.grpManageItems.Name = "grpManageItems";
            this.grpManageItems.Size = new System.Drawing.Size(266, 191);
            this.grpManageItems.TabIndex = 9;
            this.grpManageItems.TabStop = false;
            this.grpManageItems.Text = "Manage Items";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "gr";
            this.notifyIcon1.Visible = true;
            // 
            // grpSelectCoffeeFlavor
            // 
            this.grpSelectCoffeeFlavor.Controls.Add(this.btnClearDrink);
            this.grpSelectCoffeeFlavor.Controls.Add(this.cboCoffeeFlavor);
            this.grpSelectCoffeeFlavor.Controls.Add(this.lblCoffeeFlavor);
            this.grpSelectCoffeeFlavor.Location = new System.Drawing.Point(279, 25);
            this.grpSelectCoffeeFlavor.Name = "grpSelectCoffeeFlavor";
            this.grpSelectCoffeeFlavor.Size = new System.Drawing.Size(214, 234);
            this.grpSelectCoffeeFlavor.TabIndex = 10;
            this.grpSelectCoffeeFlavor.TabStop = false;
            this.grpSelectCoffeeFlavor.Text = "Select Coffee Flavor";
            // 
            // lblCoffeeFlavor
            // 
            this.lblCoffeeFlavor.AutoSize = true;
            this.lblCoffeeFlavor.Location = new System.Drawing.Point(6, 19);
            this.lblCoffeeFlavor.Name = "lblCoffeeFlavor";
            this.lblCoffeeFlavor.Size = new System.Drawing.Size(70, 13);
            this.lblCoffeeFlavor.TabIndex = 0;
            this.lblCoffeeFlavor.Text = "Coffee Flavor";
            // 
            // cboCoffeeFlavor
            // 
            this.cboCoffeeFlavor.FormattingEnabled = true;
            this.cboCoffeeFlavor.Location = new System.Drawing.Point(82, 16);
            this.cboCoffeeFlavor.Name = "cboCoffeeFlavor";
            this.cboCoffeeFlavor.Size = new System.Drawing.Size(121, 21);
            this.cboCoffeeFlavor.TabIndex = 1;
            // 
            // btnClearDrink
            // 
            this.btnClearDrink.Location = new System.Drawing.Point(128, 202);
            this.btnClearDrink.Name = "btnClearDrink";
            this.btnClearDrink.Size = new System.Drawing.Size(75, 23);
            this.btnClearDrink.TabIndex = 2;
            this.btnClearDrink.Text = "Clear";
            this.btnClearDrink.UseVisualStyleBackColor = true;
            this.btnClearDrink.Click += new System.EventHandler(this.btnClearDrink_Click);
            // 
            // UIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 267);
            this.Controls.Add(this.grpSelectCoffeeFlavor);
            this.Controls.Add(this.grpManageItems);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.Name = "UIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpManageItems.ResumeLayout(false);
            this.grpManageItems.PerformLayout();
            this.grpSelectCoffeeFlavor.ResumeLayout(false);
            this.grpSelectCoffeeFlavor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox tbx_newItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnCountItems;
        private System.Windows.Forms.GroupBox grpManageItems;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox grpSelectCoffeeFlavor;
        private System.Windows.Forms.ComboBox cboCoffeeFlavor;
        private System.Windows.Forms.Label lblCoffeeFlavor;
        private System.Windows.Forms.Button btnClearDrink;
    }
}

