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
using System.IO.Ports;

namespace AI_Talk_with_bot___DTH_sensor_arduino
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer talk = new SpeechSynthesizer();
        Choices list = new Choices();
        string aa;

        public Form1()
        {
            InitializeComponent();

            String[] strPortNames = SerialPort.GetPortNames();
            foreach (string n in strPortNames)
            {
                comboBox1.Items.Add(n);
            }
            try
            {
                comboBox1.SelectedIndex = 0;
                comboBox1.Enabled = true;
                connect_button.Enabled = true;
            }
            catch
            {
                comboBox1.Text = "Unavialble";
            }

            SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();

            list.Add(new String[] { "temperature", "humidity"});

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

            if (result == "temperature")
            {
                if (temp_textBox.Text.Equals("-"))
                {
                    talk.Speak("cannot recieve temperature from sensor");
                }
                else
                {
                    say("temperature is " + temp_textBox.Text + "degree celcius");
                }
            }

            if (result == "humidity")
            {
                if (temp_textBox.Text.Equals("-"))
                {
                    talk.Speak("cannot recieve humidity from sensor");
                }
                else
                {
                    say("humidity is " + humid_textBox.Text + "percent");
                }   
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem + "";
            serialPort1.Open();

            read_timer.Start();
        }

        private void read_data_from_arduino(object sender, SerialDataReceivedEventArgs e)  // read data from arduino
        {
            try
            {
                aa = serialPort1.ReadTo("\r\n");
            }
            catch
            { }
        }

        private void read_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] bb = aa.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                temp_textBox.Text = bb[0];
                humid_textBox.Text = bb[1];
            }
            catch { }
        }
    }
}
