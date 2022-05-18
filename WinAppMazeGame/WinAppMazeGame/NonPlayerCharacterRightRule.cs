using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.Threading;

namespace WinAppMazeGame
{
    public enum Direction
    {
        Up,   // 0 (Field)
        Down, // 1 (Field)
        Left, // 2 (Field)
        Right // 3 (Field)
    }

    // NPC AI gamer

    class NonPlayerCharacterRightRule
    {
        // Data Members - Atributes.
        private int[,] mMatrix;
        private int mRow, mColumn;
        private int mM, mN;
        private Direction mDirection;
        private int mMiliseconds;

        // Constructor without parameters.
        public NonPlayerCharacterRightRule()
        {
            mRow = 0; mColumn = 0;
            mM = 0; mN = 0;
            // 1000 milisegundos -> 1 seg
            // 100 milisegundos -> 1/10 de 1 seg
            mMiliseconds = 100;
        }

        // ObjectNPC.CreateMatrix(19, 19);
        // r = 19; c = 19;
        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }

        // ObjectNPC.InitializeMatrix(mMatrix);
        // a = mMatrix;
        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    mMatrix[i, j] = a[i, j];
                }
            }
        }

        // ObjectNPC.InitializeRoad();
        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        // ObjectNPC.LocalizeStart();
        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
            {
                for (j = 0; j < mN; j++)
                {
                    if (mMatrix[i, j] == 2)
                    {
                        // mRow = 1; mColumn = 8;
                        mRow = i; mColumn = j;
                        return;
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

        public void DetermineStartDirection()
        {
            // 2, 1 (Primer 1 ha estado ubicado a la Derecha)
            if (mMatrix[mRow, mColumn + 1] != 0)
            {
                mDirection = Direction.Right;
            }
            else if (mMatrix[mRow, mColumn - 1] != 0)
            {
                mDirection = Direction.Left;
            }
            else if (mMatrix[mRow - 1, mColumn] != 0)
            {
                mDirection = Direction.Up;
            }
            else if (mMatrix[mRow + 1, mColumn] != 0)
            {
                mDirection = Direction.Down;
            }
        }
                
        public void InitializeRapidMovement(PictureBox picWalker)
        {
            DetermineStartDirection();

            switch (mDirection)
            {
                case Direction.Down:
                    MoveDownSide(picWalker);
                    break;
                case Direction.Up:
                    MoveUpSide(picWalker);
                    break;
                case Direction.Right:
                    MoveRightSide(picWalker);
                    break;
                case Direction.Left:
                    MoveLeftSide(picWalker);
                    break;
            }
        }

        // // ObjectNPC.InitializePausedMovement(txtDirection, picWalker);
        // txtDirection = txtDirection; picWalker = picWalker;
        public void InitializePausedMovement(TextBox txtDirection,
                                             PictureBox picWalker)
        {
            DetermineStartDirection();

            switch (mDirection)
            {
                case Direction.Down:
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Up:
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Right:
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
                case Direction.Left:
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                    txtDirection.Text = mDirection.ToString();
                    break;
            }
        }

        public bool DetermineFinishDirection(PictureBox picWalker)
        {
            if (mMatrix[mRow, mColumn + 1] == 3)
            {
                mDirection = Direction.Right;
                MoveRightSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow, mColumn - 1] == 3)
            {
                mDirection = Direction.Left;
                MoveLeftSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow - 1, mColumn] == 3)
            {
                mDirection = Direction.Up;
                MoveUpSide(picWalker);
                return true;
            }
            else if (mMatrix[mRow + 1, mColumn] == 3)
            {
                mDirection = Direction.Down;
                MoveDownSide(picWalker);
                return true;
            }
            else
                return false;
        }

        public bool ObserveRightSide()
        {
            if (mMatrix[mRow, mColumn + 1] != 0)
                return true;
            else
                return false;
        }

        public bool ObserveLeftSide()
        {
            if (mMatrix[mRow, mColumn - 1] != 0)
                return true;
            else
                return false;
        }

        public bool ObserveUpSide()
        {
            if (mMatrix[mRow - 1, mColumn] != 0)
                return true;
            else
                return false;
        }

        public bool ObserveDownSide()
        {
            if (mMatrix[mRow + 1, mColumn] != 0)
                return true;
            else
                return false;
        }

        public void RapidMovementWithAI(PictureBox picWalker)
        {
            if (mDirection == Direction.Right)
            {
                if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    MoveRightSide(picWalker);
                }
                else if (ObserveUpSide() == true && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    MoveRightSide(picWalker);
                }
                else if (ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                }
                else if (ObserveUpSide() == true && ObserveDownSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Up;
                    MoveUpSide(picWalker);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Left;
                    MoveLeftSide(picWalker);
                }
            }

            if (mDirection == Direction.Left)
            {
                if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    MoveLeftSide(picWalker);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == true && ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    MoveLeftSide(picWalker);
                }
                else if (ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    MoveUpSide(picWalker);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == true && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Right;
                    MoveRightSide(picWalker);
                }
            }

            if (mDirection == Direction.Up)
            {
                if (ObserveLeftSide() == false && ObserveRightSide() == false && ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    MoveUpSide(picWalker);
                }
                else if (ObserveLeftSide() == true && ObserveRightSide() == false && ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    MoveUpSide(picWalker);
                }
                else if (ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    MoveRightSide(picWalker);
                }
                else if (ObserveLeftSide() == true && ObserveUpSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Left;
                    MoveLeftSide(picWalker);
                }
                else if (ObserveUpSide() == false && ObserveRightSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                }
            }

            if (mDirection == Direction.Down)
            {
                if (ObserveLeftSide() == false && ObserveRightSide() == false && ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                }
                else if (ObserveLeftSide() == false && ObserveRightSide() == true && ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                }
                else if (ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    MoveLeftSide(picWalker);
                }
                else if (ObserveLeftSide() == false && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    MoveRightSide(picWalker);
                }
                else if (ObserveDownSide() == false && ObserveRightSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Up;
                    MoveUpSide(picWalker);
                }
            }

        }

        // ObjectNPC.PausedMovementWithAI(txtDirection, picWalker);
        // txtDirection = txtDirection; picWalker = picWalker;
        public void PausedMovementWithAI(TextBox txtDirection,
                                         PictureBox picWalker)
        {
            if (mDirection == Direction.Right)
            {
                if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    txtDirection.Text = mDirection.ToString();
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == true && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    txtDirection.Text = mDirection.ToString();
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    txtDirection.Text = mDirection.ToString();
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == true && ObserveDownSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Up;
                    txtDirection.Text = mDirection.ToString();
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Left;
                    txtDirection.Text = mDirection.ToString();
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
            }

            if (mDirection == Direction.Left)
            {
                if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    txtDirection.Text = mDirection.ToString();
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == true && ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    txtDirection.Text = mDirection.ToString();
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    txtDirection.Text = mDirection.ToString();
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == true && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Down;
                    txtDirection.Text = mDirection.ToString();
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == false && ObserveDownSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Right;
                    txtDirection.Text = mDirection.ToString();
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
            }

            if (mDirection == Direction.Up)
            {
                if (ObserveLeftSide() == false && ObserveRightSide() == false && ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    txtDirection.Text = mDirection.ToString();
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveLeftSide() == true && ObserveRightSide() == false && ObserveUpSide() == true)
                {
                    mDirection = Direction.Up;
                    txtDirection.Text = mDirection.ToString();
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    txtDirection.Text = mDirection.ToString();
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveLeftSide() == true && ObserveUpSide() == false && ObserveRightSide() == false)
                {
                    mDirection = Direction.Left;
                    txtDirection.Text = mDirection.ToString();
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveUpSide() == false && ObserveRightSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Down;
                    txtDirection.Text = mDirection.ToString();
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
            }

            if (mDirection == Direction.Down)
            {
                if (ObserveLeftSide() == false && ObserveRightSide() == false && ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveLeftSide() == false && ObserveRightSide() == true && ObserveDownSide() == true)
                {
                    mDirection = Direction.Down;
                    txtDirection.Text = mDirection.ToString();
                    MoveDownSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveLeftSide() == true)
                {
                    mDirection = Direction.Left;
                    txtDirection.Text = mDirection.ToString();
                    MoveLeftSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveLeftSide() == false && ObserveDownSide() == false && ObserveRightSide() == true)
                {
                    mDirection = Direction.Right;
                    txtDirection.Text = mDirection.ToString();
                    MoveRightSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
                else if (ObserveDownSide() == false && ObserveRightSide() == false && ObserveLeftSide() == false)
                {
                    mDirection = Direction.Up;
                    txtDirection.Text = mDirection.ToString();
                    MoveUpSide(picWalker);
                    Thread.Sleep(mMiliseconds);
                }
            }
        }


    }
}
