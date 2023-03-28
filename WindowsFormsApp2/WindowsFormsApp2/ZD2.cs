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
    public partial class ZD2 : Form
    {
        public ZD2()
        {
            InitializeComponent();
        }

        int x = 0;

        int y = 0;

        int n = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            try
            {
                x = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Неверное значение");
            }

            if (x > n || y==x || x <= n)
            {
                y = x * x;
            }
            else
            {
                MessageBox.Show("Не выполнено условие");
            }

            textBox2.Text = y.ToString();

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void ZD2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
