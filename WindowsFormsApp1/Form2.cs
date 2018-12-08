using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        double a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            /* a = Convert.ToInt32(firestnumber.Text);
             b = Convert.ToInt32(secondnumber.Text);
             c = a * b;
             Result.Text = c.ToString();*/
            Result.Text = " " +
                Opt.mult(Convert.ToDouble(firestnumber.Text), Convert.ToDouble(secondnumber.Text));
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            /* a = Convert.ToInt32(firestnumber.Text);
             b = Convert.ToInt32(secondnumber.Text);
             c = a - b;
             Result.Text = c.ToString();*/
            Result.Text = " " +
                Opt.sub(Convert.ToDouble(firestnumber.Text), Convert.ToDouble(secondnumber.Text));
        }

        private void division_Click(object sender, EventArgs e)
        {
            /* a = Convert.ToInt32(firestnumber.Text);
             b = Convert.ToInt32(secondnumber.Text);
             c = a / b;
             Result.Text = c.ToString();*/
            Result.Text = " " +
                Opt.div(Convert.ToDouble(firestnumber.Text), Convert.ToDouble(secondnumber.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            firestnumber.Clear();
            secondnumber.Clear();
            Result.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Form2.close();
            
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            /*a = Convert.ToInt32(firestnumber.Text);
            b = Convert.ToInt32(secondnumber.Text);
            c = a + b;
            Result.Text = c.ToString(); */
            Result.Text = " " +
                Opt.add(Convert.ToDouble(firestnumber.Text), Convert.ToDouble(secondnumber.Text));
        }
    }
}
