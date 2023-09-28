using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        String pheptinh;

        private void button14_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2=data1 + float.Parse(txthienthi2.Text);
                txthienthi2.Text=data1.ToString()+ "+"+float.Parse(txthienthi2.Text)+"=";
                txthienthi1.Text=data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(txthienthi2.Text);
                txthienthi2.Text = data1.ToString() + "-" + float.Parse(txthienthi2.Text) + "=";
                txthienthi1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(txthienthi2.Text);
                txthienthi2.Text = data1.ToString() + "*" + float.Parse(txthienthi2.Text) + "=";
                txthienthi1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(txthienthi2.Text) == 0)
                {
                    txthienthi2.Text = data1.ToString() + "/" ;
                    txthienthi1.Text = "khong chia duoc";
                }
                else
                {
                    data2 = data1 / float.Parse(txthienthi2.Text);
                    txthienthi2.Text = data1.ToString() + "/" + float.Parse(txthienthi2.Text) + "=";
                    txthienthi1.Text = data2.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txthienthi2.Text = txthienthi2.Text + ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1=float.Parse(txthienthi2.Text);
            txthienthi2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(txthienthi2.Text);
            txthienthi2.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            data1 = float.Parse(txthienthi2.Text);
            txthienthi2.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(txthienthi2.Text);
            txthienthi1.Clear();
        }

        private void txthienthi1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            char[] str_c=txthienthi2.Text.ToCharArray();
            str_c[str_c.Length-1] = ' ';
            txthienthi2.Text = "";
            foreach(char c in str_c)
            {
                txthienthi2.Text += Convert.ToString(c);
            }
            txthienthi2.Text = txthienthi2.Text.Replace(" ", "");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            txthienthi2.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txthienthi2.Clear();
            txthienthi1.Clear();
        }
    }
}
