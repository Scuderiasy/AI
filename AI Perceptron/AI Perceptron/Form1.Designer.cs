namespace AI_Perceptron
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.error_4_textBox = new System.Windows.Forms.TextBox();
            this.error_2_textBox = new System.Windows.Forms.TextBox();
            this.error_3_textBox = new System.Windows.Forms.TextBox();
            this.error_1_textBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.learning_rate_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.delay_timer = new System.Windows.Forms.Timer(this.components);
            this.train_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_4_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output_4_textBox = new System.Windows.Forms.TextBox();
            this.input_2_4_textBox = new System.Windows.Forms.TextBox();
            this.result_2_textBox = new System.Windows.Forms.TextBox();
            this.input_1_4_textBox = new System.Windows.Forms.TextBox();
            this.output_2_textBox = new System.Windows.Forms.TextBox();
            this.input_2_2_textBox = new System.Windows.Forms.TextBox();
            this.result_3_textBox = new System.Windows.Forms.TextBox();
            this.input_1_2_textBox = new System.Windows.Forms.TextBox();
            this.output_3_textBox = new System.Windows.Forms.TextBox();
            this.input_2_3_textBox = new System.Windows.Forms.TextBox();
            this.result_1_textBox = new System.Windows.Forms.TextBox();
            this.input_1_3_textBox = new System.Windows.Forms.TextBox();
            this.output_1_textBox = new System.Windows.Forms.TextBox();
            this.input_2_1_textBox = new System.Windows.Forms.TextBox();
            this.input_1_1_textBox = new System.Windows.Forms.TextBox();
            this.bias_node1_textBox = new System.Windows.Forms.TextBox();
            this.weight_input2_textBox = new System.Windows.Forms.TextBox();
            this.weight_input1_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1008, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Mean Squre Error";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(1166, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Error";
            // 
            // error_4_textBox
            // 
            this.error_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_4_textBox.Location = new System.Drawing.Point(1159, 155);
            this.error_4_textBox.Name = "error_4_textBox";
            this.error_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_4_textBox.TabIndex = 62;
            this.error_4_textBox.Text = "-";
            this.error_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_2_textBox
            // 
            this.error_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_2_textBox.Location = new System.Drawing.Point(1159, 73);
            this.error_2_textBox.Name = "error_2_textBox";
            this.error_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_2_textBox.TabIndex = 63;
            this.error_2_textBox.Text = "-";
            this.error_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_3_textBox
            // 
            this.error_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_3_textBox.Location = new System.Drawing.Point(1159, 114);
            this.error_3_textBox.Name = "error_3_textBox";
            this.error_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_3_textBox.TabIndex = 64;
            this.error_3_textBox.Text = "-";
            this.error_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_1_textBox
            // 
            this.error_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.error_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.error_1_textBox.Location = new System.Drawing.Point(1159, 32);
            this.error_1_textBox.Name = "error_1_textBox";
            this.error_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.error_1_textBox.TabIndex = 65;
            this.error_1_textBox.Text = "-";
            this.error_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(879, 531);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 10);
            this.progressBar1.TabIndex = 61;
            // 
            // learning_rate_textBox
            // 
            this.learning_rate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.learning_rate_textBox.Location = new System.Drawing.Point(990, 492);
            this.learning_rate_textBox.Name = "learning_rate_textBox";
            this.learning_rate_textBox.Size = new System.Drawing.Size(93, 32);
            this.learning_rate_textBox.TabIndex = 58;
            this.learning_rate_textBox.Text = "0.5";
            this.learning_rate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(881, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Learning rate";
            // 
            // delay_timer
            // 
            this.delay_timer.Interval = 20;
            this.delay_timer.Tick += new System.EventHandler(this.delay_timer_Tick);
            // 
            // train_button
            // 
            this.train_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.train_button.Location = new System.Drawing.Point(1089, 455);
            this.train_button.Name = "train_button";
            this.train_button.Size = new System.Drawing.Size(134, 69);
            this.train_button.TabIndex = 56;
            this.train_button.Text = "Start";
            this.train_button.UseVisualStyleBackColor = true;
            this.train_button.Click += new System.EventHandler(this.train_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "75",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(971, 455);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 28);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(879, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Iteration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(408, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "bias 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(281, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "weight 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(287, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "weight 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(1091, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(1021, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(951, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Input 2";
            // 
            // result_4_textBox
            // 
            this.result_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_4_textBox.Location = new System.Drawing.Point(1089, 155);
            this.result_4_textBox.Name = "result_4_textBox";
            this.result_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_4_textBox.TabIndex = 45;
            this.result_4_textBox.Text = "-";
            this.result_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(881, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Input 1";
            // 
            // output_4_textBox
            // 
            this.output_4_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_4_textBox.Location = new System.Drawing.Point(1019, 155);
            this.output_4_textBox.Name = "output_4_textBox";
            this.output_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_4_textBox.TabIndex = 30;
            this.output_4_textBox.Text = "-1";
            this.output_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_4_textBox
            // 
            this.input_2_4_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_4_textBox.Location = new System.Drawing.Point(949, 155);
            this.input_2_4_textBox.Name = "input_2_4_textBox";
            this.input_2_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_4_textBox.TabIndex = 31;
            this.input_2_4_textBox.Text = "0.3";
            this.input_2_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_2_textBox
            // 
            this.result_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_2_textBox.Location = new System.Drawing.Point(1089, 73);
            this.result_2_textBox.Name = "result_2_textBox";
            this.result_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_2_textBox.TabIndex = 32;
            this.result_2_textBox.Text = "-";
            this.result_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_4_textBox
            // 
            this.input_1_4_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_4_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_4_textBox.Location = new System.Drawing.Point(879, 155);
            this.input_1_4_textBox.Name = "input_1_4_textBox";
            this.input_1_4_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_4_textBox.TabIndex = 33;
            this.input_1_4_textBox.Text = "0.1";
            this.input_1_4_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_2_textBox
            // 
            this.output_2_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_2_textBox.Location = new System.Drawing.Point(1019, 73);
            this.output_2_textBox.Name = "output_2_textBox";
            this.output_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_2_textBox.TabIndex = 34;
            this.output_2_textBox.Text = "1";
            this.output_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_2_textBox
            // 
            this.input_2_2_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_2_textBox.Location = new System.Drawing.Point(949, 73);
            this.input_2_2_textBox.Name = "input_2_2_textBox";
            this.input_2_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_2_textBox.TabIndex = 35;
            this.input_2_2_textBox.Text = "0.6";
            this.input_2_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_3_textBox
            // 
            this.result_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_3_textBox.Location = new System.Drawing.Point(1089, 114);
            this.result_3_textBox.Name = "result_3_textBox";
            this.result_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_3_textBox.TabIndex = 36;
            this.result_3_textBox.Text = "-";
            this.result_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_2_textBox
            // 
            this.input_1_2_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_2_textBox.Location = new System.Drawing.Point(879, 73);
            this.input_1_2_textBox.Name = "input_1_2_textBox";
            this.input_1_2_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_2_textBox.TabIndex = 37;
            this.input_1_2_textBox.Text = "0.4";
            this.input_1_2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_3_textBox
            // 
            this.output_3_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_3_textBox.Location = new System.Drawing.Point(1019, 114);
            this.output_3_textBox.Name = "output_3_textBox";
            this.output_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_3_textBox.TabIndex = 44;
            this.output_3_textBox.Text = "-1";
            this.output_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_3_textBox
            // 
            this.input_2_3_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_3_textBox.Location = new System.Drawing.Point(949, 114);
            this.input_2_3_textBox.Name = "input_2_3_textBox";
            this.input_2_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_3_textBox.TabIndex = 38;
            this.input_2_3_textBox.Text = "0.5";
            this.input_2_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result_1_textBox
            // 
            this.result_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.result_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result_1_textBox.Location = new System.Drawing.Point(1089, 32);
            this.result_1_textBox.Name = "result_1_textBox";
            this.result_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.result_1_textBox.TabIndex = 39;
            this.result_1_textBox.Text = "-";
            this.result_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_3_textBox
            // 
            this.input_1_3_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_3_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_3_textBox.Location = new System.Drawing.Point(879, 114);
            this.input_1_3_textBox.Name = "input_1_3_textBox";
            this.input_1_3_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_3_textBox.TabIndex = 40;
            this.input_1_3_textBox.Text = "0.2";
            this.input_1_3_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_1_textBox
            // 
            this.output_1_textBox.BackColor = System.Drawing.Color.MistyRose;
            this.output_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.output_1_textBox.Location = new System.Drawing.Point(1019, 32);
            this.output_1_textBox.Name = "output_1_textBox";
            this.output_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.output_1_textBox.TabIndex = 41;
            this.output_1_textBox.Text = "1";
            this.output_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_2_1_textBox
            // 
            this.input_2_1_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_2_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_2_1_textBox.Location = new System.Drawing.Point(949, 32);
            this.input_2_1_textBox.Name = "input_2_1_textBox";
            this.input_2_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_2_1_textBox.TabIndex = 42;
            this.input_2_1_textBox.Text = "0.2";
            this.input_2_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_1_1_textBox
            // 
            this.input_1_1_textBox.BackColor = System.Drawing.Color.Cornsilk;
            this.input_1_1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_1_1_textBox.Location = new System.Drawing.Point(879, 32);
            this.input_1_1_textBox.Name = "input_1_1_textBox";
            this.input_1_1_textBox.Size = new System.Drawing.Size(64, 35);
            this.input_1_1_textBox.TabIndex = 43;
            this.input_1_1_textBox.Text = "0.7";
            this.input_1_1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bias_node1_textBox
            // 
            this.bias_node1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bias_node1_textBox.Location = new System.Drawing.Point(394, 299);
            this.bias_node1_textBox.Name = "bias_node1_textBox";
            this.bias_node1_textBox.Size = new System.Drawing.Size(79, 32);
            this.bias_node1_textBox.TabIndex = 27;
            this.bias_node1_textBox.Text = "1";
            this.bias_node1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_input2_textBox
            // 
            this.weight_input2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_input2_textBox.Location = new System.Drawing.Point(276, 429);
            this.weight_input2_textBox.Name = "weight_input2_textBox";
            this.weight_input2_textBox.Size = new System.Drawing.Size(79, 32);
            this.weight_input2_textBox.TabIndex = 29;
            this.weight_input2_textBox.Text = "0.58";
            this.weight_input2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_input1_textBox
            // 
            this.weight_input1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.weight_input1_textBox.Location = new System.Drawing.Point(282, 182);
            this.weight_input1_textBox.Name = "weight_input1_textBox";
            this.weight_input1_textBox.Size = new System.Drawing.Size(79, 32);
            this.weight_input1_textBox.TabIndex = 26;
            this.weight_input1_textBox.Text = "0.72";
            this.weight_input1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(879, 222);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Salmon;
            series1.MarkerSize = 9;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Error";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(344, 225);
            this.chart1.TabIndex = 68;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 561);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.error_4_textBox);
            this.Controls.Add(this.error_2_textBox);
            this.Controls.Add(this.error_3_textBox);
            this.Controls.Add(this.error_1_textBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.learning_rate_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.train_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.bias_node1_textBox);
            this.Controls.Add(this.weight_input2_textBox);
            this.Controls.Add(this.weight_input1_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox error_4_textBox;
        private System.Windows.Forms.TextBox error_2_textBox;
        private System.Windows.Forms.TextBox error_3_textBox;
        private System.Windows.Forms.TextBox error_1_textBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox learning_rate_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer delay_timer;
        private System.Windows.Forms.Button train_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_4_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output_4_textBox;
        private System.Windows.Forms.TextBox input_2_4_textBox;
        private System.Windows.Forms.TextBox result_2_textBox;
        private System.Windows.Forms.TextBox input_1_4_textBox;
        private System.Windows.Forms.TextBox output_2_textBox;
        private System.Windows.Forms.TextBox input_2_2_textBox;
        private System.Windows.Forms.TextBox result_3_textBox;
        private System.Windows.Forms.TextBox input_1_2_textBox;
        private System.Windows.Forms.TextBox output_3_textBox;
        private System.Windows.Forms.TextBox input_2_3_textBox;
        private System.Windows.Forms.TextBox result_1_textBox;
        private System.Windows.Forms.TextBox input_1_3_textBox;
        private System.Windows.Forms.TextBox output_1_textBox;
        private System.Windows.Forms.TextBox input_2_1_textBox;
        private System.Windows.Forms.TextBox input_1_1_textBox;
        private System.Windows.Forms.TextBox bias_node1_textBox;
        private System.Windows.Forms.TextBox weight_input2_textBox;
        private System.Windows.Forms.TextBox weight_input1_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

