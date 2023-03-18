using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class ZD9 : Form
    {
        public ZD9()
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
            Program.zd11.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.zd12.Show();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("D:\\n.txt"))
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    sw.WriteLine(listView1.Items[i].ToString());
                }
            }
        }
    }
}
