namespace WinAppSpeechRecognition
{
    partial class frmSpeechRecognition
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
            this.btnSpeakText = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.grbSpeechRecognition = new System.Windows.Forms.GroupBox();
            this.grbOptions.SuspendLayout();
            this.grbSpeechRecognition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeakText
            // 
            this.btnSpeakText.Location = new System.Drawing.Point(6, 19);
            this.btnSpeakText.Name = "btnSpeakText";
            this.btnSpeakText.Size = new System.Drawing.Size(75, 23);
            this.btnSpeakText.TabIndex = 5;
            this.btnSpeakText.Text = "Speek text";
            this.btnSpeakText.UseVisualStyleBackColor = true;
            this.btnSpeakText.Click += new System.EventHandler(this.btnSpeakText_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(87, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(173, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(4, 10);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(246, 214);
            this.txtData.TabIndex = 4;
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnSpeakText);
            this.grbOptions.Controls.Add(this.btnStart);
            this.grbOptions.Controls.Add(this.btnStop);
            this.grbOptions.Location = new System.Drawing.Point(12, 255);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(256, 55);
            this.grbOptions.TabIndex = 11;
            this.grbOptions.TabStop = false;
            // 
            // grbSpeechRecognition
            // 
            this.grbSpeechRecognition.Controls.Add(this.txtData);
            this.grbSpeechRecognition.Location = new System.Drawing.Point(12, 12);
            this.grbSpeechRecognition.Name = "grbSpeechRecognition";
            this.grbSpeechRecognition.Size = new System.Drawing.Size(256, 237);
            this.grbSpeechRecognition.TabIndex = 10;
            this.grbSpeechRecognition.TabStop = false;
            // 
            // frmSpeechRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 318);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbSpeechRecognition);
            this.Name = "frmSpeechRecognition";
            this.Text = "Speech Recognition";
            this.Load += new System.EventHandler(this.frmSpeechRecognition_Load);
            this.grbOptions.ResumeLayout(false);
            this.grbSpeechRecognition.ResumeLayout(false);
            this.grbSpeechRecognition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeakText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.GroupBox grbSpeechRecognition;
    }
}

