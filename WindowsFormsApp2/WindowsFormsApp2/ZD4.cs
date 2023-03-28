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
    public partial class ZD4 : Form
    {
        public ZD4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        string[] str;

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split('a', 'e', 'i', 'o', 'u');
            for (int i = 0; i < str.Length; i++)
            {
                textBox2.Text += str[i];
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if ((k < 'A' || k > 'z') && k != '\b' && k != '.' && k != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
