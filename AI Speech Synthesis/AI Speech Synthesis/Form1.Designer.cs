namespace AI_Speech_Synthesis
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
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Speak_pictureBox = new System.Windows.Forms.PictureBox();
            this.welcome_timer = new System.Windows.Forms.Timer(this.components);
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Speak_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.input_textBox.Location = new System.Drawing.Point(12, 42);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(375, 224);
            this.input_textBox.TabIndex = 0;
            this.input_textBox.Text = "Please Type Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // Speak_pictureBox
            // 
            this.Speak_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Speak_pictureBox.Image")));
            this.Speak_pictureBox.Location = new System.Drawing.Point(119, 275);
            this.Speak_pictureBox.Name = "Speak_pictureBox";
            this.Speak_pictureBox.Size = new System.Drawing.Size(160, 160);
            this.Speak_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Speak_pictureBox.TabIndex = 2;
            this.Speak_pictureBox.TabStop = false;
            this.Speak_pictureBox.Click += new System.EventHandler(this.Speak_pictureBox_Click);
            // 
            // welcome_timer
            // 
            this.welcome_timer.Tick += new System.EventHandler(this.welcome_timer_Tick);
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Checked = true;
            this.male_radioButton.Location = new System.Drawing.Point(22, 315);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(48, 17);
            this.male_radioButton.TabIndex = 3;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(22, 363);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(59, 17);
            this.female_radioButton.TabIndex = 3;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 446);
            this.Controls.Add(this.female_radioButton);
            this.Controls.Add(this.male_radioButton);
            this.Controls.Add(this.Speak_pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_textBox);
            this.Name = "Form1";
            this.Text = "AI Speech Synthesis";
            ((System.ComponentModel.ISupportInitialize)(this.Speak_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Speak_pictureBox;
        private System.Windows.Forms.Timer welcome_timer;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RadioButton female_radioButton;
    }
}

