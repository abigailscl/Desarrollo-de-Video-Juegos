using System;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Nettrix {
	public class Square {
		private Point squareLocation;

		public Point Location {
			get { return squareLocation; }
			set { squareLocation = value;	}
		}

		private Size squareSize;

		public Size Size {
			get { return squareSize; }
			set { squareSize = value;	}
		}

		private Color foregroundColor;

		public Color ForeColor {
			get { return foregroundColor;	}
			set { foregroundColor = value; }
		}

		private Color backgroundColor;

		public Color BackColor {
			get { return backgroundColor; }
			set { backgroundColor = value; }
		}


		// Draws a rectangle with gradient path using the properties above
		public void Show(System.IntPtr winHandle) {
			Graphics GameGraphics;
			GraphicsPath graphPath;
			SolidBrush brushSquare;
			Color[] surroundColor;
			Rectangle rectSquare;

			GameGraphics = Graphics.FromHwnd(winHandle);

			// Create a path consisting of one rectangle
			graphPath = new GraphicsPath();
			rectSquare = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
			graphPath.AddRectangle(rectSquare);

			// Creates the gradient brush which will draw the square
			// Note: Theres one center color and an array of border colors 
			brushSquare = new SolidBrush(BackColor);

			// Finally draws the square
			GameGraphics.FillPath(brushSquare, graphPath);
		}

		public void Hide(System.IntPtr winHandle) {
			Graphics GameGraphics;
			Rectangle rectSquare;

			// Gets the Graphics object of the background picture
			GameGraphics = Graphics.FromHwnd(winHandle);

			// Since we are working in a solid background, we can just draw a solid rectangle in order to "hide" the current square
			rectSquare = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
			GameGraphics.FillRectangle(new SolidBrush(GameField.BackColor), rectSquare);
		}

		public Square(Size initialSize, Color initialBackColor, Color initialForeColor) {
			Size = initialSize;
			BackColor = initialBackColor;
			ForeColor = initialForeColor;
		}
	}
}
