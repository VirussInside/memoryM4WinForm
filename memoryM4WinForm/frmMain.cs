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
            string caption = "Hello";
            string message = "Quitter ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }


        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubjects.SelectedItem.ToString() == "Cars") {
                MessageBox.Show("Voituressss");
                pictureBox1.Image = Properties.Resources.car1;
            }
            else if (cbSubjects.SelectedItem.ToString() == "Cars")
            {
                MessageBox.Show("Voituressss");
                pictureBox1.Image = Properties.Resources.car1;
            }
            else if (cbSubjects.SelectedItem.ToString() == "Cars")
            {
                MessageBox.Show("Voituressss");
                pictureBox1.Image = Properties.Resources.car1;
            }
            else if (cbSubjects.SelectedItem.ToString() == "Australia")
            {
                pictureBox1.Image = Properties.Resources.australia1;
            };
        }
    }
}
