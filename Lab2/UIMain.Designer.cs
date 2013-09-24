namespace CSIT2220_Lab2
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
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.grp_violationInfo = new System.Windows.Forms.GroupBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calcFine = new System.Windows.Forms.Button();
            this.pnl_clockedSpeed = new System.Windows.Forms.Panel();
            this.tbx_clockedSpeed = new System.Windows.Forms.TextBox();
            this.lbl_clockedSpeed = new System.Windows.Forms.Label();
            this.grp_violatorInfo = new System.Windows.Forms.GroupBox();
            this.cbo_studentYear = new System.Windows.Forms.ComboBox();
            this.lbl_studentYear = new System.Windows.Forms.Label();
            this.lbl_violatorType = new System.Windows.Forms.Label();
            this.cbo_violatorType = new System.Windows.Forms.ComboBox();
            this.grp_speedLimit = new System.Windows.Forms.GroupBox();
            this.rbt_limit15 = new System.Windows.Forms.RadioButton();
            this.rbt_limit35 = new System.Windows.Forms.RadioButton();
            this.grp_feeInfo = new System.Windows.Forms.GroupBox();
            this.tbx_feeTotal = new System.Windows.Forms.TextBox();
            this.tbx_additional = new System.Windows.Forms.TextBox();
            this.tbx_feeReckless = new System.Windows.Forms.TextBox();
            this.tbx_feeExt = new System.Windows.Forms.TextBox();
            this.tbx_feeBase = new System.Windows.Forms.TextBox();
            this.tbx_speedOver = new System.Windows.Forms.TextBox();
            this.lbl_feeTotal = new System.Windows.Forms.Label();
            this.lbl_feeAdditional = new System.Windows.Forms.Label();
            this.lbl_feeReckless = new System.Windows.Forms.Label();
            this.lbl_feeExt = new System.Windows.Forms.Label();
            this.lbl_feeBase = new System.Windows.Forms.Label();
            this.lbl_overMPH = new System.Windows.Forms.Label();
            this.grp_violationInfo.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_clockedSpeed.SuspendLayout();
            this.grp_violatorInfo.SuspendLayout();
            this.grp_speedLimit.SuspendLayout();
            this.grp_feeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_violationInfo
            // 
            this.grp_violationInfo.Controls.Add(this.pnl_buttons);
            this.grp_violationInfo.Controls.Add(this.pnl_clockedSpeed);
            this.grp_violationInfo.Controls.Add(this.grp_violatorInfo);
            this.grp_violationInfo.Controls.Add(this.grp_speedLimit);
            this.grp_violationInfo.Location = new System.Drawing.Point(18, 18);
            this.grp_violationInfo.Name = "grp_violationInfo";
            this.grp_violationInfo.Size = new System.Drawing.Size(517, 189);
            this.grp_violationInfo.TabIndex = 0;
            this.grp_violationInfo.TabStop = false;
            this.grp_violationInfo.Text = "Violation Information";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_clear);
            this.pnl_buttons.Controls.Add(this.btn_calcFine);
            this.pnl_buttons.Location = new System.Drawing.Point(236, 127);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(270, 49);
            this.pnl_buttons.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(24, 13);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(110, 25);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear Fields";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_calcFine
            // 
            this.btn_calcFine.Location = new System.Drawing.Point(140, 13);
            this.btn_calcFine.Name = "btn_calcFine";
            this.btn_calcFine.Size = new System.Drawing.Size(110, 25);
            this.btn_calcFine.TabIndex = 7;
            this.btn_calcFine.Text = "Calculate Fine";
            this.btn_calcFine.UseVisualStyleBackColor = true;
            this.btn_calcFine.Click += new System.EventHandler(this.btn_calcFine_Click);
            // 
            // pnl_clockedSpeed
            // 
            this.pnl_clockedSpeed.Controls.Add(this.tbx_clockedSpeed);
            this.pnl_clockedSpeed.Controls.Add(this.lbl_clockedSpeed);
            this.pnl_clockedSpeed.Location = new System.Drawing.Point(16, 126);
            this.pnl_clockedSpeed.Name = "pnl_clockedSpeed";
            this.pnl_clockedSpeed.Size = new System.Drawing.Size(212, 51);
            this.pnl_clockedSpeed.TabIndex = 6;
            // 
            // tbx_clockedSpeed
            // 
            this.tbx_clockedSpeed.Location = new System.Drawing.Point(91, 14);
            this.tbx_clockedSpeed.Name = "tbx_clockedSpeed";
            this.tbx_clockedSpeed.Size = new System.Drawing.Size(108, 20);
            this.tbx_clockedSpeed.TabIndex = 1;
            // 
            // lbl_clockedSpeed
            // 
            this.lbl_clockedSpeed.AutoSize = true;
            this.lbl_clockedSpeed.Location = new System.Drawing.Point(5, 14);
            this.lbl_clockedSpeed.Name = "lbl_clockedSpeed";
            this.lbl_clockedSpeed.Size = new System.Drawing.Size(80, 13);
            this.lbl_clockedSpeed.TabIndex = 0;
            this.lbl_clockedSpeed.Text = "Clocked Speed";
            // 
            // grp_violatorInfo
            // 
            this.grp_violatorInfo.Controls.Add(this.cbo_studentYear);
            this.grp_violatorInfo.Controls.Add(this.lbl_studentYear);
            this.grp_violatorInfo.Controls.Add(this.lbl_violatorType);
            this.grp_violatorInfo.Controls.Add(this.cbo_violatorType);
            this.grp_violatorInfo.Location = new System.Drawing.Point(234, 19);
            this.grp_violatorInfo.Name = "grp_violatorInfo";
            this.grp_violatorInfo.Size = new System.Drawing.Size(273, 101);
            this.grp_violatorInfo.TabIndex = 5;
            this.grp_violatorInfo.TabStop = false;
            this.grp_violatorInfo.Text = "Violator Information";
            // 
            // cbo_studentYear
            // 
            this.cbo_studentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_studentYear.Enabled = false;
            this.cbo_studentYear.FormattingEnabled = true;
            this.cbo_studentYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophmore",
            "Junior",
            "Senior"});
            this.cbo_studentYear.Location = new System.Drawing.Point(81, 65);
            this.cbo_studentYear.Name = "cbo_studentYear";
            this.cbo_studentYear.Size = new System.Drawing.Size(181, 21);
            this.cbo_studentYear.TabIndex = 4;
            this.cbo_studentYear.SelectedIndexChanged += new System.EventHandler(this.cbo_studentYear_SelectedIndexChanged);
            // 
            // lbl_studentYear
            // 
            this.lbl_studentYear.AutoSize = true;
            this.lbl_studentYear.Location = new System.Drawing.Point(6, 65);
            this.lbl_studentYear.Name = "lbl_studentYear";
            this.lbl_studentYear.Size = new System.Drawing.Size(69, 13);
            this.lbl_studentYear.TabIndex = 3;
            this.lbl_studentYear.Text = "Student Year";
            // 
            // lbl_violatorType
            // 
            this.lbl_violatorType.AutoSize = true;
            this.lbl_violatorType.Location = new System.Drawing.Point(6, 19);
            this.lbl_violatorType.Name = "lbl_violatorType";
            this.lbl_violatorType.Size = new System.Drawing.Size(69, 13);
            this.lbl_violatorType.TabIndex = 2;
            this.lbl_violatorType.Text = "Violator Type";
            // 
            // cbo_violatorType
            // 
            this.cbo_violatorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_violatorType.FormattingEnabled = true;
            this.cbo_violatorType.Items.AddRange(new object[] {
            "Visitor",
            "Employee",
            "Student"});
            this.cbo_violatorType.Location = new System.Drawing.Point(81, 19);
            this.cbo_violatorType.Name = "cbo_violatorType";
            this.cbo_violatorType.Size = new System.Drawing.Size(181, 21);
            this.cbo_violatorType.TabIndex = 1;
            this.cbo_violatorType.SelectedIndexChanged += new System.EventHandler(this.cbo_violatorType_SelectedIndexChanged);
            // 
            // grp_speedLimit
            // 
            this.grp_speedLimit.Controls.Add(this.rbt_limit15);
            this.grp_speedLimit.Controls.Add(this.rbt_limit35);
            this.grp_speedLimit.Location = new System.Drawing.Point(16, 19);
            this.grp_speedLimit.Name = "grp_speedLimit";
            this.grp_speedLimit.Size = new System.Drawing.Size(212, 101);
            this.grp_speedLimit.TabIndex = 0;
            this.grp_speedLimit.TabStop = false;
            this.grp_speedLimit.Text = "Speed Limit";
            // 
            // rbt_limit15
            // 
            this.rbt_limit15.AutoSize = true;
            this.rbt_limit15.Location = new System.Drawing.Point(62, 53);
            this.rbt_limit15.Name = "rbt_limit15";
            this.rbt_limit15.Size = new System.Drawing.Size(61, 17);
            this.rbt_limit15.TabIndex = 1;
            this.rbt_limit15.TabStop = true;
            this.rbt_limit15.Text = "15 Mph";
            this.rbt_limit15.UseVisualStyleBackColor = true;
            this.rbt_limit15.CheckedChanged += new System.EventHandler(this.rbt_limit15_CheckedChanged);
            // 
            // rbt_limit35
            // 
            this.rbt_limit35.AutoSize = true;
            this.rbt_limit35.Location = new System.Drawing.Point(62, 19);
            this.rbt_limit35.Name = "rbt_limit35";
            this.rbt_limit35.Size = new System.Drawing.Size(61, 17);
            this.rbt_limit35.TabIndex = 0;
            this.rbt_limit35.TabStop = true;
            this.rbt_limit35.Text = "35 Mph";
            this.rbt_limit35.UseVisualStyleBackColor = true;
            this.rbt_limit35.CheckedChanged += new System.EventHandler(this.rbt_limit35_CheckedChanged);
            // 
            // grp_feeInfo
            // 
            this.grp_feeInfo.Controls.Add(this.tbx_feeTotal);
            this.grp_feeInfo.Controls.Add(this.tbx_additional);
            this.grp_feeInfo.Controls.Add(this.tbx_feeReckless);
            this.grp_feeInfo.Controls.Add(this.tbx_feeExt);
            this.grp_feeInfo.Controls.Add(this.tbx_feeBase);
            this.grp_feeInfo.Controls.Add(this.tbx_speedOver);
            this.grp_feeInfo.Controls.Add(this.lbl_feeTotal);
            this.grp_feeInfo.Controls.Add(this.lbl_feeAdditional);
            this.grp_feeInfo.Controls.Add(this.lbl_feeReckless);
            this.grp_feeInfo.Controls.Add(this.lbl_feeExt);
            this.grp_feeInfo.Controls.Add(this.lbl_feeBase);
            this.grp_feeInfo.Controls.Add(this.lbl_overMPH);
            this.grp_feeInfo.Location = new System.Drawing.Point(252, 213);
            this.grp_feeInfo.Name = "grp_feeInfo";
            this.grp_feeInfo.Size = new System.Drawing.Size(283, 186);
            this.grp_feeInfo.TabIndex = 1;
            this.grp_feeInfo.TabStop = false;
            this.grp_feeInfo.Text = "Fine Information";
            // 
            // tbx_feeTotal
            // 
            this.tbx_feeTotal.Location = new System.Drawing.Point(143, 152);
            this.tbx_feeTotal.Name = "tbx_feeTotal";
            this.tbx_feeTotal.ReadOnly = true;
            this.tbx_feeTotal.Size = new System.Drawing.Size(110, 20);
            this.tbx_feeTotal.TabIndex = 11;
            // 
            // tbx_additional
            // 
            this.tbx_additional.Location = new System.Drawing.Point(143, 126);
            this.tbx_additional.Name = "tbx_additional";
            this.tbx_additional.ReadOnly = true;
            this.tbx_additional.Size = new System.Drawing.Size(110, 20);
            this.tbx_additional.TabIndex = 10;
            // 
            // tbx_feeReckless
            // 
            this.tbx_feeReckless.Location = new System.Drawing.Point(143, 100);
            this.tbx_feeReckless.Name = "tbx_feeReckless";
            this.tbx_feeReckless.ReadOnly = true;
            this.tbx_feeReckless.Size = new System.Drawing.Size(110, 20);
            this.tbx_feeReckless.TabIndex = 9;
            // 
            // tbx_feeExt
            // 
            this.tbx_feeExt.Location = new System.Drawing.Point(143, 74);
            this.tbx_feeExt.Name = "tbx_feeExt";
            this.tbx_feeExt.ReadOnly = true;
            this.tbx_feeExt.Size = new System.Drawing.Size(110, 20);
            this.tbx_feeExt.TabIndex = 8;
            // 
            // tbx_feeBase
            // 
            this.tbx_feeBase.Location = new System.Drawing.Point(143, 48);
            this.tbx_feeBase.Name = "tbx_feeBase";
            this.tbx_feeBase.ReadOnly = true;
            this.tbx_feeBase.Size = new System.Drawing.Size(110, 20);
            this.tbx_feeBase.TabIndex = 7;
            // 
            // tbx_speedOver
            // 
            this.tbx_speedOver.Location = new System.Drawing.Point(143, 22);
            this.tbx_speedOver.Name = "tbx_speedOver";
            this.tbx_speedOver.ReadOnly = true;
            this.tbx_speedOver.Size = new System.Drawing.Size(110, 20);
            this.tbx_speedOver.TabIndex = 6;
            // 
            // lbl_feeTotal
            // 
            this.lbl_feeTotal.AutoSize = true;
            this.lbl_feeTotal.Location = new System.Drawing.Point(83, 152);
            this.lbl_feeTotal.Name = "lbl_feeTotal";
            this.lbl_feeTotal.Size = new System.Drawing.Size(54, 13);
            this.lbl_feeTotal.TabIndex = 5;
            this.lbl_feeTotal.Text = "Total Fine";
            // 
            // lbl_feeAdditional
            // 
            this.lbl_feeAdditional.AutoSize = true;
            this.lbl_feeAdditional.Location = new System.Drawing.Point(6, 126);
            this.lbl_feeAdditional.Name = "lbl_feeAdditional";
            this.lbl_feeAdditional.Size = new System.Drawing.Size(131, 13);
            this.lbl_feeAdditional.TabIndex = 4;
            this.lbl_feeAdditional.Text = "Additional Fees/Discounts";
            // 
            // lbl_feeReckless
            // 
            this.lbl_feeReckless.AutoSize = true;
            this.lbl_feeReckless.Location = new System.Drawing.Point(29, 100);
            this.lbl_feeReckless.Name = "lbl_feeReckless";
            this.lbl_feeReckless.Size = new System.Drawing.Size(108, 13);
            this.lbl_feeReckless.TabIndex = 3;
            this.lbl_feeReckless.Text = "Reckless Driving Fee";
            // 
            // lbl_feeExt
            // 
            this.lbl_feeExt.AutoSize = true;
            this.lbl_feeExt.Location = new System.Drawing.Point(61, 74);
            this.lbl_feeExt.Name = "lbl_feeExt";
            this.lbl_feeExt.Size = new System.Drawing.Size(76, 13);
            this.lbl_feeExt.TabIndex = 2;
            this.lbl_feeExt.Text = "Extrended Fee";
            // 
            // lbl_feeBase
            // 
            this.lbl_feeBase.AutoSize = true;
            this.lbl_feeBase.Location = new System.Drawing.Point(85, 48);
            this.lbl_feeBase.Name = "lbl_feeBase";
            this.lbl_feeBase.Size = new System.Drawing.Size(52, 13);
            this.lbl_feeBase.TabIndex = 1;
            this.lbl_feeBase.Text = "Base Fee";
            // 
            // lbl_overMPH
            // 
            this.lbl_overMPH.AutoSize = true;
            this.lbl_overMPH.Location = new System.Drawing.Point(22, 22);
            this.lbl_overMPH.Name = "lbl_overMPH";
            this.lbl_overMPH.Size = new System.Drawing.Size(115, 13);
            this.lbl_overMPH.TabIndex = 0;
            this.lbl_overMPH.Text = "MPH Over Speed Limit";
            // 
            // UIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 414);
            this.Controls.Add(this.grp_feeInfo);
            this.Controls.Add(this.grp_violationInfo);
            this.Name = "UIMain";
            this.Text = "Ticket Calculator";
            this.grp_violationInfo.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_clockedSpeed.ResumeLayout(false);
            this.pnl_clockedSpeed.PerformLayout();
            this.grp_violatorInfo.ResumeLayout(false);
            this.grp_violatorInfo.PerformLayout();
            this.grp_speedLimit.ResumeLayout(false);
            this.grp_speedLimit.PerformLayout();
            this.grp_feeInfo.ResumeLayout(false);
            this.grp_feeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_violationInfo;
        private System.Windows.Forms.ComboBox cbo_studentYear;
        private System.Windows.Forms.Label lbl_studentYear;
        private System.Windows.Forms.Label lbl_violatorType;
        private System.Windows.Forms.ComboBox cbo_violatorType;
        private System.Windows.Forms.GroupBox grp_speedLimit;
        private System.Windows.Forms.RadioButton rbt_limit15;
        private System.Windows.Forms.RadioButton rbt_limit35;
        private System.Windows.Forms.GroupBox grp_feeInfo;
        private System.Windows.Forms.Panel pnl_clockedSpeed;
        private System.Windows.Forms.TextBox tbx_clockedSpeed;
        private System.Windows.Forms.Label lbl_clockedSpeed;
        private System.Windows.Forms.GroupBox grp_violatorInfo;
        private System.Windows.Forms.Label lbl_feeTotal;
        private System.Windows.Forms.Label lbl_feeAdditional;
        private System.Windows.Forms.Label lbl_feeReckless;
        private System.Windows.Forms.Label lbl_feeExt;
        private System.Windows.Forms.Label lbl_feeBase;
        private System.Windows.Forms.Label lbl_overMPH;
        private System.Windows.Forms.TextBox tbx_speedOver;
        private System.Windows.Forms.TextBox tbx_feeTotal;
        private System.Windows.Forms.TextBox tbx_additional;
        private System.Windows.Forms.TextBox tbx_feeReckless;
        private System.Windows.Forms.TextBox tbx_feeExt;
        private System.Windows.Forms.TextBox tbx_feeBase;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_calcFine;
        private System.Windows.Forms.Panel pnl_buttons;
    }
}

