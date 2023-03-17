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
    public partial class ZD6 : Form
    {
        public ZD6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        int eps = 0;
        double s0 = 0;
        double n = 0;
        int s = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                eps = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Неверное значение");
                
            }

           
            while (s0<=eps)
            {
                n++;
                s0 = s0 + 1 / n;
            }

            s = Convert.ToInt32(s0);

            listView1.Items.Add("n=" + n.ToString() + "\r\n");
            listView1.Items.Add("s=" + s.ToString() + "\r\n");
           
        }
    }
}
