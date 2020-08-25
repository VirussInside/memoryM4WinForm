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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btPlay = new System.Windows.Forms.Button();
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.Label();
            this.gbPlayers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Indigo;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Eras Demi ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-3, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Memorize";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Black;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.Font = new System.Drawing.Font("Eras Demi ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.BlueViolet;
            this.btPlay.Location = new System.Drawing.Point(204, 473);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(171, 62);
            this.btPlay.TabIndex = 1;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // gbPlayers
            // 
            this.gbPlayers.Controls.Add(this.rbFour);
            this.gbPlayers.Controls.Add(this.rbThree);
            this.gbPlayers.Controls.Add(this.rbTwo);
            this.gbPlayers.Location = new System.Drawing.Point(80, 128);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(398, 52);
            this.gbPlayers.TabIndex = 5;
            this.gbPlayers.TabStop = false;
            // 
            // rbFour
            // 
            this.rbFour.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFour.AutoSize = true;
            this.rbFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbFour.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFour.Location = new System.Drawing.Point(342, 15);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(29, 29);
            this.rbFour.TabIndex = 2;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = false;
            // 
            // rbThree
            // 
            this.rbThree.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbThree.AutoSize = true;
            this.rbThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbThree.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThree.Location = new System.Drawing.Point(177, 15);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(29, 29);
            this.rbThree.TabIndex = 1;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = false;
            // 
            // rbTwo
            // 
            this.rbTwo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTwo.AutoSize = true;
            this.rbTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbTwo.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTwo.Location = new System.Drawing.Point(30, 15);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(29, 29);
            this.rbTwo.TabIndex = 0;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEasy);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbHard);
            this.groupBox1.Location = new System.Drawing.Point(80, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbEasy
            // 
            this.rbEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEasy.AutoSize = true;
            this.rbEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEasy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbEasy.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(30, 33);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(54, 29);
            this.rbEasy.TabIndex = 3;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = false;
            // 
            // rbMedium
            // 
            this.rbMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbMedium.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(157, 33);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(80, 29);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            // 
            // rbHard
            // 
            this.rbHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHard.AutoSize = true;
            this.rbHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbHard.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(317, 33);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(56, 29);
            this.rbHard.TabIndex = 1;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = false;
            // 
            // cbSubjects
            // 
            this.cbSubjects.BackColor = System.Drawing.Color.Black;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(80, 371);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(159, 22);
            this.cbSubjects.TabIndex = 7;
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulty.ForeColor = System.Drawing.Color.White;
            this.lbDifficulty.Location = new System.Drawing.Point(79, 208);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(91, 23);
            this.lbDifficulty.TabIndex = 8;
            this.lbDifficulty.Text = "Difficulty";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.ForeColor = System.Drawing.Color.White;
            this.lbSubject.Location = new System.Drawing.Point(79, 345);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(76, 23);
            this.lbSubject.TabIndex = 9;
            this.lbSubject.Text = "Subject";
            // 
            // lbPlayers
            // 
            this.lbPlayers.AutoSize = true;
            this.lbPlayers.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayers.ForeColor = System.Drawing.Color.White;
            this.lbPlayers.Location = new System.Drawing.Point(79, 106);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(73, 23);
            this.lbPlayers.TabIndex = 10;
            this.lbPlayers.Text = "Players";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPlayers);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.Text = "Memorize";
            this.gbPlayers.ResumeLayout(false);
            this.gbPlayers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbPlayers;
    }
}

