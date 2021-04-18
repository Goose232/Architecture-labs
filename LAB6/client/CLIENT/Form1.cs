using System;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyService.WebService1Soap client = new MyService.WebService1SoapClient(); //создать объект сервиса для взаимодействия
        private void button1_Click(object sender, EventArgs e) //Проверка рейса по городу
        {
            string pole = textBox1.Text;
            textBox1.Text = client.ShowRoutes();
        }

        private void button2_Click(object sender, EventArgs e) //Проверка рейса по количеству билетов
        {
            string pole = textBox1.Text;
            
        }

        private void button3_Click(object sender, EventArgs e) //Заказ билета
        {
            string pole = textBox2.Text;
            
        }

        private void button4_Click(object sender, EventArgs e) //Показать все маршруты
        {
            label5.Text = client.ShowRoutes();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            string rout_num = textBox1.Text;
            label6.Text = client.ShowSeats(rout_num);
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            string rout = textBox2.Text;
          
            int num = Int32.Parse(textBox3.Text);
            label7.Text = client.buytickets(rout,num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string rout_num = textBox1.Text;
            label6.Text = client.CheckRoutes(rout_num);
        }


        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) {}
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void button5_Click(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
