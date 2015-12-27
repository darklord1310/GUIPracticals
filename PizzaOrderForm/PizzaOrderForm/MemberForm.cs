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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    throw new MyException("EmptyInput");

                for (int i = 0; i < textBox1.TextLength; i++) 
                {
                    
                    //if( textBox1.Text.ElementAt<char>(i) )
                }
                    

                this.Hide();
                PizzaOrderForm m = new PizzaOrderForm();
                m.ShowDialog();
            }
            catch(MyException ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "EmptyInput")
                    MessageBox.Show("Please fill up all the blank!");
                else if (s == "InvalidChar")
                    MessageBox.Show("Input contain invalid character!");
            }
        }
    }
}
