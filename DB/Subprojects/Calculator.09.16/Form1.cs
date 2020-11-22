using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator._09._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initbarable();
        }
        private int arr;
        public void Initbarable()
        {
            comboBoxOp.Items.Clear();
            comboBoxOp.Items.Add("+");
            comboBoxOp.Items.Add("-");
            comboBoxOp.Items.Add("*");
            comboBoxOp.Items.Add("/");
            comboBoxOp.Items.Add("^");
            comboBoxOp.SelectedIndex = 0;
            arr = -1;
        }

        private void Comboboxcalc_Click(object sender, EventArgs e)
        {
            textBoxComboboxresult.Text = sum(textBoxcomboboxOp1.Text, textBoxcomboboxOp2.Text, comboBoxOp.SelectedIndex);
        }
        private String sum(String a , String b, int arr1)
        {
            int aa = Int32.Parse(a);
            int bb = Int32.Parse(b);
            int c = 0;
            switch (arr1)
            {
                case 0:
                    c = aa + bb;
                    break;
                case 1:
                    c =  aa - bb;
                    break;
                case 2:
                    c = aa * bb;
                    break;
                case 3:
                    float cc = (float)aa / (float)bb;
                    return cc.ToString();
                case 4:
                    double ccc = 1;
                    while (true)
                    {
                        if (bb > 0)
                        {
                            ccc*= aa;
                            bb--;
                        }
                        else if(bb<0)
                        {
                            ccc /= aa;
                            bb++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    return ccc.ToString();
            }
            return c.ToString();
        }

        private void radioButtonplus_CheckedChanged(object sender, EventArgs e)
        {
            arr = 0;
        }

        private void radioButtonminus_CheckedChanged(object sender, EventArgs e)
        {
            arr = 1;
        }

        private void radioButtonmultyple_CheckedChanged(object sender, EventArgs e)
        {
            arr = 2;
        }

        private void radioButtonslice_CheckedChanged(object sender, EventArgs e)
        {
            arr = 3;
        }

        private void buttonRadioCalculate_Click(object sender, EventArgs e)
        {
            if(arr>-1)
            radioresault.Text = sum(textBoxradiobox1.Text, textBoxradiobox2.Text, arr);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            arr = 4;
        }
    }
}
