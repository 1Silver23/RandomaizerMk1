using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomaizerMk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startТNumbers = (int)numericUpDown1.Value;
            int maxNumbers = (int)numericUpDown3.Value;
            int guantity = (int)numericUpDown2.Value;
            string result = "";
            Random ran = new Random();
            for (int i = 0; i < maxNumbers; i++)
            {
                result += $"{ran.Next(startТNumbers, guantity +1)}";
                if (i < maxNumbers - 1)
                    result += " ";
                //int a = startТNumbers;
                //int b = guantity;
                //int value = ran.Next(a, b +1);
                //richTextBox1.Text += string.Join("/n", value.ToString().ToCharArray()) ;
            }
            richTextBox1.Text += result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }       
    }
}
