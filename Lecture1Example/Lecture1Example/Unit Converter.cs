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
    public partial class Unit_Converter : Form
    {
        public Unit_Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorMenu n = new CalculatorMenu();
            n.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Km to m":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1000);
                    break;
                case "m to Km":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 1000);
                    break;
                case "mL to L":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 1000);
                    break;
                case "L to mL":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1000);
                    break;
                case "Newton to Kg:":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 10);
                    break;
                case "Kg to Newton":
                    textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 10);
                    break;

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
