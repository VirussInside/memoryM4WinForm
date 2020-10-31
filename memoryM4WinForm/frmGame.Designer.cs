namespace memoryM4WinForm
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.panMemory = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panMemory
            // 
            this.panMemory.Location = new System.Drawing.Point(30, 62);
            this.panMemory.Name = "panMemory";
            this.panMemory.Padding = new System.Windows.Forms.Padding(10);
            this.panMemory.Size = new System.Drawing.Size(800, 749);
            this.panMemory.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExit.BackColor = System.Drawing.Color.Indigo;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Lemon/Milk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btExit.Location = new System.Drawing.Point(30, 825);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(172, 49);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit game";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.Exit_Game);
            // 
            // lbAttempts
            // 
            this.lbAttempts.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttempts.Location = new System.Drawing.Point(23, 9);
            this.lbAttempts.MaximumSize = new System.Drawing.Size(250, 38);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(250, 38);
            this.lbAttempts.TabIndex = 4;
            this.lbAttempts.Text = "0";
            this.lbAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(279, 9);
            this.lbScore.MaximumSize = new System.Drawing.Size(250, 38);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(250, 38);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayerName.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(677, 825);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(250, 40);
            this.lbPlayerName.TabIndex = 6;
            this.lbPlayerName.Text = "Name";
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPlayerName.Click += new System.EventHandler(this.lbPlayerName_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(826, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(101, 38);
            this.lbTimer.TabIndex = 9;
            this.lbTimer.Text = "9999";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 886);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panMemory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 925);
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "Memorize";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbAttempts;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbTimer;
        public System.Windows.Forms.Panel panMemory;
    }
}