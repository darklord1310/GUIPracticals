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
    public partial class Form1 : Form
    {
        int checking;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Aqua;
            this.Text = "Scientific Calculator";
            //this.Size = new Size(350, 350);
            this.Location = new Point(300, 300);
            this.MaximizeBox = false;
            this.BackgroundImage = Image.FromFile("Penguins.jpg");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorMenu c = new CalculatorMenu();
            c.ShowDialog();
        }
    }
}
