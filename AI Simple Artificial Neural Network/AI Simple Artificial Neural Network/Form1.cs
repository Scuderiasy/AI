using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Simple_Artificial_Neural_Network
{
    public partial class Form1 : Form
    {
        double[,] input = new double[4, 2] { {1, 1},
                                             {1, 1},
                                             {0, 1},
                                             {0, 0} };

        double[] target_output = new double[4] { 1,
                                                 1,
                                                 1,
                                                 0 };

        double[] weight_input = new double[2];
        double[] weight_output_node = new double[1];
        double[] bias_hidden_node = new double[1];
        double[] bias_output_node = new double[1];
        double[] process_input = new double[2];
        double[] process_node_layer1 = new double[1];
        double[] sum_hidden_node = new double [1];
        double[] output_hidden_node = new double[1];
        double[] process_output_hidden_node = new double[1];
        double[] output_result = new double[1];

        double total_error, learning_rate, back_prop_term1, back_prop_term2, back_prop_term3, sum_error_output, iteration = 0;
        int input_order = 0, chart_plot = 1;
        bool pause = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weight_input[0] = double.Parse(weight_input1_textBox.Text);
            weight_input[1] = double.Parse(weight_input2_textBox.Text);
            weight_output_node[0] = double.Parse(weight_output1_textbox.Text);
            bias_hidden_node[0] = double.Parse(bias_node1_textBox.Text);
            bias_output_node[0] = double.Parse(bias_output_node_textBox.Text);
            learning_rate = double.Parse(learning_rate_textBox.Text);
        }

        private void train_button_Click(object sender, EventArgs e)
        {
            iteration = 0;
            input_order = 0;

            weight_input[0] = double.Parse(weight_input1_textBox.Text);
            weight_input[1] = double.Parse(weight_input2_textBox.Text);
            weight_output_node[0] = double.Parse(weight_output1_textbox.Text);
            bias_hidden_node[0] = double.Parse(bias_node1_textBox.Text);
            bias_output_node[0] = double.Parse(bias_output_node_textBox.Text);
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
                sum_hidden_node[0] = process_input[0] + process_input[1] + bias_hidden_node[0];

                output_hidden_node[0] = 1 / (1 + Math.Exp((-1) * sum_hidden_node[0]));


                process_output_hidden_node[0] = ((output_hidden_node[0] * weight_output_node[0]) + bias_output_node[0]);

                output_result[0] = 1 / (1 + Math.Exp((-1) * process_output_hidden_node[0]));

                total_error = (Math.Pow(target_output[input_order] - output_result[0], 2)) / 2;

                if (input_order == 0) { error_1_textBox.Text = (target_output[input_order] - output_result[0]).ToString("0.###"); }
                else if (input_order == 1) { error_2_textBox.Text = (target_output[input_order] - output_result[0]).ToString("0.###"); }
                else if (input_order == 2) { error_3_textBox.Text = (target_output[input_order] - output_result[0]).ToString("0.###"); }
                else if (input_order == 3) { error_4_textBox.Text = (target_output[input_order] - output_result[0]).ToString("0.###"); }

                // Backward propogation

                // Weight 3 and Bias 2 adjustment
                back_prop_term1 = output_result[0] - target_output[input_order];
                back_prop_term2 = output_result[0] * (1 - output_result[0]);
                back_prop_term3 = output_hidden_node[0];

                weight_output_node[0] = weight_output_node[0] - (back_prop_term1 * back_prop_term2 * back_prop_term3 * learning_rate);

                bias_output_node[0] = bias_output_node[0] - ((back_prop_term1 * back_prop_term2) * learning_rate);

                // Weight 1 adjustment

                back_prop_term1 = (output_result[0] - target_output[input_order]) * (output_result[0] * (1 - output_result[0])) * double.Parse(weight_output1_textbox.Text);
                back_prop_term2 = (output_hidden_node[0] * (1 - output_hidden_node[0]));
                back_prop_term3 = input[input_order, 0];

                weight_input[0] = weight_input[0] - ((back_prop_term1 * back_prop_term2 * back_prop_term3) * learning_rate);

                // Weight 2 and Bias 1 adjustment
                back_prop_term1 = (output_result[0] - target_output[input_order]) * (output_result[0] * (1 - output_result[0])) * double.Parse(weight_output1_textbox.Text);
                back_prop_term2 = (output_hidden_node[0] * (1 - output_hidden_node[0]));
                back_prop_term3 = input[input_order, 1];

                weight_input[1] = weight_input[1] - ((back_prop_term1 * back_prop_term2 * back_prop_term3) * learning_rate);

                bias_hidden_node[0] = bias_hidden_node[0] - ((back_prop_term1 * back_prop_term2) * learning_rate);

                // display data
                weight_output1_textbox.Text = weight_output_node[0].ToString("0.####");
                weight_input1_textBox.Text = weight_input[0].ToString("0.####");
                weight_input2_textBox.Text = weight_input[1].ToString("0.####");

                bias_node1_textBox.Text = bias_hidden_node[0].ToString("0.####");
                bias_output_node_textBox.Text = bias_output_node[0].ToString("0.####");

                sum_error_output += (Math.Abs(target_output[input_order] - output_result[0]));

                if (input_order == 0) { result_1_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 1) { result_2_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 2) { result_3_textBox.Text = output_result[0].ToString("0.###"); }
                else if (input_order == 3) { result_4_textBox.Text = output_result[0].ToString("0.###"); }

                input_order++;

                if (input_order > 3)
                {
                    input_order = 0; sum_error_output = sum_error_output / 4;
                    this.chart1.Series["Mean Squre Error"].Points.AddXY(chart_plot, sum_error_output);
                    sum_error_output = 0; chart_plot++;
                }

                iteration++;
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
