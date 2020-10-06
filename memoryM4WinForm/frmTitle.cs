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
        public frmTitle()
        {
            InitializeComponent();
        }

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
