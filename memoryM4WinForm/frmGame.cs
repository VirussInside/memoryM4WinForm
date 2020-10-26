﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryM4WinForm
{
    public partial class frmGame : Form
    {
        private string chosenSubject;
        private int chosenDifficulty;
        private int cardsCount;
        private Settings gameSettings;

        public frmGame(Settings SettingsGame)
        {
            InitializeComponent();
            
            gameSettings = SettingsGame;
            chosenSubject = SettingsGame.Subject.ToLower();
            chosenDifficulty = SettingsGame.Difficulty;
            cardsCount = SettingsGame.CardsCount;
            SetGameWindowSize(cardsCount);
        }

        /// <summary>
        /// Create and load the grid filled with images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_Load(object sender, EventArgs e)
        {
            GridMemory gridTest = new GridMemory(this);
            gridTest.FillGrid(cardsCount, panMemory, chosenSubject);
        }


        /// <summary>
        /// Verify if all images have been found by checking if they are hidden
        /// </summary>
        /// <param name="panelImages">Panel that contains all the pictureboxes</param>
        /// <returns>Boolean value for win or not</returns>
        public void CheckWin()
        {
            Boolean allCardsFound = true;
            foreach (PictureBox pbImage in panMemory.Controls)
            {
                if (pbImage.Visible)
                {
                    allCardsFound = false;
                }
            }

            if (allCardsFound)
            {
                ShowScore();
            }
        }

        /// <summary>
        /// Open score form 
        /// </summary>
        private void ShowScore()
        {
            this.Hide();
            var formScore = new frmScore();
            formScore.Closed += (s, args) => this.Close();
            this.Dispose();
            GC.Collect();
            formScore.Show();
        }


        /// <summary>
        /// Updates the text labels for score, attempts and player's name
        /// </summary>
        /// <param name="attempts">Attemps count</param>
        /// <param name="score">Score count</param>
        /// <param name="playerName">Player's name</param>
        public void SetTextForLabel(int attempts, int score, string playerName)
        {
            lbAttempts.Text = attempts.ToString();
            lbScore.Text = score.ToString();
            lbPlayer.Text = playerName;
        }

        /// <summary>
        /// Exit the game completely
        /// </summary>
        /// <param name="sender">Sender, usually exit button</param>
        /// <param name="e"></param>
        private void Exit_Game(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Sets the size of the game window so it fits right regarding the difficulty
        /// </summary>
        private void SetGameWindowSize(int gameCardsCount) {

            int gameSize = chosenDifficulty*100+200;
            Size = new Size(gameSize, gameSize);
            CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
