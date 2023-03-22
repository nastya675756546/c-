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
    public partial class ZD16 : Form
    {
        public ZD16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        double s = 0;

        double t = 0;

        double Sum = 0;

        double g = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s = int.Parse(textBox1.Text);

                t = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {

               
            }
            

            Sum =Math.Round(Class1.g(1.2, s) + Class1.g(t, s) - Class1.g(2 * s, 1.5 * t),3);

            textBox3.Text = "S=" + Sum.ToString();

          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != 8)
            {
                e.Handled = true;
            }
        }
    }
}
