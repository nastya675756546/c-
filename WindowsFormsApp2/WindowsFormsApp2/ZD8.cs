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
    public partial class ZD8 : Form
    {
        public ZD8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        int n = 0;
        int f = 0;
        int i = 0;
        int a = 0;
        int b = 0;
        Random r = new Random();
        int a0 = 0;
        int b0 = 0;
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            while (i==0)
            {

                try
                {
                    n = int.Parse(textBox1.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Неверное значение");

                    break;
                }

                f = 1;

                if (n > 0)
                {
                    for (int i = 2; i < n+1; i++)
                    {
                        f*=i;
 
                    }
                    listView1.Items.Add("f(" + n.ToString() + ")=" + f.ToString() + "\r\n");
                }
                else
                {
                    if (n == 0)
                    {
                        f = 1;

                        listView1.Items.Add("f(" + n.ToString() + ")=" + f.ToString() + "\r\n");
                    }
                    else
                    {
                        listView1.Items.Add("b < 0"+"\r\n");
                    }
                }

                i++;

            }

            i = 0;

            a = r.Next(1, 10);

            b = r.Next(1, 10);

            a0 = 1;

            b0 = 1;

            for (int i = 2; i < a + 1; i++)
            {
                a0 *= i;

            }

            for (int i = 2; i < b + 1; i++)
            {
                b0 *= i;

            }

            sum = a0 + b0;

            listView1.Items.Add("a!=" + a.ToString() + "!=" + a0.ToString() + "\r\n");

            listView1.Items.Add("b!=" + b.ToString() + "!=" + b0.ToString() + "\r\n");

            listView1.Items.Add("a!+b!=" + sum.ToString() + "\r\n");

            
        }
    }
}
