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
    public partial class ZD7 : Form
    {
        public ZD7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Program.f1.Show();
            this.Hide();
            
        }

        int b = 0;
        int[] n;
        Random r = new Random();
        int sum = 0;
        string str = "";

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            try
            {
                b = int.Parse(textBox1.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Неверное значение");

            }

            if (b > 0)
            {
                n = new int[b];

                for (int i = 0; i < b; i++)
                {
                    n[i] = r.Next(-100, 100);

                    str += Convert.ToString(n[i])+" ";
                   
                }

                listView1.Items.Add(str+ "\r\n");

                sum = n.Sum();

                listView1.Items.Add("Сумма элементов:" + sum.ToString());
            }
            else
            {
                listView1.Items.Add("b < 0");
            }
           
        }
    }
}
