using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class ZD27 : Form
    {
        public ZD27()
        {
            InitializeComponent();
        }

        private void textBox4_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox4, "Введите целые числа через пробел");
        }

        string pathF = "f.txt";

        string pathG = "g.txt";

        string pathH = "h.txt";

        private void button3_Click(object sender, EventArgs e)
        {

            using (StreamWriter wr =new StreamWriter(pathF, false))
            {
               wr.WriteLineAsync(textBox4.Text);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;

            if (!Char.IsDigit(k) && k!=';' && k!='-' && k!=8)
            {
                e.Handled = true;
            }
        }

        string[] str;

        int[] value;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            str = textBox4.Text.Split(';');
           
            using (StreamReader r =new StreamReader(pathF))
            {
                textBox1.Text = r.ReadLine();
            }

            value = new int[str.Length];

            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    value[i] = Convert.ToInt32(str[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Между двумя числами должно быть ;");
                return;
            }

            int number = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 0)
                {
                    number = value[i];
                    textBox2.Text += number.ToString() + " ";
                }
                else
                {
                    number = value[i];
                    textBox3.Text += number.ToString() + " ";
                }
            }

            using (StreamWriter wr = new StreamWriter(pathG, false))
            {
                wr.WriteLineAsync(textBox2.Text);
            }

            using (StreamWriter wr = new StreamWriter(pathH, false))
            {
                wr.WriteLineAsync(textBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
