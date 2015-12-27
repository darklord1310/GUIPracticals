using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiSparkDotNet;


namespace P4Q2
{

    public partial class Form1 : Form
    {
        ArduinoUsbDevice digispark = new ArduinoUsbDevice();
        byte[] value;
        double number = 0;
        int counter = 0;
        int power = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            digispark.WriteByte(1);

            while (counter < 3)
            {
                if (digispark.ReadByte(out value))
                {
                    Console.WriteLine(Encoding.Default.GetString(value));
                    number += Math.Pow(Convert.ToInt16(value), power);
                }
                power--;
                counter++;
            }

            textBox1.Text = Convert.ToString(number);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
