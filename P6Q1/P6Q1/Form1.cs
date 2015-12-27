using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P6Q1
{
    public partial class Form1 : Form
    {
        /*
        1. With FileStream, create a text file in directory d:\testing.txt with the string “Hello World123!”.
           Append the text file in directory d:\testing.txt with the string “Good Morning!”
           */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Hello World123!";
            File.WriteAllText("D:\\testing.txt", s);
            //F.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           File.AppendAllText("D:\\testing.txt", "Good Morning!");
        }
    }
}
