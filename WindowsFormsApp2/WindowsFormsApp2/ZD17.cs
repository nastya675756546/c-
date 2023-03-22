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
    public partial class ZD17 : Form
    {
        public ZD17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        string[] t1 = new string[2];

        int[] n1 = new int[2];

        string[] t2 = new string[2];

        int[] n2 = new int[2];

        string[] t3 = new string[2];

        int[] n3 = new int[2];

        double min = 0;

        double n10 = 0;

        double n20 = 0;

        double n30 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
           
            t1 = textBox1.Text.Split(';');

            t2 = textBox2.Text.Split(';');

            t3 = textBox3.Text.Split(';');

            if (t1.Length!=2 || t2.Length != 2 || t3.Length != 2)
            {
                MessageBox.Show("неверное значение");
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    n1[i] = int.Parse(t1[i]);
                }

                for (int i = 0; i < 2; i++)
                {
                    n2[i] = int.Parse(t2[i]);
                }

                for (int i = 0; i < 2; i++)
                {
                    n3[i] = int.Parse(t3[i]);
                }

                n10 = Class1.koordinata(n1[0], n1[1]);

                n20 = Class1.koordinata(n2[0], n2[1]);

                n30 = Class1.koordinata(n3[0], n3[1]);

                min = Math.Min(n10, Math.Min(n20,n30));


                listView1.Items.Add("Угол между осью абсцисс и лучом,");

                listView1.Items.Add("соединяющим начало координат с точкой");


               listView1.Items.Add("X(x1,x2)=" + n10.ToString());

                listView1.Items.Add("Y(y1,y2)=" + n20.ToString());

                listView1.Items.Add("Z(z1,z2)=" + n30.ToString());

                listView1.Items.Add("Минимальный угол="+min.ToString());
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != 8 && k != 59)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != 8 && k != 59)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != 8 && k != 59)
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Введите два значения через ;");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox2, "Введите два значения через ;");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(textBox3, "Введите два значения через ;");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listView1.Clear();
        }
    }
}
