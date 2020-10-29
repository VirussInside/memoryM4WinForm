using System;
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

        private string chosenSubject;       // Subject for the cards
        private int chosenDifficulty;       // Difficulty rate
        private int cardsCount;             // Number of card in total
        private int activePlayer = 0;       // Sets the active player
        private Settings gameSettings;      // All settings of the game
        private List<Player> playersList;   // All players for the game


        /// <summary>
        /// Constructor of the game form
        /// </summary>
        /// <param name="SettingsGame">Settings of the game</param>
        /// <param name="players">Players list</param>
        public frmGame(Settings SettingsGame, List<Player> players)
        {
            InitializeComponent();
            playersList = new List<Player>();
            playersList = players;
            gameSettings = SettingsGame;
            chosenSubject = SettingsGame.Subject.ToLower();
            chosenDifficulty = SettingsGame.Difficulty;
            cardsCount = SettingsGame.CardsCount;
            SetGameWindowSize();
            SetTextForLabel(GetCurrentPlayer());
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
        public bool CheckWin()
        {
            Boolean allCardsFound = true;
            foreach (PictureBox pbImage in panMemory.Controls)
            {
                if (pbImage.Visible)
                {
                    allCardsFound = false;
                }
            }
            return allCardsFound;
        }

        /// <summary>
        /// Open score form 
        /// </summary>
        public void ShowScore()
        {
            Player theWinner = GetCurrentPlayer();
            this.Hide();
            var formScore = new frmScore(theWinner);
            formScore.Show();
            formScore.Closed += (s, args) => this.Close();
            this.Dispose();
            GC.Collect();
        }

        /// <summary>
        /// Switching between players
        /// </summary>
        public void ChangePlayer() {
            if (activePlayer < playersList.Count()-1)
                activePlayer++;
            else
                activePlayer = 0;
        }

        /// <summary>
        /// Retrieves the current active player
        /// </summary>
        /// <returns>Active player</returns>
        public Player GetCurrentPlayer() {

            // Only one player
            if (playersList.Count() == 1)
                activePlayer = 0; // Stays the first player

            return playersList[activePlayer];
        }

        /// <summary>
        /// Updates the text labels for score, attempts and player's name
        /// </summary>
        /// <param name="attempts">Attemps count</param>
        /// <param name="score">Score count</param>
        /// <param name="playerName">Player's name</param>
        public void SetTextForLabel(Player currentPlayer)
        {
            lbAttempts.Text = "Attempts " + currentPlayer.playerAttempts.ToString();
            lbScore.Text = "Score : " + currentPlayer.playerScore.ToString();
            lbPlayerName.Text = currentPlayer.playerName;
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
        private void SetGameWindowSize() {

            // Calculate the needed size for the width and height of the window
            int gameSize = chosenDifficulty*100+220;
            Size = new Size(gameSize, gameSize);
            CenterToScreen();
        }


        // Test the winning form without having to finish the memory by clicking on the playername
        private void lbPlayerName_Click(object sender, EventArgs e)
        {
            ShowScore();
        }
    }
}
