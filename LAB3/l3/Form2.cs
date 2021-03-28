using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatClient.message = textBox3.Text;
            ChatClient.SendMessage();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ChatClient.ReceiveMessage();
            richTextBox1.Text = ChatClient.message;
        }
    }
}
