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
    public partial class WithdrawDetails : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        Grammar gr, grw;
        public WithdrawDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += voiceConverterWithdraw;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += voiceConverterWithdraw1;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void voiceConverterWithdraw(object sender, SpeechRecognizedEventArgs s)
        {
            Wamount.Text = Wamount.Text + s.Result.Text.ToString() + Environment.NewLine;
        }
        private void voiceConverterWithdraw1(object sender, SpeechRecognizedEventArgs s)
        {
            Wamount1.Text = Wamount1.Text + s.Result.Text.ToString() + Environment.NewLine;
        }
    }
}
