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
    public partial class F0 : Form
    {
        public F0()
        {
            InitializeComponent();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i==2000)
            {
                timer1.Stop();
                Program.f1.Show();
                this.Hide();
            }
            else
            {
                i += timer1.Interval;
                progressBar1.PerformStep();
            }
        }
    }
}
