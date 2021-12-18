using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingVariableValues
{
    public partial class Form1 : Form
    {
        //int means values like - 10, 0, 50, not 5.678
        int x = 1;//this is present here so we have a variable we can use throughout our code
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"x={x}";// this is here so that the iunitial value of x can be shown on the form
        }

        private void button1_Click(object sender, EventArgs e)    
        {
            //+= has the effect of building out the output
            //x++ has the action of first allowing us to disaplay the vvalue of x, then the value increased by 1
            //\n at the end stack output vertically by pyutting output on new lines
            richTextBox1.Text += $"x={x++}\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;//reset variables to 1 
            richTextBox1.Text = "";//this clear the  text from the box on the left side
            richTextBox2.Text = "";//this clears the text from the box in the right side
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //+= has the effect of building out the output
            //++x has the action of first updating the value of x anhd thren showing it
            //\n at the end stack output vertically by pyutting output on new lines
            richTextBox2.Text += $"x={++x}\n";
        }
    }
}
