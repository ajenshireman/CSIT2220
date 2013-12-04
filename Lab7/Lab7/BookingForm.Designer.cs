namespace Lab7
{
    partial class BookingForm
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblOrign = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.rbtFirstClass = new System.Windows.Forms.RadioButton();
            this.rbtEconomy = new System.Windows.Forms.RadioButton();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.tbxNameFirst = new System.Windows.Forms.TextBox();
            this.tbxNameLast = new System.Windows.Forms.TextBox();
            this.tbxOrigin = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxBordingPass = new System.Windows.Forms.RichTextBox();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.dateTimePicker1);
            this.pnlInfo.Controls.Add(this.tbxDestination);
            this.pnlInfo.Controls.Add(this.tbxOrigin);
            this.pnlInfo.Controls.Add(this.tbxNameLast);
            this.pnlInfo.Controls.Add(this.tbxNameFirst);
            this.pnlInfo.Controls.Add(this.btnBookFlight);
            this.pnlInfo.Controls.Add(this.rbtEconomy);
            this.pnlInfo.Controls.Add(this.rbtFirstClass);
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblDestination);
            this.pnlInfo.Controls.Add(this.lblOrign);
            this.pnlInfo.Controls.Add(this.lblNameLast);
            this.pnlInfo.Controls.Add(this.lblNameFirst);
            this.pnlInfo.Location = new System.Drawing.Point(13, 13);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(346, 137);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(4, 4);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(57, 13);
            this.lblNameFirst.TabIndex = 0;
            this.lblNameFirst.Text = "First Name";
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(174, 7);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(58, 13);
            this.lblNameLast.TabIndex = 1;
            this.lblNameLast.Text = "Last Name";
            // 
            // lblOrign
            // 
            this.lblOrign.AutoSize = true;
            this.lblOrign.Location = new System.Drawing.Point(4, 33);
            this.lblOrign.Name = "lblOrign";
            this.lblOrign.Size = new System.Drawing.Size(34, 13);
            this.lblOrign.TabIndex = 2;
            this.lblOrign.Text = "Origin";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(178, 33);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(54, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destiation";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(4, 63);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // rbtFirstClass
            // 
            this.rbtFirstClass.AutoSize = true;
            this.rbtFirstClass.Location = new System.Drawing.Point(7, 83);
            this.rbtFirstClass.Name = "rbtFirstClass";
            this.rbtFirstClass.Size = new System.Drawing.Size(72, 17);
            this.rbtFirstClass.TabIndex = 5;
            this.rbtFirstClass.TabStop = true;
            this.rbtFirstClass.Text = "First Class";
            this.rbtFirstClass.UseVisualStyleBackColor = true;
            // 
            // rbtEconomy
            // 
            this.rbtEconomy.AutoSize = true;
            this.rbtEconomy.Location = new System.Drawing.Point(85, 83);
            this.rbtEconomy.Name = "rbtEconomy";
            this.rbtEconomy.Size = new System.Drawing.Size(69, 17);
            this.rbtEconomy.TabIndex = 6;
            this.rbtEconomy.TabStop = true;
            this.rbtEconomy.Text = "Economy";
            this.rbtEconomy.UseVisualStyleBackColor = true;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(7, 106);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(75, 23);
            this.btnBookFlight.TabIndex = 7;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            // 
            // tbxNameFirst
            // 
            this.tbxNameFirst.Location = new System.Drawing.Point(68, 4);
            this.tbxNameFirst.Name = "tbxNameFirst";
            this.tbxNameFirst.Size = new System.Drawing.Size(100, 20);
            this.tbxNameFirst.TabIndex = 8;
            // 
            // tbxNameLast
            // 
            this.tbxNameLast.Location = new System.Drawing.Point(238, 7);
            this.tbxNameLast.Name = "tbxNameLast";
            this.tbxNameLast.Size = new System.Drawing.Size(100, 20);
            this.tbxNameLast.TabIndex = 9;
            // 
            // tbxOrigin
            // 
            this.tbxOrigin.Location = new System.Drawing.Point(68, 30);
            this.tbxOrigin.Name = "tbxOrigin";
            this.tbxOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbxOrigin.TabIndex = 10;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(238, 30);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxBordingPass);
            this.panel1.Location = new System.Drawing.Point(13, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 160);
            this.panel1.TabIndex = 1;
            // 
            // tbxBordingPass
            // 
            this.tbxBordingPass.Location = new System.Drawing.Point(4, 3);
            this.tbxBordingPass.Name = "tbxBordingPass";
            this.tbxBordingPass.ReadOnly = true;
            this.tbxBordingPass.Size = new System.Drawing.Size(340, 154);
            this.tbxBordingPass.TabIndex = 0;
            this.tbxBordingPass.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxOrigin;
        private System.Windows.Forms.TextBox tbxNameLast;
        private System.Windows.Forms.TextBox tbxNameFirst;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.RadioButton rbtEconomy;
        private System.Windows.Forms.RadioButton rbtFirstClass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOrign;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbxBordingPass;
    }
}

