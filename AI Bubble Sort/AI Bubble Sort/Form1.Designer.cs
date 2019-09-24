namespace AI_Bubble_Sort
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.random_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sorting_button = new System.Windows.Forms.Button();
            this.delay_timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delay_textBox = new System.Windows.Forms.TextBox();
            this.begin_label = new System.Windows.Forms.Label();
            this.end_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Crimson;
            series3.Legend = "Legend1";
            series3.Name = "Data";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(993, 402);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // random_button
            // 
            this.random_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.random_button.Location = new System.Drawing.Point(539, 422);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(131, 49);
            this.random_button.TabIndex = 1;
            this.random_button.Text = "Random";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(156, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Number";
            // 
            // sorting_button
            // 
            this.sorting_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sorting_button.Location = new System.Drawing.Point(685, 422);
            this.sorting_button.Name = "sorting_button";
            this.sorting_button.Size = new System.Drawing.Size(134, 49);
            this.sorting_button.TabIndex = 4;
            this.sorting_button.Text = "Sort";
            this.sorting_button.UseVisualStyleBackColor = true;
            this.sorting_button.Click += new System.EventHandler(this.sorting_button_Click);
            // 
            // delay_timer
            // 
            this.delay_timer.Tick += new System.EventHandler(this.delay_timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(301, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(469, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "msec";
            // 
            // delay_textBox
            // 
            this.delay_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.delay_textBox.Location = new System.Drawing.Point(381, 430);
            this.delay_textBox.Name = "delay_textBox";
            this.delay_textBox.Size = new System.Drawing.Size(68, 32);
            this.delay_textBox.TabIndex = 6;
            this.delay_textBox.Text = "20";
            this.delay_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // begin_label
            // 
            this.begin_label.AutoSize = true;
            this.begin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.begin_label.Location = new System.Drawing.Point(834, 422);
            this.begin_label.Name = "begin_label";
            this.begin_label.Size = new System.Drawing.Size(63, 20);
            this.begin_label.TabIndex = 7;
            this.begin_label.Text = "Begin: -";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.end_label.Location = new System.Drawing.Point(834, 450);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(51, 20);
            this.end_label.TabIndex = 8;
            this.end_label.Text = "End: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 479);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.begin_label);
            this.Controls.Add(this.delay_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sorting_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "AI Bubble Sort";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sorting_button;
        private System.Windows.Forms.Timer delay_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delay_textBox;
        private System.Windows.Forms.Label begin_label;
        private System.Windows.Forms.Label end_label;
    }
}

