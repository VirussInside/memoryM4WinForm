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
            this.panMemory = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panMemory
            // 
            this.panMemory.Location = new System.Drawing.Point(61, 56);
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
            this.btExit.Location = new System.Drawing.Point(12, 825);
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
            this.lbAttempts.Location = new System.Drawing.Point(61, 9);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(56, 38);
            this.lbAttempts.TabIndex = 4;
            this.lbAttempts.Text = "0";
            this.lbAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(329, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(66, 38);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPlayer
            // 
            this.lbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.Location = new System.Drawing.Point(677, 834);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(250, 40);
            this.lbPlayer.TabIndex = 6;
            this.lbPlayer.Text = "Player_Name";
            this.lbPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attempts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(846, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(81, 38);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panMemory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 925);
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMemory;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbAttempts;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTimer;
    }
}