namespace AI_K_Means_clustering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series129 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series130 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series131 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series132 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series133 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series134 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series135 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series136 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series137 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series138 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series139 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series140 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series141 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series142 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series143 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series144 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Clustering_button = new System.Windows.Forms.Button();
            this.Random_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Distance_Calculation_button = new System.Windows.Forms.Button();
            this.Variance_Calculation_button = new System.Windows.Forms.Button();
            this.Loop_run_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.delay_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea17.AxisX.Interval = 1D;
            chartArea17.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea17.AxisX.Maximum = 10D;
            chartArea17.AxisX.Minimum = 0D;
            chartArea17.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea17.AxisY.Interval = 1D;
            chartArea17.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea17.AxisY.Maximum = 10D;
            chartArea17.AxisY.Minimum = 0D;
            chartArea17.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart1.Legends.Add(legend17);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series129.ChartArea = "ChartArea1";
            series129.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series129.Legend = "Legend1";
            series129.MarkerColor = System.Drawing.Color.CornflowerBlue;
            series129.MarkerSize = 8;
            series129.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series129.Name = "cluster1";
            series130.ChartArea = "ChartArea1";
            series130.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series130.Legend = "Legend1";
            series130.MarkerSize = 8;
            series130.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series130.Name = "cluster2";
            series131.ChartArea = "ChartArea1";
            series131.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series131.Legend = "Legend1";
            series131.MarkerSize = 8;
            series131.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series131.Name = "cluster3";
            series132.ChartArea = "ChartArea1";
            series132.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series132.Legend = "Legend1";
            series132.MarkerSize = 8;
            series132.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series132.Name = "cluster4";
            series133.ChartArea = "ChartArea1";
            series133.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series133.Legend = "Legend1";
            series133.MarkerBorderColor = System.Drawing.Color.Violet;
            series133.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series133.MarkerSize = 8;
            series133.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series133.Name = "cluster5";
            series134.ChartArea = "ChartArea1";
            series134.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series134.Legend = "Legend1";
            series134.MarkerBorderColor = System.Drawing.Color.Transparent;
            series134.MarkerColor = System.Drawing.Color.CornflowerBlue;
            series134.MarkerSize = 17;
            series134.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series134.Name = "k-position1";
            series135.ChartArea = "ChartArea1";
            series135.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series135.Legend = "Legend1";
            series135.MarkerColor = System.Drawing.Color.Orange;
            series135.MarkerSize = 17;
            series135.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series135.Name = "k-position2";
            series136.ChartArea = "ChartArea1";
            series136.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series136.Legend = "Legend1";
            series136.MarkerColor = System.Drawing.Color.Salmon;
            series136.MarkerSize = 17;
            series136.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series136.Name = "k-position3";
            series137.ChartArea = "ChartArea1";
            series137.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series137.Legend = "Legend1";
            series137.MarkerColor = System.Drawing.Color.Teal;
            series137.MarkerSize = 17;
            series137.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series137.Name = "k-position4";
            series138.ChartArea = "ChartArea1";
            series138.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series138.Legend = "Legend1";
            series138.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series138.MarkerSize = 17;
            series138.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series138.Name = "k-position5";
            series139.ChartArea = "ChartArea1";
            series139.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series139.Legend = "Legend1";
            series139.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series139.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series139.Name = "raw data";
            this.chart1.Series.Add(series129);
            this.chart1.Series.Add(series130);
            this.chart1.Series.Add(series131);
            this.chart1.Series.Add(series132);
            this.chart1.Series.Add(series133);
            this.chart1.Series.Add(series134);
            this.chart1.Series.Add(series135);
            this.chart1.Series.Add(series136);
            this.chart1.Series.Add(series137);
            this.chart1.Series.Add(series138);
            this.chart1.Series.Add(series139);
            this.chart1.Size = new System.Drawing.Size(635, 398);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "K =";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(42, 582);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(32, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(404, 584);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Example 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(488, 584);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Example 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // chart2
            // 
            chartArea18.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea18.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea18.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart2.Legends.Add(legend18);
            this.chart2.Location = new System.Drawing.Point(12, 416);
            this.chart2.Name = "chart2";
            series140.ChartArea = "ChartArea1";
            series140.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series140.Legend = "Legend1";
            series140.Name = "variance1";
            series141.ChartArea = "ChartArea1";
            series141.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series141.Legend = "Legend1";
            series141.Name = "variance2";
            series142.ChartArea = "ChartArea1";
            series142.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series142.Legend = "Legend1";
            series142.Name = "variance3";
            series143.ChartArea = "ChartArea1";
            series143.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series143.Legend = "Legend1";
            series143.Name = "variance4";
            series144.ChartArea = "ChartArea1";
            series144.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series144.Color = System.Drawing.Color.Violet;
            series144.Legend = "Legend1";
            series144.MarkerColor = System.Drawing.Color.Violet;
            series144.Name = "variance5";
            this.chart2.Series.Add(series140);
            this.chart2.Series.Add(series141);
            this.chart2.Series.Add(series142);
            this.chart2.Series.Add(series143);
            this.chart2.Series.Add(series144);
            this.chart2.Size = new System.Drawing.Size(635, 151);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // Clustering_button
            // 
            this.Clustering_button.Location = new System.Drawing.Point(224, 621);
            this.Clustering_button.Name = "Clustering_button";
            this.Clustering_button.Size = new System.Drawing.Size(100, 47);
            this.Clustering_button.TabIndex = 9;
            this.Clustering_button.Text = "Clustering";
            this.Clustering_button.UseVisualStyleBackColor = true;
            this.Clustering_button.Click += new System.EventHandler(this.Clustering_button_Click);
            // 
            // Random_button
            // 
            this.Random_button.Location = new System.Drawing.Point(12, 621);
            this.Random_button.Name = "Random_button";
            this.Random_button.Size = new System.Drawing.Size(100, 47);
            this.Random_button.TabIndex = 10;
            this.Random_button.Text = "Random";
            this.Random_button.UseVisualStyleBackColor = true;
            this.Random_button.Click += new System.EventHandler(this.Random_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(438, 621);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(100, 47);
            this.Reset_button.TabIndex = 11;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Distance_Calculation_button
            // 
            this.Distance_Calculation_button.Location = new System.Drawing.Point(118, 621);
            this.Distance_Calculation_button.Name = "Distance_Calculation_button";
            this.Distance_Calculation_button.Size = new System.Drawing.Size(100, 47);
            this.Distance_Calculation_button.TabIndex = 16;
            this.Distance_Calculation_button.Text = "Distance Calculation";
            this.Distance_Calculation_button.UseVisualStyleBackColor = true;
            this.Distance_Calculation_button.Click += new System.EventHandler(this.Distance_Calculation_Click);
            // 
            // Variance_Calculation_button
            // 
            this.Variance_Calculation_button.Location = new System.Drawing.Point(330, 621);
            this.Variance_Calculation_button.Name = "Variance_Calculation_button";
            this.Variance_Calculation_button.Size = new System.Drawing.Size(100, 47);
            this.Variance_Calculation_button.TabIndex = 17;
            this.Variance_Calculation_button.Text = "Variance Calculation";
            this.Variance_Calculation_button.UseVisualStyleBackColor = true;
            this.Variance_Calculation_button.Click += new System.EventHandler(this.Variance_Calculation_button_Click);
            // 
            // Loop_run_button
            // 
            this.Loop_run_button.Location = new System.Drawing.Point(544, 621);
            this.Loop_run_button.Name = "Loop_run_button";
            this.Loop_run_button.Size = new System.Drawing.Size(100, 47);
            this.Loop_run_button.TabIndex = 18;
            this.Loop_run_button.Text = "Loop Run";
            this.Loop_run_button.UseVisualStyleBackColor = true;
            this.Loop_run_button.Click += new System.EventHandler(this.Loop_run_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Iteration";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "150",
            "200"});
            this.comboBox2.Location = new System.Drawing.Point(137, 582);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Varaince error";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 582);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "2";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(572, 584);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Example 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Loop = -";
            // 
            // delay_timer
            // 
            this.delay_timer.Interval = 200;
            this.delay_timer.Tick += new System.EventHandler(this.delay_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loop_run_button);
            this.Controls.Add(this.Variance_Calculation_button);
            this.Controls.Add(this.Distance_Calculation_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Random_button);
            this.Controls.Add(this.Clustering_button);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "AI K-Means Clustering";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button Clustering_button;
        private System.Windows.Forms.Button Random_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Distance_Calculation_button;
        private System.Windows.Forms.Button Variance_Calculation_button;
        private System.Windows.Forms.Button Loop_run_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer delay_timer;
    }
}

