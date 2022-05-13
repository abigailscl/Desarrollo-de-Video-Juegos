namespace WinAppMazeGame
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnAutomaticBeginnerMazeLeftRule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAutomaticBeginnerMazeRightRule = new System.Windows.Forms.Button();
            this.btnManualBeginnerMaze = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnAutomaticBeginnerMazeLeftRule);
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnAutomaticBeginnerMazeRightRule);
            this.grbMenu.Controls.Add(this.btnManualBeginnerMaze);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(323, 249);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnAutomaticBeginnerMazeLeftRule
            // 
            this.btnAutomaticBeginnerMazeLeftRule.Location = new System.Drawing.Point(21, 113);
            this.btnAutomaticBeginnerMazeLeftRule.Name = "btnAutomaticBeginnerMazeLeftRule";
            this.btnAutomaticBeginnerMazeLeftRule.Size = new System.Drawing.Size(275, 41);
            this.btnAutomaticBeginnerMazeLeftRule.TabIndex = 3;
            this.btnAutomaticBeginnerMazeLeftRule.Text = "Laberinto Nivel Principante Automático Regla Mano Izquierda";
            this.btnAutomaticBeginnerMazeLeftRule.UseVisualStyleBackColor = true;
            this.btnAutomaticBeginnerMazeLeftRule.Click += new System.EventHandler(this.btnAutomaticBeginnerMazeLeftRule_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(275, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAutomaticBeginnerMazeRightRule
            // 
            this.btnAutomaticBeginnerMazeRightRule.Location = new System.Drawing.Point(21, 66);
            this.btnAutomaticBeginnerMazeRightRule.Name = "btnAutomaticBeginnerMazeRightRule";
            this.btnAutomaticBeginnerMazeRightRule.Size = new System.Drawing.Size(275, 41);
            this.btnAutomaticBeginnerMazeRightRule.TabIndex = 1;
            this.btnAutomaticBeginnerMazeRightRule.Text = "Laberinto Nivel Principante Automático Regla Mano Derecha";
            this.btnAutomaticBeginnerMazeRightRule.UseVisualStyleBackColor = true;
            this.btnAutomaticBeginnerMazeRightRule.Click += new System.EventHandler(this.btnAutomaticBeginnerMazeRightRule_Click);
            // 
            // btnManualBeginnerMaze
            // 
            this.btnManualBeginnerMaze.Location = new System.Drawing.Point(21, 19);
            this.btnManualBeginnerMaze.Name = "btnManualBeginnerMaze";
            this.btnManualBeginnerMaze.Size = new System.Drawing.Size(275, 41);
            this.btnManualBeginnerMaze.TabIndex = 0;
            this.btnManualBeginnerMaze.Text = "Laberinto Nivel Principante Manual";
            this.btnManualBeginnerMaze.UseVisualStyleBackColor = true;
            this.btnManualBeginnerMaze.Click += new System.EventHandler(this.btnManualBeginnerMaze_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 274);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAutomaticBeginnerMazeRightRule;
        private System.Windows.Forms.Button btnManualBeginnerMaze;
        private System.Windows.Forms.Button btnAutomaticBeginnerMazeLeftRule;
    }
}

