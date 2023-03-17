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
    public partial class ZD3 : Form
    {
        public ZD3()
        {
            InitializeComponent();
        }

        string[] str = new string[4];

        int[] n = new int[4];

        int xy = 0;
        int xz = 0;
        int zd = 0;
        int max = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            
            
             str = textBox1.Text.Split(';');

             for (int i = 0; i < 3; i++)
             {
                 try
                 {
                     n[i] = int.Parse(str[i]);
                 }
                 catch (Exception)
                 {
                    MessageBox.Show("Неверное значение");
                    break;

                 }

             }
            
             xy = Math.Max(n[0], n[1]);
             xz = Math.Max(n[0], n[2]);
             zd = Math.Max(n[2], n[3]);
             max = Math.Max(xy, Math.Max(xz, zd));

             listView1.Items.Add("max(x, y)=" + xy.ToString() + "\r\n");
             listView1.Items.Add("max(x, z)=" + xz.ToString() + "\r\n");
             listView1.Items.Add("max(z, d)=" + zd.ToString() + "\r\n");
             listView1.Items.Add("max=" + max.ToString() + "\r\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
