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
    public partial class ProgrammerCalculator : Form
    {
        double firstTerm = 0;
        double secondTerm = 0;
        double intermediateValue = 0;
        string operators = "";

        public ProgrammerCalculator()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorMenu n = new CalculatorMenu();
            n.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "6";
                }
            }
            catch(MyException ex)
            {
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //4
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "4";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //5
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "5";
                }
            }
            catch (MyException ex)
            {
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "7";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //8
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else
                {
                    textBox1.Text += "8";
                }
            }
            catch (MyException ex)
            {
                
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //9
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else
                {
                    textBox1.Text += "9";
                }
            }
            catch (MyException ex)
            {
               
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //F
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "F";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //E
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "E";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //D
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "D";

                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //C
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "C";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //B
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "B";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //A
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else if (radioButton2.Checked)
                    throw new MyException("NotOcta");
                else if (radioButton4.Checked)
                    throw new MyException("NotBase10");
                else
                {
                    textBox1.Text += "A";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //3
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "3";
                }
            }
            catch (MyException ex)
            {
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "NotBinary")
                    MessageBox.Show("Please enter only 1 or 0");
                else if (s == "NotOcta")
                    MessageBox.Show("Please enter a number smaller than 8");
                else if(s == "DivideByZero")
                    MessageBox.Show("Cannot be divide by zero");
                else if (s == "NotHex")
                    MessageBox.Show("Please enter a valid hex number!");
                else if (s == "EmptyInput")
                    MessageBox.Show("Please fill up the blank(s)!");
                else if(s == "NotBase10")
                    MessageBox.Show("Please enter a number smaller than 10");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //1
            textBox1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //2
            try
            {
                if (radioButton1.Checked)
                    throw new MyException("NotBinary");
                else
                {
                    textBox1.Text += "2";
                }
            }
            catch (MyException ex)
            {
                
            }  
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstTerm = 0;
            secondTerm = 0;
            intermediateValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
            catch (MyException ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //^
            try
            {
                if (textBox1.Text == "")
                    throw new MyException("EmptyInput");
                else
                {
                    determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
                    operators = "^";
                    textBox1.Text = "";
                }
            }
            catch (MyException ex)
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //=
            determineV1andV2andDoOperation(Convert.ToDouble(textBox1.Text));
            operators = "";
            textBox1.Text = "";
            textBox1.Text = intermediateValue.ToString();
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
                        try
                        {
                            if (secondTerm == 0)
                                throw new MyException("DivideByZero");
                            intermediateValue = firstTerm / secondTerm;
                            firstTerm = intermediateValue;
                        }
                        catch (MyException ex)
                        { }
                        break;
                    case "^":
                        intermediateValue = Math.Pow(firstTerm, secondTerm);
                        firstTerm = intermediateValue;
                        break;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
