namespace memoryM4WinForm
{
    partial class frmTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.pbMemorizeTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemorizeTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMemorizeTitle
            // 
            this.pbMemorizeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMemorizeTitle.BackColor = System.Drawing.Color.Violet;
            this.pbMemorizeTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMemorizeTitle.Image = global::memoryM4WinForm.Properties.Resources.memorize_title_continue;
            this.pbMemorizeTitle.Location = new System.Drawing.Point(-1, -1);
            this.pbMemorizeTitle.Name = "pbMemorizeTitle";
            this.pbMemorizeTitle.Size = new System.Drawing.Size(636, 613);
            this.pbMemorizeTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemorizeTitle.TabIndex = 0;
            this.pbMemorizeTitle.TabStop = false;
            this.pbMemorizeTitle.Click += new System.EventHandler(this.pbMemorizeTitle_Click);
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.pbMemorizeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "frmTitle";
            this.Text = "Memorize";
            ((System.ComponentModel.ISupportInitialize)(this.pbMemorizeTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMemorizeTitle;
    }
}