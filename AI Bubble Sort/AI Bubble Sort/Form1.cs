using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Bubble_Sort
{
    public partial class Form1 : Form
    {
        double[] data = new double[1000];
        double temp_data;
        int i = 0, flag_start = 0;
        bool pause = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            this.chart1.Series["Data"].Points.Clear();
            Array.Clear(data, 0, 1000);
            i = 0;

            for (int aa = 0; aa < int.Parse(comboBox1.Text) ;aa++)
            {
                int number = random.Next(int.Parse(comboBox1.Text)) + 1;
                this.chart1.Series["Data"].Points.Add(number);
                data[aa] = number;
            }

        }

        private void sorting_button_Click(object sender, EventArgs e)
        {
            /*
            for(int i = 0; i < int.Parse(comboBox1.Text); i++)
            {
                for(int j = 0; j < ((int.Parse(comboBox1.Text) -1) -i); j++)
                {
                    if(data[j] > data [j+1])
                    {
                        temp_data = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp_data;
                    }
                }

                this.chart1.Series["Data"].Points.Clear();

                for(int bb = 0; bb < int.Parse(comboBox1.Text); bb++)
                {
                    this.chart1.Series["Data"].Points.Add(data[bb]);
                }
            }
            */

            if(flag_start == 0)
            {
                begin_label.Text = "Begin: " + DateTime.Now.ToString("h:mm:ss tt");
                end_label.Text = "End: -";
                flag_start = 1;
            }

            delay_timer.Enabled = true;
            delay_timer.Interval = int.Parse(delay_textBox.Text);
            delay_timer.Start();

            if(pause == false)
            {
                pause = true;
                sorting_button.Text = "Pause";
            }
            else
            {
                pause = false;
                sorting_button.Text = "Sort";
            }
        }

        private void delay_timer_Tick(object sender, EventArgs e)
        {
            if (pause)
            {
                if (i < int.Parse(comboBox1.Text))
                {
                    for (int j = 0; j < ((int.Parse(comboBox1.Text) - 1) - i); j++)
                    {
                        if (data[j] > data[j + 1])
                        {
                            temp_data = data[j + 1];
                            data[j + 1] = data[j];
                            data[j] = temp_data;
                        }
                    }

                    this.chart1.Series["Data"].Points.Clear();

                    for (int bb = 0; bb < int.Parse(comboBox1.Text); bb++)
                    {
                        this.chart1.Series["Data"].Points.Add(data[bb]);
                    }
                }

                i++;

                if (i >= int.Parse(comboBox1.Text))
                {
                    end_label.Text = "End: " + DateTime.Now.ToString("h:mm:ss tt");
                    flag_start = 0;

                    pause = false;
                    sorting_button.Text = "Sort";

                    delay_timer.Stop();
                } 
            }
            
        }
    }
}
