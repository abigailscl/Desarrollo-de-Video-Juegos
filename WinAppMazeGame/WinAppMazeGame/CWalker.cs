using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace WinAppMazeGame
{
    class CWalker
    {
        private int[,] mMatrix;
        private int mRow, mColumn;
        private int mM, mN;

        /// <summary>
        /// Chat-Bot
        /// </summary>

        private Choices mTable;
        private Grammar mElements;

        public Choices Table { get => mTable; set => mTable = value; }
        public Grammar Elements { get => mElements; set => mElements = value; }

        public CWalker()
        {
            mRow = 0; mColumn = 0;
            mM = 0; mN = 0;
        }

        // ObjectWalker.CreateMatrix(19, 19);
        // r = 20; c = 20s;
        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }

        // ObjectWalker.InitializeMatrix(mMatrix);
        // a = mMatrix;
        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            // Bucle externo que controla las filas de la matriz.
            for (i = 0; i < mM; i++)
            {
                // Bucle interno que controla las columnas de la matriz.
                for (j = 0; j < mN; j++)
                {
                    mMatrix[i, j] = a[i, j];
                }
            }
        }

        // ObjectWalker.InitializeRoad();
        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        // ObjectWalker.LocalizeStart();
        // mRow = 0; mColumn = 0;
        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    if (mMatrix[i, j] == 2)
                    {                        
                        mRow = i; mColumn = j;
                        // mRow = 0; mColumn = 0;
                        return; //sale de la funcion //break, rompe uno de los bucles (el interno)
                    }
                }
            }
        }

        public void MoveRightSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left + 25;
            mColumn++;
        }

        public void MoveLeftSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left - 25;
            mColumn--;
        }

        public void MoveUpSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top - 25;
            mRow--;
        }

        public void MoveDownSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top + 25;
            mRow++;
        }

        // ObjectWalker.ControlMovesInLaberynth(picWalker, e);
        // picWalker = picWalker; e = e;
        public void ControlMovesInLaberynth(PictureBox picWalker, KeyEventArgs e)
        {
            if (mMatrix[mRow, mColumn] != 3)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    // Validar o controlar el movimiento inminente.
                    if (mMatrix[mRow, mColumn + 1] != 0)
                    {
                        MoveRightSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    // Validar o controlar el movimiento inminente.
                    if (mMatrix[mRow, mColumn - 1] != 0)
                    {
                        MoveLeftSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    // Validar o controlar el movimiento inminente.
                    if (mMatrix[mRow - 1, mColumn] != 0)
                    {
                        MoveUpSide(picWalker);
                    }
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    // Validar o controlar el movimiento inminente.
                    if (mMatrix[mRow + 1, mColumn] != 0)
                    {
                        MoveDownSide(picWalker);
                    }
                }
                if (mMatrix[mRow, mColumn] == 3)
                {
                    MessageBox.Show("Felicitaciones, buen trabajo.",
                                "Mensaje de control");
                    picWalker.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Chat-Bot
        /// </summary>

        public void InitializeGrammar()
        {
            mTable = new Choices();
            mTable.Add(new string[] { "right",
                                      "left",
                                      "up",
                                      "down" });
            mElements = new Grammar(new GrammarBuilder(mTable));
        }

        public void ControlSpeechMoves(PictureBox picWalker,
                                       TextBox txtData,
                                       SpeechRecognizedEventArgs e)
        {
            if(mMatrix[mRow, mColumn] != 3)
            {
                if (e.Result.Text == "right")
                {
                    if (mMatrix[mRow, mColumn + 1] != 0)
                    {
                        MoveRightSide(picWalker);
                    }
                }
                else if (e.Result.Text == "left")
                {
                    if (mMatrix[mRow, mColumn - 1] != 0)
                    {
                        MoveLeftSide(picWalker);
                    }
                }
                else if (e.Result.Text == "up")
                {
                    if (mMatrix[mRow - 1, mColumn] != 0)
                    {
                        MoveUpSide(picWalker);
                    }
                }
                else if (e.Result.Text == "down")
                {
                    if (mMatrix[mRow + 1, mColumn] != 0)
                    {
                        MoveDownSide(picWalker);
                    }
                }
                else
                {
                    txtData.Text = txtData.Text + " " + e.Result.Text.ToString();
                }
            }            
        }

    }
}
