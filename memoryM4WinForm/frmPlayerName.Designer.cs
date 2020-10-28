namespace memoryM4WinForm
{
    partial class frmPlayerName
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
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btConfirmName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Font = new System.Drawing.Font("Lemon/Milk light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbInstructions.Location = new System.Drawing.Point(19, 96);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(195, 14);
            this.lbInstructions.TabIndex = 14;
            this.lbInstructions.Text = "Please choose a name don\'t be shy";
            this.lbInstructions.Visible = false;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lbPlayerName.Location = new System.Drawing.Point(17, 28);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(80, 27);
            this.lbPlayerName.TabIndex = 13;
            this.lbPlayerName.Text = "Player";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Indigo;
            this.tbName.Location = new System.Drawing.Point(22, 63);
            this.tbName.MaxLength = 25;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 30);
            this.tbName.TabIndex = 12;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // btConfirmName
            // 
            this.btConfirmName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConfirmName.BackColor = System.Drawing.Color.Indigo;
            this.btConfirmName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirmName.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btConfirmName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btConfirmName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btConfirmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmName.Font = new System.Drawing.Font("Lemon/Milk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmName.ForeColor = System.Drawing.Color.GhostWhite;
            this.btConfirmName.Location = new System.Drawing.Point(241, 127);
            this.btConfirmName.Name = "btConfirmName";
            this.btConfirmName.Size = new System.Drawing.Size(135, 49);
            this.btConfirmName.TabIndex = 11;
            this.btConfirmName.Text = "Confirm";
            this.btConfirmName.UseVisualStyleBackColor = false;
            this.btConfirmName.Click += new System.EventHandler(this.btConfirmName_Click);
            // 
            // frmPlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 198);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btConfirmName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlayerName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Button btConfirmName;
        public System.Windows.Forms.TextBox tbName;
    }
}