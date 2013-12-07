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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpFlighDate = new System.Windows.Forms.DateTimePicker();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxOrigin = new System.Windows.Forms.TextBox();
            this.tbxNameLast = new System.Windows.Forms.TextBox();
            this.tbxNameFirst = new System.Windows.Forms.TextBox();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.rbtEconomy = new System.Windows.Forms.RadioButton();
            this.rbtFirstClass = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrign = new System.Windows.Forms.Label();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxBordingPass = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.rbtMorning = new System.Windows.Forms.RadioButton();
            this.rbtNoon = new System.Windows.Forms.RadioButton();
            this.rbtEvening = new System.Windows.Forms.RadioButton();
            this.rbtNight = new System.Windows.Forms.RadioButton();
            this.pnlInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.groupBox1);
            this.pnlInfo.Controls.Add(this.grpTime);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.dtpFlighDate);
            this.pnlInfo.Controls.Add(this.tbxDestination);
            this.pnlInfo.Controls.Add(this.tbxOrigin);
            this.pnlInfo.Controls.Add(this.tbxNameLast);
            this.pnlInfo.Controls.Add(this.tbxNameFirst);
            this.pnlInfo.Controls.Add(this.btnBookFlight);
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblDestination);
            this.pnlInfo.Controls.Add(this.lblOrign);
            this.pnlInfo.Controls.Add(this.lblNameLast);
            this.pnlInfo.Controls.Add(this.lblNameFirst);
            this.pnlInfo.Location = new System.Drawing.Point(13, 13);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(346, 195);
            this.pnlInfo.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(85, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpFlighDate
            // 
            this.dtpFlighDate.Location = new System.Drawing.Point(68, 57);
            this.dtpFlighDate.Name = "dtpFlighDate";
            this.dtpFlighDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFlighDate.TabIndex = 12;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(238, 30);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 11;
            // 
            // tbxOrigin
            // 
            this.tbxOrigin.Location = new System.Drawing.Point(68, 30);
            this.tbxOrigin.Name = "tbxOrigin";
            this.tbxOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbxOrigin.TabIndex = 10;
            // 
            // tbxNameLast
            // 
            this.tbxNameLast.Location = new System.Drawing.Point(238, 7);
            this.tbxNameLast.Name = "tbxNameLast";
            this.tbxNameLast.Size = new System.Drawing.Size(100, 20);
            this.tbxNameLast.TabIndex = 9;
            // 
            // tbxNameFirst
            // 
            this.tbxNameFirst.Location = new System.Drawing.Point(68, 4);
            this.tbxNameFirst.Name = "tbxNameFirst";
            this.tbxNameFirst.Size = new System.Drawing.Size(100, 20);
            this.tbxNameFirst.TabIndex = 8;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Location = new System.Drawing.Point(3, 166);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(75, 23);
            this.btnBookFlight.TabIndex = 7;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // rbtEconomy
            // 
            this.rbtEconomy.AutoSize = true;
            this.rbtEconomy.Location = new System.Drawing.Point(83, 12);
            this.rbtEconomy.Name = "rbtEconomy";
            this.rbtEconomy.Size = new System.Drawing.Size(69, 17);
            this.rbtEconomy.TabIndex = 6;
            this.rbtEconomy.TabStop = true;
            this.rbtEconomy.Text = "Economy";
            this.rbtEconomy.UseVisualStyleBackColor = true;
            // 
            // rbtFirstClass
            // 
            this.rbtFirstClass.AutoSize = true;
            this.rbtFirstClass.Location = new System.Drawing.Point(6, 11);
            this.rbtFirstClass.Name = "rbtFirstClass";
            this.rbtFirstClass.Size = new System.Drawing.Size(72, 17);
            this.rbtFirstClass.TabIndex = 5;
            this.rbtFirstClass.TabStop = true;
            this.rbtFirstClass.Text = "First Class";
            this.rbtFirstClass.UseVisualStyleBackColor = true;
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
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(178, 33);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(54, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destiation";
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
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(174, 7);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(58, 13);
            this.lblNameLast.TabIndex = 1;
            this.lblNameLast.Text = "Last Name";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxBordingPass);
            this.panel1.Location = new System.Drawing.Point(13, 214);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFirstClass);
            this.groupBox1.Controls.Add(this.rbtEconomy);
            this.groupBox1.Location = new System.Drawing.Point(7, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 34);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.rbtNight);
            this.grpTime.Controls.Add(this.rbtEvening);
            this.grpTime.Controls.Add(this.rbtNoon);
            this.grpTime.Controls.Add(this.rbtMorning);
            this.grpTime.Location = new System.Drawing.Point(7, 83);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(331, 37);
            this.grpTime.TabIndex = 14;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time";
            // 
            // rbtMorning
            // 
            this.rbtMorning.AutoSize = true;
            this.rbtMorning.Location = new System.Drawing.Point(7, 13);
            this.rbtMorning.Name = "rbtMorning";
            this.rbtMorning.Size = new System.Drawing.Size(63, 17);
            this.rbtMorning.TabIndex = 0;
            this.rbtMorning.TabStop = true;
            this.rbtMorning.Text = "Morning";
            this.rbtMorning.UseVisualStyleBackColor = true;
            // 
            // rbtNoon
            // 
            this.rbtNoon.AutoSize = true;
            this.rbtNoon.Location = new System.Drawing.Point(76, 13);
            this.rbtNoon.Name = "rbtNoon";
            this.rbtNoon.Size = new System.Drawing.Size(51, 17);
            this.rbtNoon.TabIndex = 1;
            this.rbtNoon.TabStop = true;
            this.rbtNoon.Text = "Noon";
            this.rbtNoon.UseVisualStyleBackColor = true;
            // 
            // rbtEvening
            // 
            this.rbtEvening.AutoSize = true;
            this.rbtEvening.Location = new System.Drawing.Point(133, 13);
            this.rbtEvening.Name = "rbtEvening";
            this.rbtEvening.Size = new System.Drawing.Size(64, 17);
            this.rbtEvening.TabIndex = 2;
            this.rbtEvening.TabStop = true;
            this.rbtEvening.Text = "Evening";
            this.rbtEvening.UseVisualStyleBackColor = true;
            // 
            // rbtNight
            // 
            this.rbtNight.AutoSize = true;
            this.rbtNight.Location = new System.Drawing.Point(204, 13);
            this.rbtNight.Name = "rbtNight";
            this.rbtNight.Size = new System.Drawing.Size(50, 17);
            this.rbtNight.TabIndex = 3;
            this.rbtNight.TabStop = true;
            this.rbtNight.Text = "Night";
            this.rbtNight.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book a Flight";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DateTimePicker dtpFlighDate;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.RadioButton rbtNight;
        private System.Windows.Forms.RadioButton rbtEvening;
        private System.Windows.Forms.RadioButton rbtNoon;
        private System.Windows.Forms.RadioButton rbtMorning;
    }
}

