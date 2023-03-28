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
    public partial class ZD25 : Form
    {
        public ZD25()
        {
            InitializeComponent();
        }
        int i = 0;

        int value=0;

        string text = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = textBox1.Lines[value].ToString();

                i++;
                
                if (i > 0 && i < 10 && i < 100 && i < 1000)
                {
                    textBox2.Text += "000" + i.ToString() + " " + text + "\r\n";
                }

                if (i > 10 && i < 100 && i < 100)
                {
                    textBox2.Text += "00" + i.ToString() + " " + text + "\r\n";
                }

                if (i > 100 && i < 1000)
                {
                    textBox2.Text += "0" + i.ToString() + " " + text + "\r\n";
                }

                if (i > 1000)
                {
                    textBox2.Text += i.ToString() + " " + text + "\r\n";
                }

                value++;
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "textBox2");
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "textBox1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
