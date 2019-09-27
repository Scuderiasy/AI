namespace AI_Talk_with_bot___DTH_sensor_arduino
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.humid_textBox = new System.Windows.Forms.TextBox();
            this.temp_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.read_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Temperature";
            // 
            // humid_textBox
            // 
            this.humid_textBox.Location = new System.Drawing.Point(296, 60);
            this.humid_textBox.Name = "humid_textBox";
            this.humid_textBox.Size = new System.Drawing.Size(94, 20);
            this.humid_textBox.TabIndex = 13;
            this.humid_textBox.Text = "-";
            this.humid_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temp_textBox
            // 
            this.temp_textBox.Location = new System.Drawing.Point(296, 12);
            this.temp_textBox.Name = "temp_textBox";
            this.temp_textBox.Size = new System.Drawing.Size(94, 20);
            this.temp_textBox.TabIndex = 12;
            this.temp_textBox.Text = "-";
            this.temp_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // connect_button
            // 
            this.connect_button.Enabled = false;
            this.connect_button.Location = new System.Drawing.Point(12, 12);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(94, 23);
            this.connect_button.TabIndex = 10;
            this.connect_button.Text = "Arduino Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "try: what tempature is it";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "try: what humidity is it";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.read_data_from_arduino);
            // 
            // read_timer
            // 
            this.read_timer.Interval = 500;
            this.read_timer.Tick += new System.EventHandler(this.read_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humid_textBox);
            this.Controls.Add(this.temp_textBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.connect_button);
            this.Name = "Form1";
            this.Text = "AI Talk with bot + DTH sensor arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox humid_textBox;
        private System.Windows.Forms.TextBox temp_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer read_timer;
    }
}

