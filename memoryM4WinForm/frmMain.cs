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
        }


        /// <summary>
        /// Starts the game after validating user's informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlay_Click(object sender, EventArgs e)
        {
            // if fonction validation ok faire la suite sinon remplir infos plsu precises

            this.Hide();
            var formGame = new frmGame();
            formGame.Closed += (s, args) => this.Close();
            formGame.Show();
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
                case "Cars":
                    pbPreview.Image = Properties.Resources.car1;
                    break;

                case "Australia":
                    pbPreview.Image = Properties.Resources.australia1;
                    break;

                case "Food":
                    //pbPreview.Image = Properties.Resources.food1;
                    pbPreview.Hide();
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
