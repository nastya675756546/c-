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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void геометрияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd1.Show();
            this.Hide();
        }

        private void физикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd2.Show();
            this.Hide();
        }

        private void ветвленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd3.Show();
            this.Hide();
        }

        private void множестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd4.Show();
            this.Hide();
        }

        private void ветвленияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.zd5.Show();
            this.Hide();
        }

        private void циклыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd6.Show();
            this.Hide();
        }

        private void рекурсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd7.Show();
            this.Hide();
        }

        private void рекурсииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.zd8.Show();
            this.Hide();
        }

        private void спискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd9.Show();
            this.Hide();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd10.Show();
            this.Hide();
        }
    }
}
