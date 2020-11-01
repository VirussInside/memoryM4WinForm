/***********************************************************************************************************************************
 *  MEMORIZE
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   30.10.2020
 * 
 *  Description : 
 *      Gaming class that will contain the grid of cards and functions of the game in general like verifying if someone won
 *      or changing players or retrieving their informations. Also contains the labels for the score and attempts.
 * 
 * 
 **********************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Timer gameTimer;            // Timer for the game in seconds
        private Stopwatch stopWatch;        // Stopwatch for the timer
        private int debugCount = 0;         // Counter for special debugging

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


            // Timer processing
            gameTimer = new Timer();
            gameTimer.Interval = (1000);
            gameTimer.Tick += new EventHandler(TimerTick);
            stopWatch = new Stopwatch();
            gameTimer.Start();
            stopWatch.Start();

            SetTextForLabel(GetCurrentPlayer());
        }


        /// <summary>
        /// Processing the ticks of the timer to show seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e)
        {
            lbTimer.Text = stopWatch.Elapsed.Seconds.ToString(); // Elapsed seconds displayed on the label
            Application.DoEvents();
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
        public bool CheckGameFinished()
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
        /// Open score form with winning player stats and time
        /// </summary>
        public void ShowScore()
        {
            // Stop the timer when the game is finished
            gameTimer.Stop();
            stopWatch.Stop();
            string winningTime = stopWatch.Elapsed.Seconds.ToString();

            this.Hide();
            var formScore = new frmScore(GetWinner(), winningTime); 
            formScore.Show();
            formScore.Closed += (s, args) => this.Close();
            this.Dispose();
            GC.Collect();
        }


        /// <summary>
        /// Find the player with the highest score
        /// </summary>
        /// <returns>The game winning player or special tie player</returns>
        private Player GetWinner() {
            Player gameWinner = new Player();
            List<int> scoreList = new List<int>();
            int highestScore = 0;
          
            // Find the player with the highest score
            foreach (Player player in playersList)
            {
                if (player.playerScore > highestScore)
                {
                    highestScore = player.playerScore;
                    gameWinner = player;
                }
                scoreList.Add(player.playerScore); // Add each score to the list 
            }

            // Only if there are more than one player
            if (playersList.Count > 1)
            {
                // Checking if all the scores are the same in case of a tie game
                if (scoreList.Distinct().Count() == 1)
                {
                    gameWinner = new Player("It's a tie !");
                    gameWinner.playerScore = highestScore;
                    gameWinner.playerTie = true;
                }
            }

            return gameWinner;
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


        // Test the winning form without having to finish the memory by clicking on the playername 5 times
        // For testing purposes of the game winning form without having to actually win the game to save time
        private void lbPlayerName_Click(object sender, EventArgs e)
        {
            debugCount++;
            if (debugCount == 5)
            {
                ShowScore();
                debugCount = 0;
            }
           
        }
    }
}
