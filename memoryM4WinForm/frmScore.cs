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
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
            CenterToScreen();
        }

        /// <summary>
        /// Leaving the game by clicking exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExit_Click(object sender, EventArgs e)
        {
            string caption = "Memorize";
            string message = "Would you like to leave the game ? 🤷‍♀️";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Show a messagebox to prevent accidental exit of the game
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Dispose();
                GC.Collect();
                Application.Exit();
            }
        }


        /// <summary>
        /// Restart a game by going to the main form for subject and difficulty selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formMain = new frmMain();
            this.Dispose();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }
    }
}
