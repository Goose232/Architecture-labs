using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace l3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

            Thread x = new Thread(Msd);
            x.Start();
        }

        private void Msd()
        {
            
            while (true)
            {

                ChatClient.ReceiveMessage();


                richTextBox1.AppendText(ChatClient.message + Environment.NewLine);
               
            }

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
            if (ChatClient.message!="")
            ChatClient.SendMessage();
            richTextBox1.Text += "Вы: "+ChatClient.message + Environment.NewLine;
            textBox3.Clear();
                            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
         
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = ChatClient.message;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            ChatClient.Disconnect();
            Application.Exit();
        }
    }
}
