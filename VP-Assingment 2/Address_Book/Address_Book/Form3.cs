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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DataClass.getShared().hasContact(textBox1.Text))
            {
                DialogResult dr = MessageBox.Show("Contact with Name: " + textBox1.Text.ToString() + "\nWill be Deleted. Are you sure you want to Delete it?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataClass.getShared().deleteContact(textBox1.Text);
                    MessageBox.Show("Record Successfully Deleted!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Contact with Name:" + textBox1.Text.ToString() + " Found.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
