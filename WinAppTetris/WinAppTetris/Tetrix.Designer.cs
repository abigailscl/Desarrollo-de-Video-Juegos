
namespace WinAppTetris
{
    partial class Tetrix
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components;
        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.LblNextBlock = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PicBackground = new System.Windows.Forms.PictureBox();
            this.PicNextBlock = new System.Windows.Forms.PictureBox();
            this.lblScoreValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNextBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(282, 68);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: ";
            // 
            // LblNextBlock
            // 
            this.LblNextBlock.AutoSize = true;
            this.LblNextBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNextBlock.Location = new System.Drawing.Point(282, 164);
            this.LblNextBlock.Name = "LblNextBlock";
            this.LblNextBlock.Size = new System.Drawing.Size(122, 24);
            this.LblNextBlock.TabIndex = 4;
            this.LblNextBlock.Text = "Next Block: ";
            this.LblNextBlock.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmdStart
            // 
            this.CmdStart.BackColor = System.Drawing.Color.LimeGreen;
            this.CmdStart.Location = new System.Drawing.Point(304, 390);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(112, 41);
            this.CmdStart.TabIndex = 6;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.BackgroundImage = global::WinAppTetris.Properties.Resources.close_icon1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Location = new System.Drawing.Point(401, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // PicBackground
            // 
            this.PicBackground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBackground.Location = new System.Drawing.Point(12, 44);
            this.PicBackground.Name = "PicBackground";
            this.PicBackground.Size = new System.Drawing.Size(234, 489);
            this.PicBackground.TabIndex = 7;
            this.PicBackground.TabStop = false;
            // 
            // PicNextBlock
            // 
            this.PicNextBlock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PicNextBlock.Location = new System.Drawing.Point(286, 210);
            this.PicNextBlock.Name = "PicNextBlock";
            this.PicNextBlock.Size = new System.Drawing.Size(144, 134);
            this.PicNextBlock.TabIndex = 5;
            this.PicNextBlock.TabStop = false;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(325, 110);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(44, 31);
            this.lblScoreValue.TabIndex = 9;
            this.lblScoreValue.Text = "0";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tetrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(462, 552);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PicBackground);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.PicNextBlock);
            this.Controls.Add(this.LblNextBlock);
            this.Controls.Add(this.lblScore);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tetrix";
            this.Text = "Tetrix";
            this.Load += new System.EventHandler(this.Tetrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNextBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label LblNextBlock;
        private System.Windows.Forms.PictureBox PicNextBlock;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.PictureBox PicBackground;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblScoreValue;
    }
}

