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
    public partial class ZD5 : Form
    {
        public ZD5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }   

        string[] str = new string[2];
        int[] n = new int[2];
        int s = 0;
        int p = 0;
        int r = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            str = textBox1.Text.Split(';');

            for (int i = 0; i < 2; i++)
            {
                try
                {
                    n[i] = int.Parse(str[i]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверное значение");
                    break;
                }

            }
            if (n[0]!=n[1])
            {
                s = n[0] + n[1];
                p = n[0] * n[1];

                listView1.Items.Add(n[0].ToString() + "+" + n[1].ToString() + "=" + s.ToString() + "\r\n");
                listView1.Items.Add(n[0].ToString() + "*" + n[1].ToString() + "=" + p.ToString() + "\r\n");
                if (p > s)
                {
                    r = p - s;
                    listView1.Items.Add("Произведение больше суммы на "+ r.ToString() + "\r\n");
                }
            }
        }
    }
}
