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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        
        public String name;
        public Form fc;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = true;
            //var source = new BindingList<Contact>();
            //foreach (Contact cont in DataClass.getShared().getContacts(name))
            //{
            //    source.Add(cont);
            //}
            ////source.DataSource = DataClass.getShared().getContacts(name);
            //dataGridView1.DataSource = source;

            //var l = DataClass.getShared().getContacts(name);
            //var bindingList = new BindingList<Contact>(l);
            //var source = new BindingSource(bindingList, null);
            if (name == "show_all_yes")
            {
                dataGridView1.DataSource = DataClass.getShared().getAllContacts();                
            }
            else
            {
                dataGridView1.DataSource = DataClass.getShared().getContacts(name);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            fc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
