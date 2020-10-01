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
            this.btTest = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panMemory
            // 
            this.panMemory.Location = new System.Drawing.Point(0, 0);
            this.panMemory.Name = "panMemory";
            this.panMemory.Padding = new System.Windows.Forms.Padding(10);
            this.panMemory.Size = new System.Drawing.Size(660, 660);
            this.panMemory.TabIndex = 0;
            // 
            // btTest
            // 
            this.btTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTest.BackColor = System.Drawing.Color.Indigo;
            this.btTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTest.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTest.Font = new System.Drawing.Font("Lemon/Milk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTest.ForeColor = System.Drawing.Color.GhostWhite;
            this.btTest.Location = new System.Drawing.Point(12, 678);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(171, 62);
            this.btTest.TabIndex = 2;
            this.btTest.Text = "TEST";
            this.btTest.UseVisualStyleBackColor = false;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(681, 39);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(81, 38);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.Text = "9999";
            // 
            // lbAttempts
            // 
            this.lbAttempts.AutoSize = true;
            this.lbAttempts.Font = new System.Drawing.Font("Lemon/Milk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttempts.Location = new System.Drawing.Point(727, 140);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(35, 38);
            this.lbAttempts.TabIndex = 4;
            this.lbAttempts.Text = "0";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.panMemory);
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMemory;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbAttempts;
    }
}