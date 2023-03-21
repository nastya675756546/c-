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
    public partial class ZD14 : Form
    {
        public ZD14()
        {
            InitializeComponent();
        }

        string[] str;

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(' ');

            foreach (string a in str)
            {
                if (a[a.Length-1]=='а')
                {
                    count++;
                }
            }
            if (count>0)
            {
                textBox2.Text = "Кол-во слов начинающихся с 'а': " + count.ToString();
            }
            
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;

            if ((k < 'А' || k > 'Я') && (k < 'а' || k > 'я') && k =='\b' && k == '.')
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
