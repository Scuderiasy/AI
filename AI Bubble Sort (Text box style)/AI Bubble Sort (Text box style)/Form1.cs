using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Bubble_Sort__Text_box_style_
{
    public partial class Form1 : Form
    {
        double[] data = new double[10];
        double temp_data;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Array.Clear(data, 0, 10);
            i = 0;

            for (int aa = 0; aa < 8; aa++)
            {
                int number = random.Next(1, 10);
                data[aa] = number;
            }

            textBox1.Text = data[0].ToString();
            textBox2.Text = data[1].ToString();
            textBox3.Text = data[2].ToString();
            textBox4.Text = data[3].ToString();
            textBox5.Text = data[4].ToString();
            textBox6.Text = data[5].ToString();
            textBox7.Text = data[6].ToString();
            textBox8.Text = data[7].ToString();
        }

        private void delay_timer_Tick(object sender, EventArgs e)
        {
            if (i < 8)
            {
                for (int j = 0; j < (8 - 1) - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp_data = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp_data;
                    }
                }

                textBox1.Text = data[0].ToString();
                textBox2.Text = data[1].ToString();
                textBox3.Text = data[2].ToString();
                textBox4.Text = data[3].ToString();
                textBox5.Text = data[4].ToString();
                textBox6.Text = data[5].ToString();
                textBox7.Text = data[6].ToString();
                textBox8.Text = data[7].ToString();
            }

            i++;

            if (i >= 8)
            {
                delay_timer.Stop();
            }
        }

        private void sorting_button_Click(object sender, EventArgs e)
        {
            delay_timer.Enabled = true;
            delay_timer.Interval = 1000;
            delay_timer.Start();
        }
    }
}
