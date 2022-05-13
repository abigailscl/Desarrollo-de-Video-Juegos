using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMazeGame
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnManualBeginnerMaze_Click(object sender, EventArgs e)
        {
            frmManualBeginnerMaze ObjForm = new frmManualBeginnerMaze();
            ObjForm.Show();
        }       

        private void btnAutomaticBeginnerMazeRightRule_Click(object sender, EventArgs e)
        {
            frmAutomaticBeginnerMazeRightRule ObjForm = new frmAutomaticBeginnerMazeRightRule();
            ObjForm.Show();
        }

        private void btnAutomaticBeginnerMazeLeftRule_Click(object sender, EventArgs e)
        {
            frmAutomaticBeginnerMazeLeftRule ObjForm = new frmAutomaticBeginnerMazeLeftRule();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
