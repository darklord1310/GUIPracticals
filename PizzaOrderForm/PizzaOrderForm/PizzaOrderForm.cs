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
    public partial class PizzaOrderForm : Form
    {
        string preserveReceipt = "";
        double grandTotal;

        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        public PizzaOrderForm(string receipt, double Total)
        {
            InitializeComponent();
            preserveReceipt = receipt;
            grandTotal = Total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PizzaOrderForm m = new PizzaOrderForm();
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string size;

            if (radioButton6.Checked)
                size = "small";
            else if (radioButton5.Checked)
                size = "regular";
            else
                size = "extra large";

            this.Hide();
            Step_2 m = new Step_2( comboBox1.SelectedItem.ToString() ,size, preserveReceipt, grandTotal);
            m.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
