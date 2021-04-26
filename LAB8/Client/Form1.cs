using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Equation client = new Equation();
        int a, b, c;

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
            {
                textBox3.Text = "Заполните все поля";
            }
            else
            {
                a = Int32.Parse(textBox6.Text);
                b = Int32.Parse(textBox5.Text);
                c = Int32.Parse(textBox7.Text);
                textBox4.Text = client.SqrEq(a, b, c);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
       
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                textBox3.Text = "Заполните все поля";
            }
            else
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
                textBox3.Text = client.LinearEq(a, b).ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar >= 33 && e.KeyChar <= 44 || (e.KeyChar>=46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 127) || (e.KeyChar == 22))) e.Handled = true;
            else
                return;
        }
    }
}
