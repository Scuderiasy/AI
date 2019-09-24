using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_K_Means_clustering
{
    public partial class Form1 : Form
    {
        double[,] ex_1 = new double[,] { { 2.88, 3.95 },
                                        { 3.37, 1.57 },
                                        { 3.19, 1.46 },
                                        { 0.39, 0.65 },
                                        { 1.62, 3.96 },
                                        { 1.97, 3.13 },
                                        { 1.03, 2.82 },
                                        { 0.27, 3.26 },
                                        { 0.12, 2.19 },
                                        { 7.69, 7.52 },
                                        { 5.35, 8.32 },
                                        { 6.18, 6.89 },
                                        { 7.11, 8.33 },
                                        { 7.78, 8.52 },
                                        { 6.55, 5.68 },
                                        { 6.26, 6.26 },
                                        { 8.75, 5.57 },
                                        { 6.26, 8.77 } };

        double[,] k = new double[5, 2];
        double[,] k_distance = new double[5, 20];
        double distance_temp;
        double[,] clusters = new double[5, 20];
        int cluster_temp, running_c1, running_c2, running_c3, running_c4, running_c5, loop_step, step;
        double mean_k1_x, mean_k1_y, mean_k2_x, mean_k2_y, mean_k3_x, mean_k3_y, mean_k4_x, mean_k4_y, mean_k5_x, mean_k5_y;
        double variance_k1_x, variance_k1_y, variance_k2_x, variance_k2_y, variance_k3_x, variance_k3_y, variance_k4_x, variance_k4_y, variance_k5_x, variance_k5_y;
        double variance_error = 2;
        bool loop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Random_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int a = 1; a <= int.Parse(comboBox1.Text); a++)
            {
                k[a-1, 0] = Math.Round(random.Next(1, 9) + random.NextDouble(), 3);
            }

            for (int a = 1; a <= int.Parse(comboBox1.Text); a++)
            {
                
                k[a - 1, 1] = Math.Round(random.Next(1, 9) + random.NextDouble(), 3);

                if (a == 1) { this.chart1.Series["k-position1"].Points.AddXY(k[a - 1, 0], k[a - 1, 1]); }
                if (a == 2) { this.chart1.Series["k-position2"].Points.AddXY(k[a - 1, 0], k[a - 1, 1]); }
                if (a == 3) { this.chart1.Series["k-position3"].Points.AddXY(k[a - 1, 0], k[a - 1, 1]); }
                if (a == 4) { this.chart1.Series["k-position4"].Points.AddXY(k[a - 1, 0], k[a - 1, 1]); }
                if (a == 5) { this.chart1.Series["k-position5"].Points.AddXY(k[a - 1, 0], k[a - 1, 1]); }

            }


            for (int data_point = 0; data_point <= ex_1.GetUpperBound(0); data_point++)
            {

                this.chart1.Series["raw data"].Points.AddXY(ex_1[data_point, 0], ex_1[data_point, 1]);

            }

            if (loop) { loop_step++; delay_timer.Start(); }
            
        }
        
        private void Distance_Calculation_Click(object sender, EventArgs e)
        {
            for (int data_point = 0; data_point <= ex_1.GetUpperBound(0); data_point++)
            {
                for (int k_point = 0; k_point <= int.Parse(comboBox1.Text) - 1; k_point++)
                {
                    k_distance[k_point, data_point] = Math.Round(Math.Sqrt(Math.Pow(ex_1[data_point, 0] - k[k_point, 0], 2) + Math.Pow(ex_1[data_point, 1] - k[k_point, 1], 2)), 3);
                }
            }

            if (loop) { loop_step++; delay_timer.Start(); }
        }

        private void Clustering_button_Click(object sender, EventArgs e)
        {
            this.chart1.Series["raw data"].Points.Clear();

            running_c1 = 0;
            running_c2 = 0;
            running_c3 = 0;
            running_c4 = 0;
            running_c5 = 0;

            mean_k1_x = 0;
            mean_k1_y = 0;
            mean_k2_x = 0;
            mean_k2_y = 0;
            mean_k3_x = 0;
            mean_k3_y = 0;
            mean_k4_x = 0;
            mean_k4_y = 0;
            mean_k5_x = 0;
            mean_k5_y = 0;

            for (int distance = 0; distance <= ex_1.GetUpperBound(0); distance++)
            {
                distance_temp = 0;
                cluster_temp = 0;

                for (int cluster = 0; cluster <= int.Parse(comboBox1.Text) - 1; cluster++)
                {
                    if(cluster == 0)
                    {
                        distance_temp = k_distance[cluster, distance];
                        cluster_temp = cluster;
                    }
                    else if (k_distance[cluster, distance] < distance_temp)
                    {
                        distance_temp = k_distance[cluster, distance];
                        cluster_temp = cluster;
                    }
                }

                if (cluster_temp == 0)
                {
                    clusters[cluster_temp, running_c1] = distance;
                    running_c1++;
                    mean_k1_x += ex_1[distance, 0];
                    mean_k1_y += ex_1[distance, 1];

                    this.chart1.Series["cluster1"].Points.AddXY(ex_1[distance, 0], ex_1[distance, 1]); 
                }

                if (cluster_temp == 1)
                {
                    clusters[cluster_temp, running_c2] = distance;
                    running_c2++;
                    mean_k2_x += ex_1[distance, 0];
                    mean_k2_y += ex_1[distance, 1];

                    this.chart1.Series["cluster2"].Points.AddXY(ex_1[distance, 0], ex_1[distance, 1]); 
                }

                if (cluster_temp == 2)
                {
                    clusters[cluster_temp, running_c3] = distance;
                    running_c3++;
                    mean_k3_x += ex_1[distance, 0];
                    mean_k3_y += ex_1[distance, 1];

                    this.chart1.Series["cluster3"].Points.AddXY(ex_1[distance, 0], ex_1[distance, 1]);  
                }

                if (cluster_temp == 3)
                {
                    clusters[cluster_temp, running_c4] = distance;
                    running_c4++;
                    mean_k4_x += ex_1[distance, 0];
                    mean_k4_y += ex_1[distance, 1];

                    this.chart1.Series["cluster4"].Points.AddXY(ex_1[distance, 0], ex_1[distance, 1]);  
                }

                if (cluster_temp == 4)
                {
                    clusters[cluster_temp, running_c5] = distance;
                    running_c5++;
                    mean_k5_x += ex_1[distance, 0];
                    mean_k5_y += ex_1[distance, 1];

                    this.chart1.Series["cluster5"].Points.AddXY(ex_1[distance, 0], ex_1[distance, 1]); 
                }
            }

            mean_k1_x = mean_k1_x / (running_c1);
            mean_k1_y = mean_k1_y / (running_c1);
            mean_k2_x = mean_k2_x / (running_c2);
            mean_k2_y = mean_k2_y / (running_c2);
            mean_k3_x = mean_k3_x / (running_c3);
            mean_k3_y = mean_k3_y / (running_c3);
            mean_k4_x = mean_k4_x / (running_c4);
            mean_k4_y = mean_k4_y / (running_c4);
            mean_k5_x = mean_k5_x / (running_c5);
            mean_k5_y = mean_k5_y / (running_c5);
            

            this.chart1.Series["k-position1"].Points.Clear();
            this.chart1.Series["k-position1"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            this.chart1.Series["k-position1"].Points.AddXY(mean_k1_x, mean_k1_y);
            this.chart1.Series["k-position2"].Points.Clear();
            this.chart1.Series["k-position2"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            this.chart1.Series["k-position2"].Points.AddXY(mean_k2_x, mean_k2_y);
            this.chart1.Series["k-position3"].Points.Clear();
            this.chart1.Series["k-position3"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            this.chart1.Series["k-position3"].Points.AddXY(mean_k3_x, mean_k3_y);
            this.chart1.Series["k-position4"].Points.Clear();
            this.chart1.Series["k-position4"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            this.chart1.Series["k-position4"].Points.AddXY(mean_k4_x, mean_k4_y);
            this.chart1.Series["k-position5"].Points.Clear();
            this.chart1.Series["k-position5"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            this.chart1.Series["k-position5"].Points.AddXY(mean_k5_x, mean_k5_y);

            if (loop) { loop_step++; delay_timer.Start(); }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Array.Clear(k, 0, k.Length);
            Array.Clear(k_distance, 0, k.Length);
            Array.Clear(clusters, 0, k.Length);
            
            this.chart1.Series["k-position1"].Points.Clear();
            this.chart1.Series["k-position2"].Points.Clear();
            this.chart1.Series["k-position3"].Points.Clear();
            this.chart1.Series["k-position4"].Points.Clear();
            this.chart1.Series["k-position5"].Points.Clear();
            this.chart1.Series["cluster1"].Points.Clear();
            this.chart1.Series["cluster2"].Points.Clear();
            this.chart1.Series["cluster3"].Points.Clear();
            this.chart1.Series["cluster4"].Points.Clear();
            this.chart1.Series["cluster5"].Points.Clear();
            this.chart2.Series["variance1"].Points.Clear();
            this.chart2.Series["variance2"].Points.Clear();
            this.chart2.Series["variance3"].Points.Clear();
            this.chart2.Series["variance4"].Points.Clear();
            this.chart2.Series["variance5"].Points.Clear();
            this.chart1.Series["raw data"].Points.Clear();

            if (loop) {
                loop_step++;

                if (loop_step > 4) { loop_step = 0; step++; }

                if (step <= int.Parse(comboBox2.Text)) { delay_timer.Start(); label2.Text = "Loop = " + step.ToString(); } else { loop = false; Loop_run_button.Text = "Loop Run"; delay_timer.Stop(); }

            }
        }


        private void Variance_Calculation_button_Click(object sender, EventArgs e)
        {
            variance_k1_x = 0;
            variance_k1_y = 0;
            variance_k2_x = 0;
            variance_k2_y = 0;
            variance_k3_x = 0;
            variance_k3_y = 0;
            variance_k4_x = 0;
            variance_k4_y = 0;
            variance_k5_x = 0;
            variance_k5_y = 0;

            if (running_c1>1)
            {
                for (int data = 0; data <= running_c1-1; data++)
                {
                    variance_k1_x += Math.Pow(ex_1[Convert.ToInt16(clusters[0, data]), 0] - mean_k1_x, 2);
                    variance_k1_y += Math.Pow(ex_1[Convert.ToInt16(clusters[0, data]), 1] - mean_k1_y, 2);
                }
                variance_k1_x = variance_k1_x / (running_c1-1);
                variance_k1_y = variance_k1_y / (running_c1-1);

                this.chart2.Series["variance1"].Points.Add(variance_k1_x + variance_k1_y);
            }

            if (running_c2 > 1)
            {
                for (int data = 0; data <= running_c2-1; data++)
                {
                    variance_k2_x += Math.Pow(ex_1[Convert.ToInt16(clusters[1, data]), 0] - mean_k2_x, 2);
                    variance_k2_y += Math.Pow(ex_1[Convert.ToInt16(clusters[1, data]), 1] - mean_k2_y, 2);
                }
                variance_k2_x = variance_k2_x / (running_c2 - 1);
                variance_k2_y = variance_k2_y / (running_c2 - 1);

                this.chart2.Series["variance2"].Points.Add(variance_k2_x + variance_k2_y);
            }

            if (running_c3 > 1)
            {
                for (int data = 0; data <= running_c3-1; data++)
                {
                    variance_k3_x += Math.Pow(ex_1[Convert.ToInt16(clusters[2, data]), 0] - mean_k3_x, 2);
                    variance_k3_y += Math.Pow(ex_1[Convert.ToInt16(clusters[2, data]), 1] - mean_k3_y, 2);
                }
                variance_k3_x = variance_k3_x / (running_c3 - 1);
                variance_k3_y = variance_k3_y / (running_c3 - 1);

                this.chart2.Series["variance3"].Points.Add(variance_k3_x + variance_k3_y);
            }

            if (running_c4 > 1)
            {
                for (int data = 0; data <= running_c4-1; data++)
                {
                    variance_k4_x += Math.Pow(ex_1[Convert.ToInt16(clusters[3, data]), 0] - mean_k4_x, 2);
                    variance_k4_y += Math.Pow(ex_1[Convert.ToInt16(clusters[3, data]), 1] - mean_k4_y, 2);
                }
                variance_k4_x = variance_k4_x / (running_c4 - 1);
                variance_k4_y = variance_k4_y / (running_c4 - 1);

                this.chart2.Series["variance4"].Points.Add(variance_k4_x + variance_k4_y);
            }

            if (running_c5 > 1)
            {
                for (int data = 0; data <= running_c5-1; data++)
                {
                    variance_k5_x += Math.Pow(ex_1[Convert.ToInt16(clusters[4, data]), 0] - mean_k5_x, 2);
                    variance_k5_y += Math.Pow(ex_1[Convert.ToInt16(clusters[4, data]), 1] - mean_k5_y, 2);
                }
                variance_k5_x = variance_k5_x / (running_c5 - 1);
                variance_k5_y = variance_k5_y / (running_c5 - 1);

                this.chart2.Series["variance5"].Points.Add(variance_k5_x + variance_k5_y);
            }


            variance_error = double.Parse(textBox1.Text);

            if (int.Parse(comboBox1.Text) == 2)
            {
                if (Math.Abs((variance_k1_x + variance_k1_y) - (variance_k2_x + variance_k2_y)) <= variance_error)
                {
                    delay_timer.Stop(); loop = false;
                }
                else { if (loop) { loop_step++; delay_timer.Start(); } }
            }

            if (int.Parse(comboBox1.Text) == 3)
            {
                if (Math.Abs((variance_k1_x + variance_k1_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k1_x + variance_k1_y)) <= variance_error)
                {
                    delay_timer.Stop(); loop = false;
                }
                else { if (loop) { loop_step++; delay_timer.Start(); } }
            }

            if (int.Parse(comboBox1.Text) == 4)
            {
                if (Math.Abs((variance_k1_x + variance_k1_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k4_x + variance_k4_y)) <= variance_error &&
                    Math.Abs((variance_k4_x + variance_k4_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k4_x + variance_k4_y) - (variance_k1_x + variance_k1_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k1_x + variance_k1_y)) <= variance_error)
                {
                    delay_timer.Stop(); loop = false;
                }
                else { if (loop) { loop_step++; delay_timer.Start(); } }
            }

            if (int.Parse(comboBox1.Text) == 5)
            {
                if (Math.Abs((variance_k1_x + variance_k1_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k4_x + variance_k4_y)) <= variance_error &&
                    Math.Abs((variance_k4_x + variance_k4_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k4_x + variance_k4_y) - (variance_k1_x + variance_k1_y)) <= variance_error &&
                    Math.Abs((variance_k5_x + variance_k5_y) - (variance_k1_x + variance_k1_y)) <= variance_error &&
                    Math.Abs((variance_k5_x + variance_k5_y) - (variance_k2_x + variance_k2_y)) <= variance_error &&
                    Math.Abs((variance_k5_x + variance_k5_y) - (variance_k3_x + variance_k3_y)) <= variance_error &&
                    Math.Abs((variance_k5_x + variance_k5_y) - (variance_k4_x + variance_k4_y)) <= variance_error &&
                    Math.Abs((variance_k3_x + variance_k3_y) - (variance_k1_x + variance_k1_y)) <= variance_error)
                {
                    delay_timer.Stop(); loop = false;
                }
                else { if (loop) { loop_step++; delay_timer.Start(); } }
            }

        }


        private void Loop_run_button_Click(object sender, EventArgs e)
        {
            Reset_button.PerformClick();
            loop_step = 0;
            step = 0;

            if (loop) { loop = false; Loop_run_button.Text = "Loop Run"; } else { loop = true; Loop_run_button.Text = "Stop"; }

            delay_timer.Enabled = true;
            delay_timer.Start();

        }


        private void delay_timer_Tick(object sender, EventArgs e)
        {
            delay_timer.Stop();

            if (loop_step == 0) { Random_button.PerformClick(); }
            else if (loop_step == 1) { Distance_Calculation_button.PerformClick(); }
            else if (loop_step == 2) { Clustering_button.PerformClick();}
            else if (loop_step == 3) { Variance_Calculation_button.PerformClick();  }
            else if (loop_step == 4) { Reset_button.PerformClick(); }
            
        }



        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ex_1 = new double[,] { { 5, 8 },
                                       { 2, 5 },
                                       { 3, 4 },
                                       { 4, 2 },
                                       { 6, 1 },
                                       { 8, 3 },
                                       { 5, 2 },
                                       { 3, 5 },
                                       { 2, 3 },
                                       { 6, 2 },
                                       { 6, 8 },
                                       { 4, 8 },
                                       { 9, 7 },
                                       { 8, 5 },
                                       { 4, 1 },
                                       { 2, 4 },
                                       { 1, 4 },
                                       { 1, 5 } };
            }

            if (radioButton2.Checked == true)
            {
                ex_1 = new double[,] { { 2.88, 3.95 },
                                        { 3.37, 1.57 },
                                        { 3.19, 1.46 },
                                        { 0.39, 0.65 },
                                        { 1.62, 3.96 },
                                        { 1.97, 3.13 },
                                        { 1.03, 2.82 },
                                        { 0.27, 3.26 },
                                        { 0.12, 2.19 },
                                        { 7.69, 7.52 },
                                        { 5.35, 8.32 },
                                        { 6.18, 6.89 },
                                        { 7.11, 8.33 },
                                        { 7.78, 8.52 },
                                        { 6.55, 5.68 },
                                        { 6.26, 6.26 },
                                        { 8.75, 5.57 },
                                        { 6.26, 8.77 } };
            }

            if (radioButton3.Checked == true)
            {
                ex_1 = new double[,] {  { 0.87, 2.35 },
                                        { 2.16, 1.19 },
                                        { 0.78, 2.66 },
                                        { 2.66, 0.82 },
                                        { 0.20, 1.36 },
                                        { 2.32, 0.69 },
                                        { 2.25, 6.72 },
                                        { 1.85, 7.29 },
                                        { 3.43, 8.76 },
                                        { 2.51, 8.91 },
                                        { 3.49, 6.88 },
                                        { 1.17, 7.65 },
                                        { 6.12, 5.55 },
                                        { 6.85, 4.54 },
                                        { 8.92, 6.75 },
                                        { 6.73, 5.42 },
                                        { 8.94, 4.70 },
                                        { 7.63, 4.67 } };
            }

        }

    }
}
