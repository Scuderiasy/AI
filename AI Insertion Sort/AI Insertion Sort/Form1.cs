using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Insertion_Sort
{
    public partial class Form1 : Form
    {
        int[] data = new int[1001];
        int first_data, Flag_start = 0;
        int b = 1;
        bool pause = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.chart1.Series["Data1"].Points.Clear();

            for (int a = 1; a <= int.Parse(comboBox1.Text); a++)
            {
                data[a-1] = random.Next(1, int.Parse(comboBox1.Text));
                this.chart1.Series["Data1"].Points.Add(data[a - 1]);
            }
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            b = 1;
            
            delay_timer.Start();
            delay_timer.Interval = int.Parse(textBox1.Text);

            label4.Text = "Begin:" + DateTime.Now.ToString("h:mm:ss tt");
            label5.Text = "End: -";

            Flag_start = 1;
        }

        private void delay_timer_Tick(object sender, EventArgs e)
        {
            delay_timer.Stop();

            if (pause)
            {
                first_data = data[b];

                for (int c = b - 1; c >= 0; c--)
                {
                    if (first_data < data[c])
                    {
                        data[c + 1] = data[c];

                        data[c] = first_data;

                        first_data = data[c];

                        this.chart1.Series["Data1"].Points.Clear();

                        for (int a = 0; a <= int.Parse(comboBox1.Text) - 1; a++)
                        {
                            this.chart1.Series["Data1"].Points.Add(data[a]);
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                b++;
            }

            if (b < int.Parse(comboBox1.Text))
            {
                delay_timer.Start();
            }
            else
            {
                delay_timer.Stop();
                if (Flag_start==1)
                {
                    label5.Text = "End:" + DateTime.Now.ToString("h:mm:ss tt");
                    Flag_start = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pause == true) { pause = false; pause_button.Text = "countinue"; } else { pause = true; pause_button.Text = "pause"; }
        }
    }
}
