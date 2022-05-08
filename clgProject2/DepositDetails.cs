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
    public partial class DepositDetails : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        Grammar gr,grw;
        string v,total;
        bool v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,amountWords = false;

        private void V5_Click(object sender, EventArgs e)
        {
            V5.Enabled = false;
            V4.Enabled = true;
            v5 = true;
            voiceRecognizer();
        }

        private void V6_Click(object sender, EventArgs e)
        {
            V6.Enabled = false;
            V5.Enabled = true;
            v6 = true;
            voiceRecognizer();
        }

        private void V7_Click(object sender, EventArgs e)
        {
            V7.Enabled = false;
            V6.Enabled = true;
            v7 = true;
            voiceRecognizer();
        }

        private void V8_Click(object sender, EventArgs e)
        {
            V8.Enabled = false;
            V7.Enabled = true;
            v8 = true;
            voiceRecognizer();
        }

        private void V9_Click(object sender, EventArgs e)
        {
            V9.Enabled = false;
            V8.Enabled = true;
            v9 = true;
            voiceRecognizer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalText.Text = total.ToString();
        }

        private void DepositDetails_Load(object sender, EventArgs e)
        {

        }

        private void V10_Click(object sender, EventArgs e)
        {
            V10.Enabled = false;
            V9.Enabled = true;
            v10 = true;
            voiceRecognizer();
        }

        private void V4_Click(object sender, EventArgs e)
        {
            V4.Enabled = false;
            V3.Enabled = true;
            v4 = true;
            voiceRecognizer();
        }

        private void V3_Click(object sender, EventArgs e)
        {
            V3.Enabled = false;
            V2.Enabled = true;
            v3 = true;
            voiceRecognizer();
        }

        private void V2_Click(object sender, EventArgs e)
        {
            V2.Enabled = false;
            V1.Enabled = true;
            v2 = true;
            voiceRecognizer();
        }

        public DepositDetails()
        {
            InitializeComponent();
            grw = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += voiceConverterWord;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void voiceConverterWord(object sender, SpeechRecognizedEventArgs sr)
        {
            vamountwords.Text = vamountwords.Text + number(sr.Result.Text.ToString()) + Environment.NewLine;
        }
        private string number (string s)
        {
            if(s == "one"){ return 1.ToString(); }
            else if(s == "two") { return 2.ToString(); }
            else if (s == "three") { return 3.ToString(); }
            else if (s == "four") { return 4.ToString(); }
            else if (s == "five") { return 5.ToString(); }
            else if (s == "six") { return 6.ToString(); }
            else if (s == "seven") { return 7.ToString(); }
            else if (s == "eight") { return 8.ToString(); }
            else if (s == "nine") { return 9.ToString(); }
            else if (s == "ten") { return 10.ToString(); }
            else { return 0.ToString(); }
        }
        private void voiceRecognizer()
        {
            clist.Add(new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" });
            gr = new Grammar(clist);
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += voiceConverter;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void voiceConverter(Object sender, SpeechRecognizedEventArgs s)
        {
            v = number(s.Result.Text.ToString()) + Environment.NewLine;
            if(v1 == true){ v1text.Text = v; v1amount.Text = (int.Parse(v) * 2000).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v1 = false;  }
            if (v2 == true) { v2text.Text = v; v2amount.Text = (int.Parse(v) * 500).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v2 = false; }
            if (v3 == true) { v3text.Text = v; v3amount.Text = (int.Parse(v) * 200).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v3 = false; }
            if (v4 == true) { v4text.Text = v; v4amount.Text = (int.Parse(v) * 100).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v4 = false; }
            if (v5 == true) { v5text.Text = v; v5amount.Text = (int.Parse(v) * 50).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v5 = false; }
            if (v6 == true) { v6text.Text = v; v6amount.Text = (int.Parse(v) * 20).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v6 = false; }
            if (v7 == true) { v7text.Text = v; v7amount.Text = (int.Parse(v) * 10).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v7 = false; }
            if (v8 == true) { v8text.Text = v; v8amount.Text = (int.Parse(v) * 5).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v8 = false; }
            if (v9 == true) { v9text.Text = v; v9amount.Text = (int.Parse(v) * 2).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v9 = false; }
            if (v10 == true) { v10text.Text = v; v10amount.Text = (int.Parse(v) * 1).ToString(); total = (int.Parse(total) + int.Parse(v1amount.Text)).ToString(); v10 = false; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FingerPrintPage fp = new FingerPrintPage();
            fp.Show();
        }

        private void V1_Click(object sender, EventArgs e)
        {
            V1.Enabled = false;
            V2.Enabled = true;
            v1 = true;
            voiceRecognizer();
        }
        private void v1amount_TextChanged(object sender, EventArgs e)
        {
            
        }
       

    }
}
