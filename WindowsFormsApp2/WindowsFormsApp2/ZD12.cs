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
    public partial class ZD12 : Form
    {
        public ZD12()
        {
            InitializeComponent();
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;

                button3.Text = "Возобновить";
            }
            else
            {
                timer1.Enabled = true;

                button3.Text = "Остановить";
            }

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                pictureBox1.Image = Image.FromFile(@"E:\c-\WindowsFormsApp2\1.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"E:\c-\WindowsFormsApp2\2.png");
            }
            i++;
        }

        private void ZD12_Load(object sender, EventArgs e)
        {
            button3.Text = "Остановить";

           

            timer1.Enabled = true;
        }
    }
}
