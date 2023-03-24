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
    public partial class ZD23 : Form
    {
        public ZD23()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "точка, движущиеся по окружности с постоянной угловой  скоростью," +
                " используется класс Random для выбора ее цвета при  движении.");
        }

        Graphics graphics;

        SolidBrush backround;

        SolidBrush objectK;

        int X = 300, Y = 170;

        int r = 50;

        Random random = new Random();

        double angle = 0;
        
        private void ZD23_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;

            graphics = pictureBox1.CreateGraphics();

            objectK = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

            backround = new SolidBrush(Color.White);

            graphics.FillRectangle(backround, 0, 0, pictureBox1.Width, pictureBox1.Height);

            Krug(X, Y);

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.FillEllipse(backround, 0, 0, pictureBox1.Width, pictureBox1.Height);

            angle += 0.05;

            if (angle>=2*Math.PI)
            {
                angle = 0;
            }
            int x = (int)(X + r * Math.Cos(angle));
            int y = (int)(Y + r * Math.Sin(angle));

            Krug(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objectK = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
        }

        void Krug(int x, int y)
        {
            int resultX = x - r;

            int resultY = y - r;

            graphics.FillEllipse(objectK, resultX, resultY, r, r);
        }

    }
}
