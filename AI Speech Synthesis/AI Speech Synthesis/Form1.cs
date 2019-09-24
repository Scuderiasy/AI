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

namespace AI_Speech_Synthesis
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer talk = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            welcome_timer.Enabled = true;
            welcome_timer.Start();
        }

        private void Speak_pictureBox_Click(object sender, EventArgs e)
        {
            if (male_radioButton.Checked == true) { talk.SelectVoiceByHints(VoiceGender.Male); }
            if (female_radioButton.Checked == true) { talk.SelectVoiceByHints(VoiceGender.Female); }
            talk.Speak(input_textBox.Text);
        }

        private void welcome_timer_Tick(object sender, EventArgs e)
        {
            welcome_timer.Stop();
            talk.SelectVoiceByHints(VoiceGender.Female);

            if(Convert.ToInt16(DateTime.Now.ToString("HH")) <= 11) { talk.Speak("Good morning"); }
            else if (Convert.ToInt16(DateTime.Now.ToString("HH")) <= 18) { talk.Speak("Good afternoon"); }
            else  { talk.Speak("Good evening"); }
        }
    }
}
