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
    public partial class Step_2 : Form
    {
        List<PizzaOrder> pizzaList = new List<PizzaOrder>();
        string pizzaname, pizzasize;
        string receipt;
        double grandTotal;

        public class PizzaOrder
        {
            string name;
            string size;
            int quantity;
            int numberOfTopping;

            public PizzaOrder()
            {

            }

            public PizzaOrder(string pizzaName, string pizzaSize, int quantity, int topping)
            {
                name = pizzaName;
                size = pizzaSize;
                this.quantity = quantity;
                numberOfTopping = topping;
            }

            public double calculatePrice()
            {
                switch (size)
                {
                    case "small": return (9.9 * quantity + numberOfTopping*0.5);
                    case "regular": return (15.9 * quantity + numberOfTopping * 0.5);
                    default: return (25.9 * quantity + numberOfTopping * 0.5);
                }
            }

            public string showOrder()
            {
                return ("\nPizza : " + name + "\nSize: " + size + "\nAmount: " + quantity + "\nTotal: " + calculatePrice() + "\n" );
            }

        }

        public Step_2(string name, string size, string receipt, double grandTotal)
        {
            InitializeComponent();
            pizzaname = name;
            pizzasize = size;
            this.receipt = receipt;
            this.grandTotal = grandTotal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PizzaOrderForm m = new PizzaOrderForm(receipt, grandTotal);
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment m = new Payment(receipt,grandTotal);
            m.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox1.Text);
                if (quantity > 10 && quantity > 0)
                    throw new MyException("TooLarge");
                else if (quantity == 0)
                    throw new MyException("ZeroQuantity");
                else if (quantity < 0)
                    throw new MyException("LessThanZero");
                else
                {
                    int topping = 0;
                    if (checkBox1.Checked)
                        topping++;
                    if(checkBox2.Checked)
                        topping++;
                    if (checkBox3.Checked)
                        topping++;
                    if (checkBox4.Checked)
                        topping++;
                    if (checkBox5.Checked)
                        topping++;
                    if (checkBox6.Checked)
                        topping++;

                    int amount  = Convert.ToInt16(textBox1.Text);
                    PizzaOrder pizza = new PizzaOrder(pizzaname,pizzasize,amount, topping );
                    this.receipt += "======================\n";
                    this.receipt += pizza.showOrder();
                    grandTotal += pizza.calculatePrice();
                    MessageBox.Show("Added to cart successfully!");
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid number for quantity!");
            }
            catch( OverflowException ex)
            {
                MessageBox.Show("Buffer overflow!");
            }
            catch(MyException ex)
            {
             
            }

        }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "TooLarge")
                    MessageBox.Show("Please enter a value smaller than 100!");
                else if (s == "LessThanZero")
                    MessageBox.Show("Please enter a positive quantity!");
                else if(s == "ZeroQuantity")
                    MessageBox.Show("Pizza quantity cannot be zero!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pizza order canceled");
        }
    }
}
