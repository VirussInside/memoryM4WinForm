namespace memoryM4WinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPlay = new System.Windows.Forms.Button();
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.rbIA = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.Label();
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.panGame = new System.Windows.Forms.Panel();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.gbPlayers.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            this.panGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlay.BackColor = System.Drawing.Color.Indigo;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Lemon/Milk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.GhostWhite;
            this.btPlay.Location = new System.Drawing.Point(525, 43);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(171, 62);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // gbPlayers
            // 
            this.gbPlayers.Controls.Add(this.rbIA);
            this.gbPlayers.Controls.Add(this.rbTwo);
            this.gbPlayers.Controls.Add(this.rbOne);
            this.gbPlayers.Location = new System.Drawing.Point(45, 68);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(210, 94);
            this.gbPlayers.TabIndex = 5;
            this.gbPlayers.TabStop = false;
            // 
            // rbIA
            // 
            this.rbIA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbIA.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbIA.FlatAppearance.BorderSize = 2;
            this.rbIA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbIA.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIA.Location = new System.Drawing.Point(142, 33);
            this.rbIA.Name = "rbIA";
            this.rbIA.Size = new System.Drawing.Size(40, 40);
            this.rbIA.TabIndex = 2;
            this.rbIA.TabStop = true;
            this.rbIA.Tag = "3";
            this.rbIA.Text = "IA";
            this.rbIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbIA.UseVisualStyleBackColor = false;
            // 
            // rbTwo
            // 
            this.rbTwo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTwo.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbTwo.FlatAppearance.BorderSize = 2;
            this.rbTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbTwo.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTwo.Location = new System.Drawing.Point(86, 33);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(40, 40);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.TabStop = true;
            this.rbTwo.Tag = "2";
            this.rbTwo.Text = "2";
            this.rbTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTwo.UseVisualStyleBackColor = false;
            // 
            // rbOne
            // 
            this.rbOne.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbOne.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOne.Checked = true;
            this.rbOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOne.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbOne.FlatAppearance.BorderSize = 2;
            this.rbOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbOne.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOne.Location = new System.Drawing.Point(25, 33);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(40, 40);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Tag = "1";
            this.rbOne.Text = "1";
            this.rbOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOne.UseVisualStyleBackColor = false;
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbEasy);
            this.gbDifficulty.Controls.Add(this.rbMedium);
            this.gbDifficulty.Controls.Add(this.rbHard);
            this.gbDifficulty.Location = new System.Drawing.Point(298, 68);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(295, 94);
            this.gbDifficulty.TabIndex = 6;
            this.gbDifficulty.TabStop = false;
            // 
            // rbEasy
            // 
            this.rbEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEasy.AutoSize = true;
            this.rbEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbEasy.Checked = true;
            this.rbEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEasy.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbEasy.FlatAppearance.BorderSize = 2;
            this.rbEasy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbEasy.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(30, 33);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(59, 33);
            this.rbEasy.TabIndex = 3;
            this.rbEasy.TabStop = true;
            this.rbEasy.Tag = "4";
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = false;
            // 
            // rbMedium
            // 
            this.rbMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbMedium.FlatAppearance.BorderSize = 2;
            this.rbMedium.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbMedium.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(104, 33);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(84, 33);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "6";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            // 
            // rbHard
            // 
            this.rbHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHard.AutoSize = true;
            this.rbHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHard.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.rbHard.FlatAppearance.BorderSize = 2;
            this.rbHard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbHard.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(200, 33);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(64, 33);
            this.rbHard.TabIndex = 1;
            this.rbHard.TabStop = true;
            this.rbHard.Tag = "8";
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = false;
            // 
            // cbSubjects
            // 
            this.cbSubjects.BackColor = System.Drawing.Color.Lavender;
            this.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubjects.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Items.AddRange(new object[] {
            "Australia",
            "Car",
            "Food",
            "Nature"});
            this.cbSubjects.Location = new System.Drawing.Point(45, 217);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(159, 31);
            this.cbSubjects.Sorted = true;
            this.cbSubjects.TabIndex = 7;
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbSubjects_SelectedIndexChanged);
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulty.ForeColor = System.Drawing.Color.Black;
            this.lbDifficulty.Location = new System.Drawing.Point(294, 46);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(114, 27);
            this.lbDifficulty.TabIndex = 8;
            this.lbDifficulty.Text = "Difficulty";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.ForeColor = System.Drawing.Color.Black;
            this.lbSubject.Location = new System.Drawing.Point(41, 189);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(93, 27);
            this.lbSubject.TabIndex = 9;
            this.lbSubject.Text = "Subject";
            // 
            // lbPlayers
            // 
            this.lbPlayers.AutoSize = true;
            this.lbPlayers.Font = new System.Drawing.Font("Lemon/Milk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayers.ForeColor = System.Drawing.Color.Black;
            this.lbPlayers.Location = new System.Drawing.Point(41, 46);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(90, 27);
            this.lbPlayers.TabIndex = 11;
            this.lbPlayers.Text = "Players";
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.AutoSize = true;
            this.lbGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbGameTitle.Font = new System.Drawing.Font("Lemon/Milk", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTitle.ForeColor = System.Drawing.Color.White;
            this.lbGameTitle.Location = new System.Drawing.Point(79, 20);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(428, 103);
            this.lbGameTitle.TabIndex = 13;
            this.lbGameTitle.Text = "Memorize";
            // 
            // panGame
            // 
            this.panGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panGame.BackColor = System.Drawing.Color.DarkViolet;
            this.panGame.Controls.Add(this.lbGameTitle);
            this.panGame.Controls.Add(this.btPlay);
            this.panGame.Location = new System.Drawing.Point(-85, 477);
            this.panGame.MinimumSize = new System.Drawing.Size(650, 650);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(724, 650);
            this.panGame.TabIndex = 14;
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(298, 217);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(200, 200);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 12;
            this.pbPreview.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.gbPlayers);
            this.Controls.Add(this.panGame);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "frmMain";
            this.Text = "Memorize";
            this.gbPlayers.ResumeLayout(false);
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.panGame.ResumeLayout(false);
            this.panGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.RadioButton rbIA;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbPlayers;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Panel panGame;
    }
}

