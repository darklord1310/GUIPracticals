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
    public partial class CalculatorMenu : Form
    {
        int selection;


        public CalculatorMenu()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "This is the standard calculator which will provide the minimal calculation operations. \nThe operations available are addition, subtraction, division and multiplication";
            selection = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch(selection)
            {
                case 5: this.Hide();
                        Date_Calculator m = new Date_Calculator();
                        m.ShowDialog();
                        break;
                case 4:
                        this.Hide();
                        Unit_Converter n = new Unit_Converter();
                        n.ShowDialog();
                        break;
                case 3:
                        this.Hide();
                        ProgrammerCalculator a = new ProgrammerCalculator();
                        a.ShowDialog();
                        break;
                case 2:
                        this.Hide();
                        Form1 b = new Form1();
                        b.ShowDialog();
                        break;
                case 1:
                        this.Hide();
                        StandardCalculator c = new StandardCalculator();
                        c.ShowDialog();
                        break;

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDescription.Text = "This is the scientific calculator which will provide advanced calculation operations. \nThe operations available are matrix and trigonometry";
            selection = 2;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDescription.Text = "This is the calculator which suits programmer the most. \nThe operations available are bits shifting, base conversion and calculations";
            selection = 3;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDescription.Text = "Various unit conversion available here. For example, length, angle, distance etc";
            selection = 4;
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDescription.Text = "Date calculator is used to calculate the difference in days/weeks/year between 2 dates";
            selection = 5;
        }
    }
}
