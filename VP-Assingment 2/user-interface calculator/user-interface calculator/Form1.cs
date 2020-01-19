using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace user_interface_calculator
{
    public partial class F1 : Form
    {
        String num1;
        bool k = false;
        string op;
        public F1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e) //for .
        {

            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true ||textBox1.Text=="0")
            {
                textBox1.Text = "";
                k = false;
            }
            if (textBox1.Text == "0" || textBox1.Text == "")
                textBox1.Text = "0.";
            else
                textBox1.Text = textBox1.Text + ".";
             
            
            textBox1.Text = textBox1.Text + ".";

        }
      
    

        private void b1_Click(object sender, EventArgs e) // for 0
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true) // condition main + k bade agr khuch likhna chahiyan to or say phly wali codition check kry gi
            {                                        // k=true is iiya kiya h taky huamry ans k bade jb hum dosri value ka ans chahin to phla wala na ay
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "0"; //this is Known as concatination
        }

        private void button5_Click(object sender, EventArgs e) // for 1
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;   
            }
            textBox1.Text = textBox1.Text + "1"; 
        }

        private void button6_Click(object sender, EventArgs e) // for 2
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e) // for 3
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "3";
        }
    
        private void button10_Click(object sender, EventArgs e) // for 4
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e) // for 5
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e) // for 6
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button15_Click(object sender, EventArgs e) // for 7
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e) // for 8
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button17_Click(object sender, EventArgs e) // for 9
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e) // for =
        {
            switch (op) 
            {
                case "+":
                    {
                        double s = double.Parse(num1) + double.Parse(textBox1.Text);
                        textBox1.Text = s.ToString();
                        k = true;
                        break;
                    }
                case "-":
            {
                double s = double.Parse(num1) + double.Parse(textBox1.Text);
                textBox1.Text = s.ToString();
                k = true;
                break;
            }
                case "*":

                    {
                        double s = double.Parse(num1) + double.Parse(textBox1.Text);
            textBox1.Text = s.ToString();
            k = true;
            break;
                    }
                case "/":
            {
                double s = double.Parse(num1) + double.Parse(textBox1.Text);
                textBox1.Text = s.ToString();
                k = true;
                break;
            }
                  
                           
            
            
            }
        }
    
        private void button4_Click(object sender, EventArgs e) // for +
        {
            op = "+"; 
            num1 = textBox1.Text;
            textBox1.Text = "+";
        }

        private void button9_Click(object sender, EventArgs e) // for -
        {
            op = "-";
            num1 = textBox1.Text;
            textBox1.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e) // for *
        {
            op = "*";
            num1 = textBox1.Text;
            textBox1.Text = "*";
        }

        private void button19_Click(object sender, EventArgs e) // for /
        {
            op = "/";
            num1 = textBox1.Text;
            textBox1.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e) //for AC use to set the value 0
        {
            textBox1.Text="";
        }

        private void button13_Click(object sender, EventArgs e) //for DEL use to clear all the value from textbox
        {
            textBox1.Text="0";
        }

      }
}
