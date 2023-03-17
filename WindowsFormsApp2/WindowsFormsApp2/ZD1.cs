using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ZD1 : Form
    {
        public ZD1()
        {
            InitializeComponent();
        }

        string[] str = new string[3];
        double[] n = new double[3];
        double d = 0;
        double x1 = 0;
        double x2 = 0;
        


        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            str = textBox1.Text.Split(';');

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    n[i] = double.Parse(str[i]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверное значение");

                }
               
            }
            d = Math.Round(n[1] * n[1] - 4 * n[0] * n[2],3);

            if (d<0)
            {
                listView1.Items.Add(n[0].ToString() + "x2+" + n[1].ToString() + "x+" + n[2].ToString() + "=0" + "\r\n");

                listView1.Items.Add("d=" + d.ToString() + "\r\n");

                listView1.Items.Add("d<0, невозможно найти корни" + "\r\n");

            }
            else
            {
                x1 =Math.Round( 0 - n[1] + Math.Sqrt(d) / 2 * n[0],3);

                x2 =Math.Round(0 - n[1] - Math.Sqrt(d) / 2 * n[0],3);

                listView1.Items.Add(n[0].ToString() + "x2+" + n[1].ToString() + "x+" + n[2].ToString() + "=0" + "\r\n");

                listView1.Items.Add("d=" + d.ToString() + "\r\n");

                listView1.Items.Add("x1=" + x1.ToString() + "\r\n");

                listView1.Items.Add("x2=" + x2.ToString() + "\r\n");

                textBox1.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
