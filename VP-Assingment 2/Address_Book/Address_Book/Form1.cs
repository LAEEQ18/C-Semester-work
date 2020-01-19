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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void f2_FormClosed(object sender, EventArgs e)
        {
            //  throw new NotImplementedException;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (DataClass.getShared().hasContact(textBox1.Text))
            {
                var rf = new ResultForm();
                rf.name = textBox1.Text;
                rf.fc = this;
                rf.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Contact with Name:" + textBox1.Text.ToString() + " Found.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var rf = new ResultForm();
            rf.name = "show_all_yes";
            rf.fc = this;
            rf.ShowDialog();
        }

    }
}
