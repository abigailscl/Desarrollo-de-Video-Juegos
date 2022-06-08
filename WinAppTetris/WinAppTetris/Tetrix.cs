using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTetris
{
    public partial class Tetrix : Form
    {

        
        
        private bool stillProcessing = false;
        private int score = 0;
        //private Block CurrentBlock;
        //private Block NextBlock;

        public Tetrix()
        {
            InitializeComponent();
        }

        private void Tetrix_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void tmrGameClock_Tick(object sender, System.EventArgs e)
		{
			int erasedLines;

			if (stillProcessing) return;
			stillProcessing = true;

			//Manage the falling block
			if (!CurrentBlock.Down())
			{
				if (CurrentBlock.Top() == 0)
				{
					tmrGameClock.Enabled = false;
					CmdStart.Enabled = true;
					MessageBox.Show("GAME OVER", ".NETTrix", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					stillProcessing = false;
					return;
				}
				//increase score based on # of deleted lines
				erasedLines = GameField.CheckLines();
				if (erasedLines > 0)
				{
					score += 100 * erasedLines;
					lblScoreValue.Text = score.ToString();
					//Clear the game field and force the window to re-paint
					PicBackground.Invalidate();
					Application.DoEvents();
					GameField.Redraw();
				}

				//Replace the current block...
				CurrentBlock = new Block(new Point(GameField.SquareSize * 6, 0), NextBlock.BlockType);
				CurrentBlock.Show(PicBackground.Handle);

				//Create the Next block
				NextBlock.Hide(PicNextBlock.Handle);
				NextBlock = new Block(new Point(20, 10), Block.BlockTypes.Undefined);
				NextBlock.Show(PicNextBlock.Handle);
			}
			stillProcessing = false;
		}
	}
}
