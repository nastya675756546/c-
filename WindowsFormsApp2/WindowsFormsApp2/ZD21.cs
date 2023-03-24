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
    public partial class ZD21 : Form
    {
        Image k1 = Image.FromFile(@"D:\c-\WindowsFormsApp2\1.png");
        Image k2 = Image.FromFile(@"D:\c-\WindowsFormsApp2\2.png");
        public ZD21()
        {
            InitializeComponent();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;

                button1.Text = "Возобновить";
            }
            else
            {
                timer1.Enabled = true;

                button1.Text = "Остановить";
            }
            
        }

        int i=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i%2==0)
            {
                pictureBox1.Image = k1;
            }
            else
            {
                pictureBox1.Image = k2;
            }
            i++;
        }

        private void ZD21_Load(object sender, EventArgs e)
        {
            button1.Text = "Остановить";

            pictureBox1.Image = k2;

            timer1.Enabled = true;
        }

       
    }
}
