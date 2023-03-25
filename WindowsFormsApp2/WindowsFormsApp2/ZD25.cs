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

        private void ZD25_Load(object sender, EventArgs e)
        {
            
        }
        int i = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (i>1)
            {
                textBox2.Text += "000" + i.ToString() + " " + textBox1.Text;
            }
            if(i>10)
            {
                textBox2.Text += "00" + i.ToString() + " " + textBox1.Text;
            }
            if (i>100)
            {
                textBox2.Text += "0" + i.ToString() + " " + textBox1.Text;
            }
            if (i>1000)
            {
                textBox2.Text += i.ToString() + " " + textBox1.Text;
            }
            
            i++;
        }
    }
}
