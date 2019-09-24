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
using System.Diagnostics;


namespace AI_Talk_with_Bot
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer talk = new SpeechSynthesizer();
        Choices list = new Choices();
        Boolean enable = false;

        public Form1()
        {
            InitializeComponent();

            SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();

            list.Add(new String[] { "hello Sarah", "how are you", "what time is it", "traffic now", "i want to relax", "i'm hungry", "thank you" });

            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                recognize.RequestRecognizerUpdate();
                recognize.LoadGrammar(gr);
                recognize.SpeechRecognized += recognize_SpeechRecognized;
                recognize.SetInputToDefaultAudioDevice();
                recognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {

            }

            talk.SelectVoiceByHints(VoiceGender.Female);
        }

        private void say(String Say)
        {
            talk.Speak(Say);
        }

        private void recognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String result = e.Result.Text;

            if (enable)
            {
                if (result == "how are you?")
                {
                    textBox1.Text = result;
                    textBox2.Text = "i'm fine";

                    say("i'm fine");
                }

                else if (result == "what time is it")
                {
                    textBox1.Text = result;
                    textBox2.Text = DateTime.Now.ToString("h:mm");

                    say(DateTime.Now.ToString("h:mm"));
                }

                else if (result == "traffic now")
                {
                    textBox1.Text = result;
                    textBox2.Text = "wait a few second";

                    Process.Start("http://google.com/search?q=" + result);
                    say("wait a few second");
                }

                else if (result == "i'm hungry")
                {
                    textBox1.Text = result;
                    textBox2.Text = "this is the resturant near your location";

                    Process.Start("http://google.com/search?q=" + "nearest restaurant");
                    say("this is the resturant near your location");
                }

                else if ((result == "i want to relax"))
                {
                    textBox1.Text = result;
                    textBox2.Text = "i will play a Redemption Song";

                    Process.Start("https://youtu.be/55s3T7VRQSc?t=18");
                    say("i will play a Redemption Song");
                }

                else if ((result == "thank you"))
                {
                    textBox1.Text = result;
                    textBox2.Text = "call me if you want some helping";

                    talk.Speak("call me if you want some helping");
                    enable = false;
                    label1.Text = "State: Sleep";
                }

                else
                {
                    textBox1.Text = "?";
                    textBox2.Text = "i don't understand";

                    say("i don't understand");
                }
            }

            if (result == "hello Sarah")
            {
                textBox1.Text = result;
                textBox2.Text = "What I can do for you?";

                label1.Text = "State: Ready";
                talk.Speak("What I can do for you?");
                enable = true;
            }

        }

    }
}
