using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1Example
{
    public partial class StandardCalculator : Form
    {
        double firstTerm = 0;
        double secondTerm = 0;
        double intermediateValue = 0;
        string operators = "";

        public StandardCalculator()
        {
            InitializeComponent();
        }

        private void StandardCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorMenu n = new CalculatorMenu();
            n.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // /
            try
            {
                if (textBox1.Text == "")
                    throw new MyException("EmptyInput");
                else
                {
                    determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
                    operators = "/";
                    textBox1.Text = "";
                }
            }
            catch( MyException ex)
            {

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //*
            try
            {
                if (textBox1.Text == "")
                    throw new MyException("EmptyInput");
                else
                {
                    determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
                    operators = "*";
                    textBox1.Text = "";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //-    
            try
            {
                if (textBox1.Text == "")
                    throw new MyException("EmptyInput");
                else
                {
                    determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
                    operators = "-";
                    textBox1.Text = "";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //+            
            try
            {
                if (textBox1.Text == "")
                    throw new MyException("EmptyInput");
                else
                {
                    determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
                    operators = "+";
                    textBox1.Text = "";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //clr
            textBox1.Text = "";
            firstTerm = 0;
            secondTerm = 0;
            intermediateValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //=
            determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
            operators = "";
            textBox1.Text = "";
            textBox1.Text = intermediateValue.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void determineV1andV2andDoOperation(double value)
        {
            if (operators.Equals(""))
                firstTerm = value;
            else
            {
                secondTerm = value;
                switch (operators)
                {
                    case "+":
                        intermediateValue = firstTerm + secondTerm;
                        firstTerm = intermediateValue;
                        break;
                    case "-":
                        intermediateValue = firstTerm - secondTerm;
                        firstTerm = intermediateValue;
                        break;
                    case "*":
                        intermediateValue = firstTerm * secondTerm;
                        firstTerm = intermediateValue;
                        break;
                    case "/":
                        try {
                            if (secondTerm == 0)
                                throw new MyException("DivideByZero");
                            intermediateValue = firstTerm / secondTerm;
                            firstTerm = intermediateValue;
                        }
                        catch(MyException ex)
                        { }
                        break;
                }
            }
         }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "DivideByZero")
                    MessageBox.Show("Cannot be divide by zero");
                else if (s == "EmptyInput")
                    MessageBox.Show("Please fill up the blank(s)!");
            }

        }

    }
}
