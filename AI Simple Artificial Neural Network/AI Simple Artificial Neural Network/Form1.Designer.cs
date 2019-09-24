namespace AI_Simple_Artificial_Neural_Network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.weight_input1_textBox = new System.Windows.Forms.TextBox();
            this.weight_input2_textBox = new System.Windows.Forms.TextBox();
            this.bias_node1_textBox = new System.Windows.Forms.TextBox();
            this.input_1_1_textBox = new System.Windows.Forms.TextBox();
            this.input_1_2_textBox = new System.Windows.Forms.TextBox();
            this.input_1_3_textBox = new System.Windows.Forms.TextBox();
            this.input_1_4_textBox = new System.Windows.Forms.TextBox();
            this.input_2_1_textBox = new System.Windows.Forms.TextBox();
            this.input_2_3_textBox = new System.Windows.Forms.TextBox();
            this.input_2_2_textBox = new System.Windows.Forms.TextBox();
            this.input_2_4_textBox = new System.Windows.Forms.TextBox();
            this.output_1_textBox = new System.Windows.Forms.TextBox();
            this.output_3_textBox = new System.Windows.Forms.TextBox();
            this.output_2_textBox = new System.Windows.Forms.TextBox();
            this.output_4_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.train_button = new System.Windows.Forms.Button();
            this.delay_timer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.learning_rate_textBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.result_1_textBox = new System.Windows.Forms.TextBox();
            this.result_3_textBox = new System.Windows.Forms.TextBox();
            this.result_2_textBox = new System.Windows.Forms.TextBox();
            this.result_4_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.error_4_textBox = new System.Windows.Forms.TextBox();
            this.error_2_textBox = new System.Windows.Forms.TextBox();
            this.error_3_textBox = new System.Windows.Forms.TextBox();
            this.error_1_textBox = new System.Windows.Forms.TextBox();
            this.bias_output_node_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.weight_output1_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // weight_input1_textBox
            // 
            this.weight_input1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_input1_textBox.Location = new System.Drawing.Point(283, 169);
            this.weight_input1_textBox.Name = "weight_input1_textBox";
            this.weight_input1_textBox.Size = new System.Drawing.Size(79, 32);
            this.weight_input1_textBox.TabIndex = 1;
            this.weight_input1_textBox.Text = "0.72";
            this.weight_input1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_input2_textBox
            // 
            this.weight_input2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_input2_textBox.Location = new System.Drawing.Point(283, 366);
            this.weight_input2_textBox.Name = "weight_input2_textBox";
            this.weight_input2_textBox.Size = new System.Drawing.Size(79, 32);
            this.weight_input2_textBox.TabIndex = 2;
            this.weight_input2_textBox.Text = "0.58";
            this.weight_input2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bias_node1_textBox
            // 
            this.bias_node1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bias_node1_textBox.Location = new System.Drawing.Point(407, 268);
            this.bias_node1_textBox.Name = "bias_node1_textBox";
            this.bias_node1_textBox.Size = new System.Drawing.Size(79, 32);
            this.bias_node1_textBox.TabIndex = 2;
            this.bias_node1_textBox.Text = "0.07";
            this.bias_node1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_1_textBox
            // 
            this.input_1_1_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_1_textBox.Location = new System.Drawing.Point(880, 32);
            this.input_1_1_textBox.Name = "input_1_1_textBox";
            this.input_1_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_1_textBox.TabIndex = 3;
            this.input_1_1_textBox.Text = "1";
            this.input_1_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_2_textBox
            // 
            this.input_1_2_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_2_textBox.Location = new System.Drawing.Point(880, 73);
            this.input_1_2_textBox.Name = "input_1_2_textBox";
            this.input_1_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_2_textBox.TabIndex = 3;
            this.input_1_2_textBox.Text = "1";
            this.input_1_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_3_textBox
            // 
            this.input_1_3_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_3_textBox.Location = new System.Drawing.Point(880, 114);
            this.input_1_3_textBox.Name = "input_1_3_textBox";
            this.input_1_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_3_textBox.TabIndex = 3;
            this.input_1_3_textBox.Text = "0";
            this.input_1_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_4_textBox
            // 
            this.input_1_4_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_4_textBox.Location = new System.Drawing.Point(880, 155);
            this.input_1_4_textBox.Name = "input_1_4_textBox";
            this.input_1_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_4_textBox.TabIndex = 3;
            this.input_1_4_textBox.Text = "0";
            this.input_1_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_1_textBox
            // 
            this.input_2_1_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_1_textBox.Location = new System.Drawing.Point(950, 32);
            this.input_2_1_textBox.Name = "input_2_1_textBox";
            this.input_2_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_1_textBox.TabIndex = 3;
            this.input_2_1_textBox.Text = "1";
            this.input_2_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_3_textBox
            // 
            this.input_2_3_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_3_textBox.Location = new System.Drawing.Point(950, 114);
            this.input_2_3_textBox.Name = "input_2_3_textBox";
            this.input_2_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_3_textBox.TabIndex = 3;
            this.input_2_3_textBox.Text = "1";
            this.input_2_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_2_textBox
            // 
            this.input_2_2_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_2_textBox.Location = new System.Drawing.Point(950, 73);
            this.input_2_2_textBox.Name = "input_2_2_textBox";
            this.input_2_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_2_textBox.TabIndex = 3;
            this.input_2_2_textBox.Text = "1";
            this.input_2_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_4_textBox
            // 
            this.input_2_4_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_4_textBox.Location = new System.Drawing.Point(950, 155);
            this.input_2_4_textBox.Name = "input_2_4_textBox";
            this.input_2_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_4_textBox.TabIndex = 3;
            this.input_2_4_textBox.Text = "0";
            this.input_2_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_1_textBox
            // 
            this.output_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_1_textBox.Location = new System.Drawing.Point(1020, 32);
            this.output_1_textBox.Name = "output_1_textBox";
            this.output_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_1_textBox.TabIndex = 3;
            this.output_1_textBox.Text = "1";
            this.output_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_3_textBox
            // 
            this.output_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_3_textBox.Location = new System.Drawing.Point(1020, 114);
            this.output_3_textBox.Name = "output_3_textBox";
            this.output_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_3_textBox.TabIndex = 3;
            this.output_3_textBox.Text = "1";
            this.output_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_2_textBox
            // 
            this.output_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_2_textBox.Location = new System.Drawing.Point(1020, 73);
            this.output_2_textBox.Name = "output_2_textBox";
            this.output_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_2_textBox.TabIndex = 3;
            this.output_2_textBox.Text = "1";
            this.output_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_4_textBox
            // 
            this.output_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_4_textBox.Location = new System.Drawing.Point(1020, 155);
            this.output_4_textBox.Name = "output_4_textBox";
            this.output_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_4_textBox.TabIndex = 3;
            this.output_4_textBox.Text = "0";
            this.output_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(882, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(952, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(1022, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(288, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "weight 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(288, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "weight 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(421, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "bias 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(880, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Iteration";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "250",
            "500",
            "1000",
            "5000"});
            this.comboBox1.Location = new System.Drawing.Point(972, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "10";
            // 
            // train_button
            // 
            this.train_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.train_button.Location = new System.Drawing.Point(1090, 393);
            this.train_button.Name = "train_button";
            this.train_button.Size = new System.Drawing.Size(134, 69);
            this.train_button.TabIndex = 11;
            this.train_button.Text = "Start";
            this.train_button.UseVisualStyleBackColor = true;
            this.train_button.Click += new System.EventHandler(this.train_button_Click);
            // 
            // delay_timer
            // 
            this.delay_timer.Interval = 1;
            this.delay_timer.Tick += new System.EventHandler(this.delay_timer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(882, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Learning rate";
            // 
            // learning_rate_textBox
            // 
            this.learning_rate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.learning_rate_textBox.Location = new System.Drawing.Point(991, 430);
            this.learning_rate_textBox.Name = "learning_rate_textBox";
            this.learning_rate_textBox.Size = new System.Drawing.Size(93, 32);
            this.learning_rate_textBox.TabIndex = 13;
            this.learning_rate_textBox.Text = "0.5";
            this.learning_rate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(880, 469);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 10);
            this.progressBar1.TabIndex = 16;
            // 
            // result_1_textBox
            // 
            this.result_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_1_textBox.Location = new System.Drawing.Point(1090, 32);
            this.result_1_textBox.Name = "result_1_textBox";
            this.result_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_1_textBox.TabIndex = 3;
            this.result_1_textBox.Text = "-";
            this.result_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_3_textBox
            // 
            this.result_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_3_textBox.Location = new System.Drawing.Point(1090, 114);
            this.result_3_textBox.Name = "result_3_textBox";
            this.result_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_3_textBox.TabIndex = 3;
            this.result_3_textBox.Text = "-";
            this.result_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_2_textBox
            // 
            this.result_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_2_textBox.Location = new System.Drawing.Point(1090, 73);
            this.result_2_textBox.Name = "result_2_textBox";
            this.result_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_2_textBox.TabIndex = 3;
            this.result_2_textBox.Text = "-";
            this.result_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_4_textBox
            // 
            this.result_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_4_textBox.Location = new System.Drawing.Point(1090, 155);
            this.result_4_textBox.Name = "result_4_textBox";
            this.result_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_4_textBox.TabIndex = 3;
            this.result_4_textBox.Text = "-";
            this.result_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(1092, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Result";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(1167, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Error";
            // 
            // error_4_textBox
            // 
            this.error_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_4_textBox.Location = new System.Drawing.Point(1160, 155);
            this.error_4_textBox.Name = "error_4_textBox";
            this.error_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_4_textBox.TabIndex = 18;
            this.error_4_textBox.Text = "-";
            this.error_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_2_textBox
            // 
            this.error_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_2_textBox.Location = new System.Drawing.Point(1160, 73);
            this.error_2_textBox.Name = "error_2_textBox";
            this.error_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_2_textBox.TabIndex = 19;
            this.error_2_textBox.Text = "-";
            this.error_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_3_textBox
            // 
            this.error_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_3_textBox.Location = new System.Drawing.Point(1160, 114);
            this.error_3_textBox.Name = "error_3_textBox";
            this.error_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_3_textBox.TabIndex = 20;
            this.error_3_textBox.Text = "-";
            this.error_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_1_textBox
            // 
            this.error_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_1_textBox.Location = new System.Drawing.Point(1160, 32);
            this.error_1_textBox.Name = "error_1_textBox";
            this.error_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_1_textBox.TabIndex = 21;
            this.error_1_textBox.Text = "-";
            this.error_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bias_output_node_textBox
            // 
            this.bias_output_node_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bias_output_node_textBox.Location = new System.Drawing.Point(692, 268);
            this.bias_output_node_textBox.Name = "bias_output_node_textBox";
            this.bias_output_node_textBox.Size = new System.Drawing.Size(79, 32);
            this.bias_output_node_textBox.TabIndex = 14;
            this.bias_output_node_textBox.Text = "0.4";
            this.bias_output_node_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(706, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "bias 2";
            // 
            // weight_output1_textbox
            // 
            this.weight_output1_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_output1_textbox.Location = new System.Drawing.Point(547, 235);
            this.weight_output1_textbox.Name = "weight_output1_textbox";
            this.weight_output1_textbox.Size = new System.Drawing.Size(79, 32);
            this.weight_output1_textbox.TabIndex = 2;
            this.weight_output1_textbox.Text = "0.94";
            this.weight_output1_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(553, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "weight 3";
            // 
            // chart1
            // 
            chartArea3.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("BrowalliaUPC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(880, 220);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Salmon;
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Mean Squre Error";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(344, 167);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1009, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mean Squre Error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 492);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.error_4_textBox);
            this.Controls.Add(this.error_2_textBox);
            this.Controls.Add(this.error_3_textBox);
            this.Controls.Add(this.error_1_textBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bias_output_node_textBox);
            this.Controls.Add(this.learning_rate_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.train_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_4_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_4_textBox);
            this.Controls.Add(this.input_2_4_textBox);
            this.Controls.Add(this.result_2_textBox);
            this.Controls.Add(this.input_1_4_textBox);
            this.Controls.Add(this.output_2_textBox);
            this.Controls.Add(this.input_2_2_textBox);
            this.Controls.Add(this.result_3_textBox);
            this.Controls.Add(this.input_1_2_textBox);
            this.Controls.Add(this.output_3_textBox);
            this.Controls.Add(this.input_2_3_textBox);
            this.Controls.Add(this.result_1_textBox);
            this.Controls.Add(this.input_1_3_textBox);
            this.Controls.Add(this.output_1_textBox);
            this.Controls.Add(this.input_2_1_textBox);
            this.Controls.Add(this.input_1_1_textBox);
            this.Controls.Add(this.weight_output1_textbox);
            this.Controls.Add(this.bias_node1_textBox);
            this.Controls.Add(this.weight_input2_textBox);
            this.Controls.Add(this.weight_input1_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "AI Simple Artificial Neural Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox weight_input1_textBox;
        private System.Windows.Forms.TextBox weight_input2_textBox;
        private System.Windows.Forms.TextBox bias_node1_textBox;
        private System.Windows.Forms.TextBox input_1_1_textBox;
        private System.Windows.Forms.TextBox input_1_2_textBox;
        private System.Windows.Forms.TextBox input_1_3_textBox;
        private System.Windows.Forms.TextBox input_1_4_textBox;
        private System.Windows.Forms.TextBox input_2_1_textBox;
        private System.Windows.Forms.TextBox input_2_3_textBox;
        private System.Windows.Forms.TextBox input_2_2_textBox;
        private System.Windows.Forms.TextBox input_2_4_textBox;
        private System.Windows.Forms.TextBox output_1_textBox;
        private System.Windows.Forms.TextBox output_3_textBox;
        private System.Windows.Forms.TextBox output_2_textBox;
        private System.Windows.Forms.TextBox output_4_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button train_button;
        private System.Windows.Forms.Timer delay_timer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox learning_rate_textBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox result_1_textBox;
        private System.Windows.Forms.TextBox result_3_textBox;
        private System.Windows.Forms.TextBox result_2_textBox;
        private System.Windows.Forms.TextBox result_4_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox error_4_textBox;
        private System.Windows.Forms.TextBox error_2_textBox;
        private System.Windows.Forms.TextBox error_3_textBox;
        private System.Windows.Forms.TextBox error_1_textBox;
        private System.Windows.Forms.TextBox bias_output_node_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weight_output1_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label12;
    }
}

