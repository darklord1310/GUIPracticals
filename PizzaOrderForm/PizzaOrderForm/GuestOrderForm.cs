using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    public partial class GuestOrderForm : Form
    {
        public GuestOrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                int v;
                if (text1 == "" || text2 == "" || text3 == "" || text4 == "" || text5 == "" || text6 == "" || text7 == "")
                    throw new MyException("EmptyInput");
                else if (!Int32.TryParse(text2, out v))
                    throw new MyException("WrongFormat", "IC");
                else if (!Int32.TryParse(text5, out v))
                    throw new MyException("WrongFormat", "Zip Code");
                else if (!Int32.TryParse(text7, out v))
                    throw new MyException("WrongFormat", "Phone Number");
                else
                {
                    this.Hide();
                    PizzaOrderForm m = new PizzaOrderForm();
                    m.ShowDialog();
                }
            }
            catch (MyException ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "TooLarge")
                    MessageBox.Show("Please enter a value smaller than 100!");
                else if (s == "LessThanZero")
                    MessageBox.Show("Please enter a positive quantity!");
                else if (s == "EmptyInput")
                    MessageBox.Show("Please fill up the blank(s)!");
            }

            public MyException(string e, string s)
            {
                MessageBox.Show(s + " are in wrong format");
            }
        }


    }
}
