using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BudgetApp
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double Cost1 =0.00;

            double Total = 0; //total expenditure;


            var Income = textBox3.Text;
            string type = " ";
           var Expend= textBox1.Text;
            var Cost1 = textBox2.Text;

           

            if (textBox3.Text ==" "||textBox1.Text==" "||textBox2.Text==" ")
            {
                MessageBox.Show("Please enter all required inputs");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    type = radioButton1.Text;
                }

                if (radioButton2.Checked)
                {
                    type = radioButton2.Text;
                }

                if (radioButton3.Checked)
                {
                    type = radioButton3.Text;
                }

                if (radioButton4.Checked)
                {
                    type = radioButton4.Text;
                }
                   var spent = 0;
                //spent= textBox3.Text-textBox2.Text;
                MessageBox.Show($"You spent {Cost1} on {Expend} and its a {type}");
                //MessageBox.Show($"Your money is currently ");
            }


           
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye, Thank you for supprting the Budget App");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var amtMade = double.Parse(textBox3.Text);
            var costR = double.Parse(textBox2.Text);
            var amtLeft = amtMade - costR;

            richTextBox1.Text = "Income            Expense                      total Amount Left                                ";
            richTextBox2.Text = textBox3.Text  +"             "+ textBox1.Text+"                             R"+ amtLeft;

            using (SaveFileDialog sdf=new SaveFileDialog() {Filter="Excel BudgetBook |*.xlsx"  })
            {

            }
        }
    }
}
