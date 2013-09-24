namespace CSIT2220_Lab1
{
    partial class InventoryUI
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
            this.grp_input = new System.Windows.Forms.GroupBox();
            this.tbx_invEnd = new System.Windows.Forms.TextBox();
            this.tbx_invSold = new System.Windows.Forms.TextBox();
            this.tbx_invStart = new System.Windows.Forms.TextBox();
            this.lbl_invEnd = new System.Windows.Forms.Label();
            this.lbl_invStart = new System.Windows.Forms.Label();
            this.lbl_invSold = new System.Windows.Forms.Label();
            this.grp_output = new System.Windows.Forms.GroupBox();
            this.tbx_turnover = new System.Windows.Forms.TextBox();
            this.tbx_invAvg = new System.Windows.Forms.TextBox();
            this.lbl_turnover = new System.Windows.Forms.Label();
            this.lbl_invAvg = new System.Windows.Forms.Label();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grp_input.SuspendLayout();
            this.grp_output.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_input
            // 
            this.grp_input.Controls.Add(this.tbx_invEnd);
            this.grp_input.Controls.Add(this.tbx_invSold);
            this.grp_input.Controls.Add(this.tbx_invStart);
            this.grp_input.Controls.Add(this.lbl_invEnd);
            this.grp_input.Controls.Add(this.lbl_invStart);
            this.grp_input.Controls.Add(this.lbl_invSold);
            this.grp_input.Location = new System.Drawing.Point(12, 49);
            this.grp_input.Name = "grp_input";
            this.grp_input.Size = new System.Drawing.Size(263, 128);
            this.grp_input.TabIndex = 0;
            this.grp_input.TabStop = false;
            // 
            // tbx_invEnd
            // 
            this.tbx_invEnd.Location = new System.Drawing.Point(103, 55);
            this.tbx_invEnd.Name = "tbx_invEnd";
            this.tbx_invEnd.Size = new System.Drawing.Size(116, 20);
            this.tbx_invEnd.TabIndex = 3;
            // 
            // tbx_invSold
            // 
            this.tbx_invSold.Location = new System.Drawing.Point(103, 94);
            this.tbx_invSold.Name = "tbx_invSold";
            this.tbx_invSold.Size = new System.Drawing.Size(117, 20);
            this.tbx_invSold.TabIndex = 4;
            // 
            // tbx_invStart
            // 
            this.tbx_invStart.Location = new System.Drawing.Point(102, 16);
            this.tbx_invStart.Name = "tbx_invStart";
            this.tbx_invStart.Size = new System.Drawing.Size(117, 20);
            this.tbx_invStart.TabIndex = 2;
            // 
            // lbl_invEnd
            // 
            this.lbl_invEnd.AutoSize = true;
            this.lbl_invEnd.Location = new System.Drawing.Point(6, 55);
            this.lbl_invEnd.Name = "lbl_invEnd";
            this.lbl_invEnd.Size = new System.Drawing.Size(87, 13);
            this.lbl_invEnd.TabIndex = 1;
            this.lbl_invEnd.Text = "Ending Inventory";
            // 
            // lbl_invStart
            // 
            this.lbl_invStart.AutoSize = true;
            this.lbl_invStart.Location = new System.Drawing.Point(6, 16);
            this.lbl_invStart.Name = "lbl_invStart";
            this.lbl_invStart.Size = new System.Drawing.Size(90, 13);
            this.lbl_invStart.TabIndex = 0;
            this.lbl_invStart.Text = "Starting Inventory";
            // 
            // lbl_invSold
            // 
            this.lbl_invSold.AutoSize = true;
            this.lbl_invSold.Location = new System.Drawing.Point(7, 94);
            this.lbl_invSold.Name = "lbl_invSold";
            this.lbl_invSold.Size = new System.Drawing.Size(62, 13);
            this.lbl_invSold.TabIndex = 0;
            this.lbl_invSold.Text = "Goods Sold";
            // 
            // grp_output
            // 
            this.grp_output.Controls.Add(this.tbx_turnover);
            this.grp_output.Controls.Add(this.tbx_invAvg);
            this.grp_output.Controls.Add(this.lbl_turnover);
            this.grp_output.Controls.Add(this.lbl_invAvg);
            this.grp_output.Location = new System.Drawing.Point(12, 184);
            this.grp_output.Name = "grp_output";
            this.grp_output.Size = new System.Drawing.Size(263, 86);
            this.grp_output.TabIndex = 1;
            this.grp_output.TabStop = false;
            // 
            // tbx_turnover
            // 
            this.tbx_turnover.Location = new System.Drawing.Point(104, 57);
            this.tbx_turnover.Name = "tbx_turnover";
            this.tbx_turnover.ReadOnly = true;
            this.tbx_turnover.Size = new System.Drawing.Size(116, 20);
            this.tbx_turnover.TabIndex = 5;
            // 
            // tbx_invAvg
            // 
            this.tbx_invAvg.Location = new System.Drawing.Point(103, 19);
            this.tbx_invAvg.Name = "tbx_invAvg";
            this.tbx_invAvg.ReadOnly = true;
            this.tbx_invAvg.Size = new System.Drawing.Size(117, 20);
            this.tbx_invAvg.TabIndex = 3;
            // 
            // lbl_turnover
            // 
            this.lbl_turnover.AutoSize = true;
            this.lbl_turnover.Location = new System.Drawing.Point(7, 57);
            this.lbl_turnover.Name = "lbl_turnover";
            this.lbl_turnover.Size = new System.Drawing.Size(50, 13);
            this.lbl_turnover.TabIndex = 2;
            this.lbl_turnover.Text = "Turnover";
            // 
            // lbl_invAvg
            // 
            this.lbl_invAvg.AutoSize = true;
            this.lbl_invAvg.Location = new System.Drawing.Point(7, 19);
            this.lbl_invAvg.Name = "lbl_invAvg";
            this.lbl_invAvg.Size = new System.Drawing.Size(94, 13);
            this.lbl_invAvg.TabIndex = 1;
            this.lbl_invAvg.Text = "Average Inventory";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_clear);
            this.pnl_buttons.Controls.Add(this.btn_calc);
            this.pnl_buttons.Controls.Add(this.btn_exit);
            this.pnl_buttons.Location = new System.Drawing.Point(12, 276);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(263, 52);
            this.pnl_buttons.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(92, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(78, 46);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "C&lear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(2, 3);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(84, 46);
            this.btn_calc.TabIndex = 1;
            this.btn_calc.Text = "&Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(176, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 46);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(32, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(217, 25);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Inventory Caculator";
            // 
            // InventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 345);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.grp_output);
            this.Controls.Add(this.grp_input);
            this.Name = "InventoryUI";
            this.Text = "Inventory Calculator";
            this.grp_input.ResumeLayout(false);
            this.grp_input.PerformLayout();
            this.grp_output.ResumeLayout(false);
            this.grp_output.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_input;
        private System.Windows.Forms.GroupBox grp_output;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tbx_invEnd;
        private System.Windows.Forms.TextBox tbx_invStart;
        private System.Windows.Forms.Label lbl_invEnd;
        private System.Windows.Forms.Label lbl_invStart;
        private System.Windows.Forms.TextBox tbx_turnover;
        private System.Windows.Forms.TextBox tbx_invSold;
        private System.Windows.Forms.TextBox tbx_invAvg;
        private System.Windows.Forms.Label lbl_turnover;
        private System.Windows.Forms.Label lbl_invAvg;
        private System.Windows.Forms.Label lbl_invSold;
        private System.Windows.Forms.Label lbl_title;

    }
}

