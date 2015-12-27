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

namespace P4Q1
{
    public partial class Form1 : Form
    {
        ArduinoUsbDevice digispark = new ArduinoUsbDevice();

        public Form1()
        {
            InitializeComponent();
        }

        public class MyException : Exception
        {
            public MyException(string s)
            {
                if (s == "LargerThan7")
                    MessageBox.Show("Enter a number smaller than 7");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) > 7)
                    throw new MyException("LargerThan7");
                else
                {
                    digispark.WriteByte(200);
                    string binary = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
                    digispark.WriteByte((byte)255);

                    for (int i = 0; i < binary.Length; i++)
                    {
                       char b = binary[i];
                       if (b == '1')
                       {
                          byte data = (byte)(binary.Length - i - 1);
                          digispark.WriteByte(data);
                        }
                     }
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MyException ex)
            {

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
