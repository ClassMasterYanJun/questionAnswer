using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questionAnswer
{
    public partial class Form1 : Form
    {
        List<Answer> listAnswer = new List<Answer>();

        public Form1()
        {
            InitializeComponent();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var question = (id: 0, text: "Зимой и летом одним цветом");
            
            textBox1.Text = question.text;
            
            

            if (question.id == 0 ) {

                listAnswer.Add(new Answer() { Text = "Елка", Correct = true });
                listAnswer.Add(new Answer() { Text = "Солнце", Correct = false });
                listAnswer.Add(new Answer() { Text = "Вода", Correct = false });
                listAnswer.Add(new Answer() { Text = "Поталок", Correct = false });

            }
            else
            {
                listAnswer.Add(new Answer() { Text = "Ответов еще нет", Correct = false });
            }

            

            foreach (Answer answer in listAnswer)
            {

                checkedListBox1.Items.Add(answer);
               

            };
                
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                
            if (listAnswer[e.Index].Correct)
            {

            }
            else
            {

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }
    }
}
