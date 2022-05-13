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
    public partial class frmAutomaticBeginnerMazeRightRule : Form
    {
        private NonPlayerCharacterRightRule ObjectNPC = new NonPlayerCharacterRightRule();
        // Matriz de 19x19
        private int[,] mMatrix = new int[,]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,0,2,1,1,1,1,1,1,1,1,1,0},// fil 1, col 8 (casillero)
            {0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0},
            {0,1,1,1,1,0,1,0,1,1,1,1,1,1,1,0,1,1,0},
            {0,1,0,0,0,0,1,0,1,0,0,0,0,0,0,0,1,0,0},
            {0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,1,0,0},
            {0,1,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,0,0},
            {0,1,0,0,1,0,0,0,0,1,0,0,0,0,0,0,1,1,0},
            {0,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,0},
            {0,1,0,0,1,0,0,0,1,0,1,0,1,0,0,0,0,0,0},
            {0,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1,1,3,0},
            {0,1,0,0,1,0,0,0,1,0,1,0,1,0,0,0,0,0,0},
            {0,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1,1,1,0},
            {0,1,0,0,1,0,0,0,1,0,1,0,0,0,0,0,0,1,0},
            {0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,0},
            {0,1,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
        };

        public frmAutomaticBeginnerMazeRightRule()
        {
            InitializeComponent();
        }

        private void frmAutomaticBeginnerMaze_Load(object sender, EventArgs e)
        {
            ObjectNPC.CreateMatrix(19, 19);
            ObjectNPC.InitializeMatrix(mMatrix);
            ObjectNPC.InitializeRoad();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            ObjectNPC.LocalizeStart();

            //ObjectNPC.InitializeRapidMovement(picWalker);
            //do
            //{
            //    ObjectNPC.RapidMovementWithAI(picWalker);
            //} while (!ObjectNPC.DetermineFinishDirection(picWalker));

            ObjectNPC.InitializePausedMovement(txtDirection, picWalker);
            do
            {
                ObjectNPC.PausedMovementWithAI(txtDirection, picWalker);
            } while (!ObjectNPC.DetermineFinishDirection(picWalker));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
