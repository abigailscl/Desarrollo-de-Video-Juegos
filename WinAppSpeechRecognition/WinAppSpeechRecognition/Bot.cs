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

namespace WinAppSpeechRecognition
{
    class Bot
    {
        // Objeto que representa un conjunto de alternativas de las
        // restricciones de una gramática de reconocimiento de voz.
        private Choices mTable;
        // Objeto que en tiempo de ejecución hace referencia a una 
        // gramática de reconocimiento de voz, que una aplicación puede
        // utilizar para definir las restricciones para el reconocimiento
        // de voz.
        private Grammar mElements;

        public Choices Table { get => mTable; set => mTable = value; }
        public Grammar Elements { get => mElements; set => mElements = value; }

        public void InitializeGrammar()
        {
            // Inicializa una nueva instancia de la clase Choice que contiene
            // un conjunto vacío de alternativas.
            mTable = new Choices();
            // Se agrega una matriz que contiene uno o más objetos string al
            // conjunto de alternativas.
            mTable.Add(new string[] { "hola",
                                      "prueba",
                                      "bienvenidos",
                                      "lenguaje",
                                      "consonantes",
                                      "salir",
                                      "nota",
                                      "calc" });
            // Inicializa una nueva instancia de la clase Grammar desde un
            // objeto GrammarBuilder.
            mElements = new Grammar(new GrammarBuilder(mTable));
        }

        public Bot()
        {

        }

        public void ControlSpeech(SpeechRecognizedEventArgs e, TextBox txtData)
        {
            //MessageBox.Show("Speech recognition: " + e.Result.Text.ToString());
            if (e.Result.Text == "salir")
            {
                Application.Exit();
            }
            else if (e.Result.Text == "nota")
            {
                Process.Start("C:\\Windows\\notepad.exe");
            }
            else if (e.Result.Text == "calc")
            {
                Process.Start("C:\\Windows\\System32\\calc.exe");
            }
            else
            {
                txtData.Text = txtData.Text + " " + e.Result.Text.ToString();
            }
        }

    }
}
