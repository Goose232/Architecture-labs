using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.CalculatorSoap SoapClient = new ServiceReference1.CalculatorSoapClient(); // создаем экземпляр созданного прокси-объекта
        // теперь можем пользоваться функциями веб-сервиса:
        private void button1_Click(object sender, EventArgs e) //сложение
        {
            textBox1.Text = SoapClient.Add(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString(); 
        }

        private void button3_Click(object sender, EventArgs e) // вычитание
        {
            textBox1.Text = SoapClient.Subtract(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e) // умножение
        {
            textBox1.Text = SoapClient.Multiply(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e) // деление
        {
            textBox1.Text = SoapClient.Divide(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)  // запрет на ввод букв для первого числа
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        } 
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) // запрет на ввод букв для второго числа
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
