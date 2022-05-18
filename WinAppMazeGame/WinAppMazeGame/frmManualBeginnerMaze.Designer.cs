namespace WinAppMazeGame
{
    partial class frmManualBeginnerMaze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtData = new System.Windows.Forms.TextBox();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picMaze = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(12, 123);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(75, 20);
            this.txtData.TabIndex = 8;
            // 
            // picWalker
            // 
            this.picWalker.Location = new System.Drawing.Point(124, 38);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(25, 25);
            this.picWalker.TabIndex = 7;
            this.picWalker.TabStop = false;
            // 
            // picCheese
            // 
            this.picCheese.Location = new System.Drawing.Point(583, 413);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(75, 75);
            this.picCheese.TabIndex = 6;
            this.picCheese.TabStop = false;
            // 
            // picMaze
            // 
            this.picMaze.Location = new System.Drawing.Point(98, 12);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(500, 500);
            this.picMaze.TabIndex = 5;
            this.picMaze.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Location = new System.Drawing.Point(12, 12);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(75, 105);
            this.picMouse.TabIndex = 4;
            this.picMouse.TabStop = false;
            // 
            // frmManualBeginnerMaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 500);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.picMouse);
            this.Name = "frmManualBeginnerMaze";
            this.Text = "frmManualBeginnerMaze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManualBeginnerMaze_FormClosed);
            this.Load += new System.EventHandler(this.frmManualBeginnerMaze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManualBeginnerMaze_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picMaze;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.TextBox txtData;
    }
}