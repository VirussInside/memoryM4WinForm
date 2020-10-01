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
            pictureBox1.Show();

            switch (cbSubjects.SelectedItem.ToString())
            {
                case "Cars":
                    pictureBox1.Image = Properties.Resources.car1;
                    break;

                case "Australia":
                    //pictureBox1.Image = Properties.Resources.australia1;
                    break;

                case "Jura":
                    //pictureBox1.Image = Properties.Resources.jura1;
                    pictureBox1.Hide();
                    break;

                case "Nature":
                    pictureBox1.Image = Properties.Resources.nature1;
                    break;

                default:
                    pictureBox1.Hide();
                    break;
            }
        }

        private void btPlay_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
