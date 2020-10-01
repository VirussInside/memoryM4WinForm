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
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            GridMemory.FillGrid(16, panMemory);
        }

        private void panMemory_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //var formScore = new frmScore();
            //formScore.Closed += (s, args) => this.Close();
            //formScore.Show();
        }
    }
}
