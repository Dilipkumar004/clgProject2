using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace clgProject2
{
    public partial class VoiceTest : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        public VoiceTest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            //clist.Add(new string[] { "One", "two" });
            //Grammar gr = new Grammar(new GrammarBuilder(clist));
            Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void sre_SpeechRecognized(Object sender,SpeechRecognizedEventArgs e)
        {
            textBox1.Text = textBox1.Text + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void VoiceTest_Load(object sender, EventArgs e)
        {

        }
    }
}
