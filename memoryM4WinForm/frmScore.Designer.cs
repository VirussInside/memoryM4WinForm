namespace memoryM4WinForm
{
    partial class frmScore
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
            this.lbCongrats = new System.Windows.Forms.Label();
            this.btPlayAgain = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCongrats
            // 
            this.lbCongrats.AutoSize = true;
            this.lbCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lbCongrats.Font = new System.Drawing.Font("Lemon/Milk", 55F, System.Drawing.FontStyle.Italic);
            this.lbCongrats.ForeColor = System.Drawing.Color.White;
            this.lbCongrats.Location = new System.Drawing.Point(140, 152);
            this.lbCongrats.Name = "lbCongrats";
            this.lbCongrats.Size = new System.Drawing.Size(515, 105);
            this.lbCongrats.TabIndex = 14;
            this.lbCongrats.Text = "Congrats ! ";
            // 
            // btPlayAgain
            // 
            this.btPlayAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlayAgain.BackColor = System.Drawing.Color.Indigo;
            this.btPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlayAgain.Font = new System.Drawing.Font("Lemon/Milk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayAgain.ForeColor = System.Drawing.Color.GhostWhite;
            this.btPlayAgain.Location = new System.Drawing.Point(528, 376);
            this.btPlayAgain.Name = "btPlayAgain";
            this.btPlayAgain.Size = new System.Drawing.Size(260, 62);
            this.btPlayAgain.TabIndex = 15;
            this.btPlayAgain.Text = "Play again";
            this.btPlayAgain.UseVisualStyleBackColor = false;
            this.btPlayAgain.Click += new System.EventHandler(this.btPlayAgain_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Indigo;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Lemon/Milk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btExit.Location = new System.Drawing.Point(12, 376);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(134, 62);
            this.btExit.TabIndex = 16;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPlayAgain);
            this.Controls.Add(this.lbCongrats);
            this.Name = "frmScore";
            this.Text = "frmScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCongrats;
        private System.Windows.Forms.Button btPlayAgain;
        private System.Windows.Forms.Button btExit;
    }
}