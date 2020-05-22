using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace questionAnswer
{
    public partial class Form2 : Form
    {
        List<Answer> listAnswer = new List<Answer>();
        Array[] arrays = { };

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var NewQuestion = new Question();
            NewQuestion.TextQuestion = textBox1.Text;
            NewQuestion.ID = arrays.Length + 1;

            var xml = Question.CreateXML(NewQuestion);
            xml.Save("BD");


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            // listAnswer.Add(new Answer() { Text = "", Correct = false , ID = arrays.Length + 1});
            var answer = new Answer();
            answer.Text = textBox2.Text;
            answer.ID = arrays.Length + 1;
            answer.Correct = checkBox1.Checked;

            listBox1.Items.Add(answer);
            Console.WriteLine(answer);
            Console.WriteLine(answer.ID);
            Console.WriteLine(answer.Correct);

            textBox2.Clear();
            checkBox1.Checked = false;

        }
    }
}
