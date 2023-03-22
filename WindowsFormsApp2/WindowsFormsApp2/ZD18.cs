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
    public partial class ZD18 : Form
    {
        public ZD18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        string[] str = new string[3];

        int[] n = new int[3];

        int p = 0;

        int perimetr = 0;

        int pperimetr = 0;

        double s = 0;

        double a = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            str = textBox1.Text.Split(';');

            try
            {
                p = int.Parse(textBox2.Text);

                for (int i = 0; i < 3; i++)
                {
                    n[i] = int.Parse(str[i]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("неверное значение");
            }

            if (n[0]<n[1]+n[2] || n[1] < n[0] + n[2] || n[2]<n[0]+n[1])
            {
                if (p==1)
                {
                    perimetr = n.Sum();

                    listView1.Items.Add("P="+perimetr.ToString());
                }
                else
                {
                    if (p==2)
                    {
                        pperimetr = n.Sum() / 2;

                        s =Math.Round(Math.Sqrt(pperimetr * (pperimetr - n[0]) * (pperimetr - n[1]) * (pperimetr - n[2])),3);

                        listView1.Items.Add("S=" + s.ToString());
                    }
                    else
                    {
                        if (p==3)
                        {
                            a = Class1.koordinata(n[0], n[1]);

                            listView1.Items.Add("угол а=" + a.ToString());
                        }
                        else
                        {
                            listView1.Items.Add("Треугольник");
                        }
                    }
                }
            }
            else
            {
                listView1.Items.Add("Треугольник не удолитворяет оксиоме");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (k <= 48 || k >= 52)
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Введите 3 значения через ;");
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Чтобы удалить выделите число и нажмите на клавишу которой хотите заменить");
        }

        private void ZD18_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("если р = 1 - найти периметр треугольника");
            listView1.Items.Add("если р = 2 - найти площадь треугольника");
            listView1.Items.Add("если р = 3 - найти угол а");
        }
    }
}
