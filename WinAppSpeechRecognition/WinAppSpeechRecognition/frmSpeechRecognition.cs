using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace WinAppSpeechRecognition
{
    public partial class frmSpeechRecognition : Form
    {
        // Objeto mSynthesizer que permite el acceso a la funcionalidad
        // de un motor de síntesis de voz instalado (Cortana).
        private SpeechSynthesizer mSynthesizer = new SpeechSynthesizer();
        // Objeto mPrompt que permite agregar contenido, seleccionar voces, 
        // controlar atributos de voz y controlar la pronunciación de las 
        // palabras dichas.
        private PromptBuilder mPrompt = new PromptBuilder();
        // Objeto mRecognition que proporciona los medios para tener acceso
        // y administrar un motor de reconocimiento de voz en el proceso.
        private SpeechRecognitionEngine mRecognition = new SpeechRecognitionEngine();
        // Objeto mBot que maneja la gramática de reconocimiento de voz.
        private Bot mBot = new Bot();

        public frmSpeechRecognition()
        {
            InitializeComponent();
        }

        private void StartSpeech()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            mBot.InitializeGrammar();

            try
            {
                // Maneja las solicitudes que el reconocedor se detiene para 
                // actualizar su estado.
                mRecognition.RequestRecognizerUpdate();
                // Carga sincrónicamente un obejto de tipo Grammar, utilizando un Bot.
                mRecognition.LoadGrammar(mBot.Elements);
                // Se genera cuando el SpeechRegognitionEngine recibe la entrada que 
                // coincide con cualquiera de sus elementos cargados y habilitados por 
                // el objeto Grammar.
                mRecognition.SpeechRecognized += MRecognition_SpeechRecognized; ;
                // Configura el objeto SpeechRegognitionEngine que va a recibir la entrada
                // desde el dispositivo de audio predeterminado.
                mRecognition.SetInputToDefaultAudioDevice();
                // Realiza una o varias operaciones de reconocimiento de voz asincrónica.
                mRecognition.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void Speak()
        {
            // Borra el contenido del objeto PromptBuilder.
            mPrompt.ClearContent();
            // Especifica el texto que se va a anexar al objeto PromptBuilder.
            mPrompt.AppendText(txtData.Text);
            // El objeto mSynthesizer llama a la fución Speak() que
            // permite hablar de forma sincrónica el contenido de un 
            // objeto PromptBuilder.
            mSynthesizer.Speak(mPrompt);
        }

        private void StopSpeech()
        {
            // Detiene el reconocimiento asincrónico una vez completada la operación de
            // reconocimiento actual.
            mRecognition.RecognizeAsyncStop();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void MRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            mBot.ControlSpeech(e, txtData);
        }

        private void frmSpeechRecognition_Load(object sender, EventArgs e)
        {

        }

        private void btnSpeakText_Click(object sender, EventArgs e)
        {
            Speak();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartSpeech();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSpeech();
        }
    }
}
