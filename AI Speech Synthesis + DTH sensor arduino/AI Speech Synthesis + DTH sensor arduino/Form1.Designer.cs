namespace AI_Speech_Synthesis___DTH_sensor_arduino
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.temp_button = new System.Windows.Forms.Button();
            this.humid_button = new System.Windows.Forms.Button();
            this.read_timer = new System.Windows.Forms.Timer(this.components);
            this.temp_textBox = new System.Windows.Forms.TextBox();
            this.humid_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // connect_button
            // 
            this.connect_button.Enabled = false;
            this.connect_button.Location = new System.Drawing.Point(12, 12);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(94, 23);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Arduino Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.read_data_from_arduino);
            // 
            // temp_button
            // 
            this.temp_button.Location = new System.Drawing.Point(220, 14);
            this.temp_button.Name = "temp_button";
            this.temp_button.Size = new System.Drawing.Size(94, 74);
            this.temp_button.TabIndex = 4;
            this.temp_button.Text = "Speak Temperature";
            this.temp_button.UseVisualStyleBackColor = true;
            this.temp_button.Click += new System.EventHandler(this.temp_button_Click);
            // 
            // humid_button
            // 
            this.humid_button.Location = new System.Drawing.Point(320, 14);
            this.humid_button.Name = "humid_button";
            this.humid_button.Size = new System.Drawing.Size(94, 74);
            this.humid_button.TabIndex = 5;
            this.humid_button.Text = "Speak Humidity";
            this.humid_button.UseVisualStyleBackColor = true;
            this.humid_button.Click += new System.EventHandler(this.humid_button_Click);
            // 
            // read_timer
            // 
            this.read_timer.Interval = 500;
            this.read_timer.Tick += new System.EventHandler(this.read_timer_Tick);
            // 
            // temp_textBox
            // 
            this.temp_textBox.Location = new System.Drawing.Point(12, 67);
            this.temp_textBox.Name = "temp_textBox";
            this.temp_textBox.Size = new System.Drawing.Size(94, 20);
            this.temp_textBox.TabIndex = 6;
            this.temp_textBox.Text = "-";
            this.temp_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // humid_textBox
            // 
            this.humid_textBox.Location = new System.Drawing.Point(120, 67);
            this.humid_textBox.Name = "humid_textBox";
            this.humid_textBox.Size = new System.Drawing.Size(94, 20);
            this.humid_textBox.TabIndex = 7;
            this.humid_textBox.Text = "-";
            this.humid_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Humidity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 98);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humid_textBox);
            this.Controls.Add(this.temp_textBox);
            this.Controls.Add(this.humid_button);
            this.Controls.Add(this.temp_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.connect_button);
            this.Name = "Form1";
            this.Text = "AI Speech Synthesis + DTH sonsor arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button temp_button;
        private System.Windows.Forms.Button humid_button;
        private System.Windows.Forms.Timer read_timer;
        private System.Windows.Forms.TextBox temp_textBox;
        private System.Windows.Forms.TextBox humid_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

