using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Decision_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Process(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("Distance from front Car higher than 15 meters"))
            {
                comboBox2.Enabled = true;
                textBox1.Text = "Checking Condition II";

                if (comboBox2.Text.Equals("Weather: Clear"))
                {
                    comboBox3.Enabled = true;
                    textBox1.Text = "Checking Condition III";

                    if (comboBox3.Text.Equals("Speed higher than 30 MPH"))
                    {
                        textBox1.Text = "Activate Braking asistance";
                    }
                    else if (comboBox3.Text.Equals("Speed lower than 30 MPH"))
                    {
                        textBox1.Text = "Not have assistant driving mode to activate";
                    }
                }
                else if (comboBox2.Text.Equals("Weather: Rain"))
                {
                    comboBox3.Enabled = false;
                    textBox1.Text = "Activate Braking asistance";
                }
            }
            else if (comboBox1.Text.Equals("Distance from front Car lower than 15 meters"))
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox1.Text = "Activate Braking asistance";
            }
        }
    }
}
