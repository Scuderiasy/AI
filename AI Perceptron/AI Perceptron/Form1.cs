using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Perceptron
{
    public partial class Form1 : Form
    {
        double[,] input = new double[4, 2] { {0.7, 0.2},
                                             {0.4, 0.6},
                                             {0.2, 0.5},
                                             {0.1, 0.3} };

        double[] target_output = new double[4] { 1,
                                                 1,
                                                 -1,
                                                 -1 };

        double[] weight_input = new double[2];
        double[] bias_node = new double[1];
        double[] process_input = new double[2];
        double[] sum_perceptron = new double[1];
        double[] delta_weigth_input = new double[2];

        double[] output_result = new double[1];

        double error, learning_rate, sum_error_output, iteration = 0;
        int input_order = 0, chart_plot = 1;
        bool pause = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void train_button_Click(object sender, EventArgs e)
        {
            iteration = 0;
            input_order = 0;

            weight_input[0] = double.Parse(weight_input1_textBox.Text);
            weight_input[1] = double.Parse(weight_input2_textBox.Text);
            bias_node[0] = double.Parse(bias_node1_textBox.Text);
            learning_rate = double.Parse(learning_rate_textBox.Text);

            input[0, 0] = double.Parse(input_1_1_textBox.Text);
            input[0, 1] = double.Parse(input_2_1_textBox.Text);
            input[1, 0] = double.Parse(input_1_2_textBox.Text);
            input[1, 1] = double.Parse(input_2_2_textBox.Text);
            input[2, 0] = double.Parse(input_1_3_textBox.Text);
            input[2, 1] = double.Parse(input_2_3_textBox.Text);
            input[3, 0] = double.Parse(input_1_4_textBox.Text);
            input[3, 1] = double.Parse(input_2_4_textBox.Text);

            target_output[0] = double.Parse(output_1_textBox.Text);
            target_output[1] = double.Parse(output_2_textBox.Text);
            target_output[2] = double.Parse(output_3_textBox.Text);
            target_output[3] = double.Parse(output_4_textBox.Text);

            delay_timer.Enabled = true;
            delay_timer.Start();


            if (pause == true) { pause = false; train_button.Text = "Start"; } else { pause = true; train_button.Text = "Pause"; }
        }

        private void delay_timer_Tick(object sender, EventArgs e)
        {
            delay_timer.Stop();

            if (pause)
            {
                // Forward propogation

                process_input[0] = input[input_order, 0] * weight_input[0];
                process_input[1] = input[input_order, 1] * weight_input[1];
                sum_perceptron[0] = process_input[0] + process_input[1] + bias_node[0];

                if(sum_perceptron[0] > 0) { output_result[0] = 1; } else { output_result[0] = -1; }

                error = (target_output[input_order] - output_result[0]);

                if (input_order == 0) { error_1_textBox.Text = (error).ToString("0.###"); }
                else if (input_order == 1) { error_2_textBox.Text = (error).ToString("0.###"); }
                else if (input_order == 2) { error_3_textBox.Text = (error).ToString("0.###"); }
                else if (input_order == 3) { error_4_textBox.Text = (error).ToString("0.###"); }

                if (input_order == 0) { result_1_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 1) { result_2_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 2) { result_3_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 3) { result_4_textBox.Text = output_result[0].ToString("0.###"); }

                // Backward propogation

                delta_weigth_input[0] = input[input_order, 0] * error;
                delta_weigth_input[1] = input[input_order, 1] * error;

                weight_input[0] = weight_input[0] + (learning_rate * delta_weigth_input[0]);
                weight_input[1] = weight_input[1] + (learning_rate * delta_weigth_input[1]);

                // display data
                weight_input1_textBox.Text = weight_input[0].ToString("0.####");
                weight_input2_textBox.Text = weight_input[1].ToString("0.####");

                //bias_node1_textBox.Text = bias_hidden_node[0].ToString("0.####");

                sum_error_output += (Math.Abs(error));

                input_order++;

                if (input_order > 3)
                {
                    input_order = 0; sum_error_output = sum_error_output / 4;
                    this.chart1.Series["Error"].Points.AddXY(chart_plot, sum_error_output);
                    sum_error_output = 0; chart_plot++;

                    iteration++;
                }

            }

            if (iteration <= int.Parse(comboBox1.Text))
            {
                progressBar1.Value = Convert.ToInt16((iteration / double.Parse(comboBox1.Text)) * 100);
                delay_timer.Start();
            }
            else
            {
                pause = false; train_button.Text = "Start";
            }
        }
    }
}
