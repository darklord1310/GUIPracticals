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
    public partial class Payment : Form
    {
        double total;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(string receipt, double total)
        {
            InitializeComponent();
            textBox2.Text = receipt;
            this.total = total;
            textBox4.Text = total.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                    if (textBox1.Text == "")
                        throw new MyException("EmptyInput");
                    else if (Convert.ToDouble(textBox1.Text) < this.total)
                        throw new MyException("NotEnough");
                    else
                   {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - this.total);
                    MessageBox.Show("Thank you! Your order will be deliver soon!");
                    this.Hide();
                    MainMenu m = new MainMenu();
                    m.ShowDialog();
                    }
            }
            catch(MyException ex)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is not made, all the pizza(s) ordered will be cancel");
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                else if (s == "ZeroQuantity")
                    MessageBox.Show("Pizza quantity cannot be zero!");
                else if (s == "EmptyInput")
                    MessageBox.Show("Pay Amount cannot be empty!");
                else if (s == "NotEnough")
                    MessageBox.Show("Pay Amount is not enough!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Card"))
            {
                textBox1.ReadOnly = true;
                textBox1.Text = Convert.ToString(this.total);
                textBox3.Text = "0";
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox1.Text = "";
                textBox3.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
