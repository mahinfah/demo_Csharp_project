using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace main_project
{
    public partial class calculator : Form
    {
        private int num1, num2,result;
       private double num11, num12,result2;
        public int c = 0;
        private char opt;
        public calculator()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            opt = '-';
            num1 = Convert.ToInt32(richTextBox1.Text);
            label1.Text = num1 + "-";
            richTextBox1.Text = "";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            num2=Convert.ToInt32(richTextBox1.Text);
            if(opt=='+')
            {
                result= num1 + num2;
                richTextBox1.Text = result.ToString();
                label1.Text = num1.ToString() + opt.ToString() + num2.ToString();
            }
            else if(opt=='-')
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
                label1.Text = num1.ToString() + opt.ToString() + num2.ToString();

            }

            else if (opt == '*')
            {
                result = num1* num2;
                richTextBox1.Text = result.ToString();
                label1.Text = num1.ToString() + opt.ToString() + num2.ToString();

            }
           
             else if (opt == '/')
            {
               
                double result2 = (double)num1 / num2;
                richTextBox1.Text = result2.ToString();
                label1.Text = num1.ToString() + opt.ToString() + num2.ToString();

            }
            else if (opt == '%')
            {
                result = num1 % num2;
                richTextBox1.Text = result.ToString();
                label1.Text = num1.ToString() + opt.ToString() + num2.ToString();

            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text  = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            c++;
            richTextBox1.Text = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opt = '*';
            num1 = Convert.ToInt32(richTextBox1.Text);
            label1.Text = num1 + "*";


        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            opt = '/';
            num1 = Convert.ToInt32(richTextBox1.Text);
            label1.Text = num1 + "/";
            richTextBox1.Text = "";
        }

        private void Remind_Click(object sender, EventArgs e)
        {
            opt = '%';
            num1 = Convert.ToInt32(richTextBox1.Text);
            label1.Text = num1 + "%";
            richTextBox1.Text = "";

        }

        private void btplus_Click(object sender, EventArgs e)
        {
            opt = '+';
            num1=Convert.ToInt32(richTextBox1.Text);
            label1.Text = num1+"+";
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

    }
}
