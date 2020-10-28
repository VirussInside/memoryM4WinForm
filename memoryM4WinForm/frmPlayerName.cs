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
    public partial class frmPlayerName : Form
    {
        /// <summary>
        /// Constructor of the form
        /// </summary>
        public frmPlayerName(int playerNumber)
        {
            InitializeComponent();
            lbPlayerName.Text = "Player " + playerNumber;
            CenterToScreen();
        }

        /// <summary>
        /// Confirm the input of the name
        /// </summary>
        /// <param name="sender">Confirm button</param>
        /// <param name="e">Events</param>
        private void btConfirmName_Click(object sender, EventArgs e)
        {
            ValidateName();
        }

        // Autopropriety for the entered name
        public string EnteredName { get; set; }


        /// <summary>
        /// Validating the entered name
        /// </summary>
        private void ValidateName() {
            if (tbName.Text.Length > 0)
            {
                this.EnteredName = tbName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbInstructions.Visible = true;
            }
        }

        /// <summary>
        /// Management of pressed buttons in player name textbox
        /// </summary>
        /// <param name="sender">Textbox</param>
        /// <param name="e">KeyEvents</param>
        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter on textbox
            if (e.KeyCode == Keys.Return)
            {
                ValidateName();
            }
        }
    }
}
