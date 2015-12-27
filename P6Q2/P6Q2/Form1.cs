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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace P6Q2
{
    public partial class Form1 : Form
    {
        /*
        2. With FileStream, serialize a binary file in directory d:\testbinary.bin with 
           the string “Binary Testing” and integer 5500. Deserialize the binary file 
           d:\testbinary.bin and display the string and integer stored in message box.
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream = new FileStream("D:\\testbinary.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            string s = "Binary Testing";
            int i = 5500;
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, s);
            formatter.Serialize(stream, i);
            stream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream stream = new FileStream("D:\\testbinary.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            //FileStream fs = new FileStream("D:\\testbinary.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            string s = (string)formatter.Deserialize(stream);
            int i = (int)formatter.Deserialize(stream);
            stream.Close();
            MessageBox.Show("string: " + s + "\ni: " + i.ToString() );
            
        }
    }
}
