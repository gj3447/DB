using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_binary_read_click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));
            int itemp = br.ReadInt32();
            string stemp = br.ReadString();
            Console.WriteLine("DATA" + itemp + "/" + stemp);
            br.Close();
        }

        private void button_binary_write_click(object sender, EventArgs e)
        {

            long someValue = 0x123456789ABCDEF0;
            //long someValue = 123456789;
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            bw.Write(1234);
            bw.Write("HelloWorld");
            bw.Close();
        }

        private void buttonstreamwright_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("c.txt", FileMode.Create));
            sw.Write(int.MaxValue);
            sw.Write("GoodMorning");
            sw.Write(uint.MaxValue);
            sw.Write("안녕하세요");
            sw.Write(double.MaxValue);
            sw.Close();
        }

        private void buttonstreamread_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("c.txt", FileMode.Open));
            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
