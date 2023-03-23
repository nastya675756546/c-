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
        public ZD21()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        public Bitmap[] bitmaps;
        public int bitmapsNum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = !pictureBox1.Enabled;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bitmaps = new Bitmap[18];
            for (int i = 0; i < 18; i++)
            {
                bitmaps[i] = new Bitmap("frame" + i + ".png");
            }
            pictureBox1.Image = bitmaps[bitmapsNum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bitmapsNum = ++bitmapsNum % bitmaps.Length;
            pictureBox1.Image = bitmaps[bitmapsNum];
            
        }
    }
}
