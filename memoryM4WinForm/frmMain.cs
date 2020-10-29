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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
        }


        /// <summary>
        /// Starts the game after validating user's informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlay_Click(object sender, EventArgs e)
        {
            Settings gameSettings = GetSettings();

            // Checking if all settings are correct
            if (ValidateSettings())
            {
                var formGame = new frmGame(gameSettings, CreatePlayers(gameSettings.PlayerCount));
                this.Hide();
                formGame.Closed += (s, args) => this.Close();
                formGame.Show();
            }
            else
            {
                MessageBox.Show("Some settings are missing !");
            }

        }

        /// <summary>
        /// Check if all settings needed are filled and correct
        /// </summary>
        /// <returns>Boolean value if settings are correct</returns>
        private Boolean ValidateSettings() {
            Boolean validSettings = true;

            if (cbSubjects.Text.Equals(""))
                validSettings = false;

            return validSettings;
        }

        /// <summary>
        /// Collect game settings before creating the game
        /// </summary>
        /// <returns>Settings object</returns>
        private Settings GetSettings()
        {
            int playerCount = 1;
            int difficulty = 3;
            string subject = "nature";

            foreach (Control c in gbPlayers.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton rbPlayer = c as RadioButton;
                    if (rbPlayer.Checked)
                    {
                        playerCount = Int32.Parse(rbPlayer.Tag.ToString());
                    }
                }
            }

            foreach (Control c in gbDifficulty.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton rbDifficulty = c as RadioButton;
                    if (rbDifficulty.Checked)
                    {
                        difficulty = Int32.Parse(rbDifficulty.Tag.ToString());
                    }
                }
            }

            if (ValidateSettings())
            {
                subject = cbSubjects.Text;
            }

            Settings collectedSettings = new Settings(difficulty, playerCount, subject);

            return collectedSettings;
        }


        /// <summary>
        /// Creates the players with their informations
        /// </summary>
        private List<Player> CreatePlayers(int playerCount)
        {
            List<Player> playersList = new List<Player>();
            switch (playerCount)
            {
                case 1:
                    playersList.Add(new Player(RequestPlayerName(1)));
                    break;
                case 2:
                    playersList.Add(new Player(RequestPlayerName(1)));
                    playersList.Add(new Player(RequestPlayerName(2)));
                    break;
                case 3:
                    playersList.Add(new Player(RequestPlayerName(1)));
                    playersList.Add(new PlayerIA("IA"));
                    break;
                default:
                    break;
            }
            return playersList;
        }


        /// <summary>
        /// Askss the player to enter his name
        /// </summary>
        /// <returns>Player's entered name</returns>
        private string RequestPlayerName(int playerNumber)
        {
            string PlayerName = "";

            using (var formPlayerName = new frmPlayerName(playerNumber))
            {
                var result = formPlayerName.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlayerName = formPlayerName.EnteredName;            //values preserved after close
                }
            }
            return PlayerName;
        }


        /// <summary>
        /// Managing the subjects selection events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPreview.Show();

            switch (cbSubjects.SelectedItem.ToString())
            {
                case "Car":
                    pbPreview.Image = Properties.Resources.car1;
                    break;

                case "Australia":
                    pbPreview.Image = Properties.Resources.australia1;
                    break;

                case "Food":
                    pbPreview.Image = Properties.Resources.food1;
                    break;

                case "Nature":
                    pbPreview.Image = Properties.Resources.nature1;
                    break;

                default:
                    pbPreview.Hide();
                    break;
            }
        }
    }
}
