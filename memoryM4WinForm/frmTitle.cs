/***********************************************************************************************************************************
 *  MEMORIZE
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   30.10.2020
 * 
 *  Description : 
 *      Shows the game logo and title before continuing in the game
 * 
 **********************************************************************************************************************************/

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
    public partial class frmTitle : Form
    {
        /// <summary>
        /// Constructor of the title form
        /// </summary>
        public frmTitle()
        {
            InitializeComponent();
            CenterToScreen();
        }

        /// <summary>
        /// Enters the game after the click on title
        /// </summary>
        /// <param name="sender">Title picturebox</param>
        /// <param name="e"></param>
        private void pbMemorizeTitle_Click(object sender, EventArgs e)
        {
            Hide();
            var formMain = new frmMain();
            formMain.Closed += (s, args) => this.Close();
            GC.Collect();
            formMain.Show();
        }
    }
}
