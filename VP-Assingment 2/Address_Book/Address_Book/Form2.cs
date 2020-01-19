using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear() {
            nameTB.Clear();
            age.Value = 0;
            emailTB.Clear();
            phoneTB.Clear();
            addressTB.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClass.getShared().addContact(nameTB.Text, Convert.ToInt32(age.Value), emailTB.Text, phoneTB.Text, addressTB.Text, radioButton1.Checked);
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
