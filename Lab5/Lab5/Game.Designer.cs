namespace Lab5
{
    partial class Game
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
            this.pnlDice = new System.Windows.Forms.Panel();
            this.pnlDie2 = new System.Windows.Forms.Panel();
            this.pnlDie1 = new System.Windows.Forms.Panel();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDice
            // 
            this.pnlDice.Controls.Add(this.pnlDie2);
            this.pnlDice.Controls.Add(this.pnlDie1);
            this.pnlDice.Location = new System.Drawing.Point(12, 12);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(300, 150);
            this.pnlDice.TabIndex = 0;
            // 
            // pnlDie2
            // 
            this.pnlDie2.Location = new System.Drawing.Point(155, 5);
            this.pnlDie2.Name = "pnlDie2";
            this.pnlDie2.Size = new System.Drawing.Size(140, 140);
            this.pnlDie2.TabIndex = 1;
            // 
            // pnlDie1
            // 
            this.pnlDie1.Location = new System.Drawing.Point(5, 5);
            this.pnlDie1.Name = "pnlDie1";
            this.pnlDie1.Size = new System.Drawing.Size(140, 140);
            this.pnlDie1.TabIndex = 0;
            // 
            // btnRoll
            // 
            this.btnRoll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoll.FlatAppearance.BorderSize = 0;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRoll.Image = global::Lab5.Properties.Resources.diceRoll;
            this.btnRoll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoll.Location = new System.Drawing.Point(59, 234);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(200, 145);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.SystemColors.Control;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(108, 201);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(80, 25);
            this.lblPoint.TabIndex = 2;
            this.lblPoint.Text = "Point: ";
            this.lblPoint.Visible = false;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.SystemColors.Control;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(121, 165);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(67, 25);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll: ";
            this.lblRoll.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab5.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(324, 387);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pnlDice);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps";
            this.pnlDice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDice;
        private System.Windows.Forms.Panel pnlDie2;
        private System.Windows.Forms.Panel pnlDie1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Timer timer1;

    }
}

