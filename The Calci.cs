using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total: " + c.ToString();


            }
            else if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Difference: " + c.ToString();


            }
            else if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Product: " + c.ToString();


            }
            else if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Quotient: " + c.ToString();



            }
            else if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Mod: " + c.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }
    }
}
