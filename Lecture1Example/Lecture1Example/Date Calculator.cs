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
    public partial class Date_Calculator : Form
    {
        public Date_Calculator()
        {
            InitializeComponent();
        }

        private void Date_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorMenu n = new CalculatorMenu();
            n.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            //TimeSpan span = d2.Subtract(d1);
            int a = (int)Math.Abs( (d1 - d2).TotalDays );
            //textBox1.Text = comboBox1.SelectedItem;
            
            if (comboBox1.SelectedItem.Equals("in days") )
                textBox1.Text = a.ToString();
            else if(comboBox1.SelectedItem.Equals("in weeks"))
            {
                a = a / 7;
                textBox1.Text = a.ToString();
            }
            else
            {
                a = a / 365;
                textBox1.Text = a.ToString();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public class MyException : Exception
        {
            public MyException(string s)
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
