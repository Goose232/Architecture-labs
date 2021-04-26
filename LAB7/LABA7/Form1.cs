using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace LAB7
{
    public partial class Form1 : Form
    {
        public static void process(Word.Paragraph str)
        {
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            str.Range.Font.Name = "Times New Roman"; 
            str.Range.Font.Size = 14; 
            str.Range.Paragraphs.Space1(); 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application myword = new Word.Application(); //Создаем объект объекта
            myword.Visible = true;
            Word.Document objdoc = myword.Documents.Add();
            Word.Paragraph str;
            str = objdoc.Paragraphs.Add();
            str.Range.Text = "МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ" +
                "   РОССИЙСКОЙ ФЕДЕРАЦИИ";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            str.Range.Text = "ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ" +
                " «ОРЛОВСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            str.Range.Text = " ИМЕНИ И.С. ТУРГЕНЕВА»";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            string mctext = textBox1.Text;
            str.Range.Text = $"\nКафедра {mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            str.Range.Text = "\n\n\nОТЧЕТ";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Range.Bold = 2;
            str = objdoc.Paragraphs.Add();
            mctext = textBox2.Text;
            str.Range.Text = $"По лабораторной работе №{mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            mctext = textBox3.Text;
            str.Range.Text = $"на тему: «{mctext}»";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            mctext = textBox4.Text;
            str.Range.Text = $"по дисциплине: «{mctext}»";
            str = objdoc.Paragraphs.Add();
            process(str);
            str = objdoc.Paragraphs.Add();
            mctext = textBox8.Text;
            str.Range.Text = $"\n\n\n\nВыполнил(а/и): {mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            str = objdoc.Paragraphs.Add();
            str.Range.Text = "Институт приборостроения, автоматизации и информационных технологий" +
                " Направление: 09.03.04 «Программная инженерия»";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            str = objdoc.Paragraphs.Add();
            mctext = textBox7.Text;
            str.Range.Text = $"Группа: {mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            mctext = textBox5.Text;
            str = objdoc.Paragraphs.Add();
            str.Range.Text = $"Проверил: {mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            str = objdoc.Paragraphs.Add();
            mctext = textBox6.Text;
            str.Range.Text = $"\nОтметка о зачете:                                    Дата: «____» __________ {mctext} г.";
            str = objdoc.Paragraphs.Add();
            process(str);
            str.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            str = objdoc.Paragraphs.Add();
            str.Range.Text = $"\n\n\n\n\nОрел, {mctext}";
            str = objdoc.Paragraphs.Add();
            process(str);
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
