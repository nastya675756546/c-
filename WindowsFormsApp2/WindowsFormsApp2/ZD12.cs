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

       public static List<T>remove<T>(List<T> list)
        {
            return new HashSet<T>(list).ToList();
        }
        string text="!";

        private void button1_Click(object sender, EventArgs e)
        {
            char[] list = textBox1.Text.ToCharArray();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(list[i]))
                {
                   
                }
                else
                {
                    textBox1.Text += list[i];
                }
            }
            /*List<char> list= textBox1.Text.ToList();
            List<char> list0 = remove(list);
            list0.AddRange(text);
            textBox1.Text += text;
            /*List<char> listlist = textBox1.Text.ToList();
            List<char> list = listlist.Union(listlist).ToList();
            list.AddRange(text);
            textBox1.Text = text;
            //var text = textBox1.Text.GroupBy(x=>x).Any(g=>g.Count()>1);
           /* var t = textBox1.Text.Union(textBox1.Text); 
           */
            //listView1.Items.Add(t.ToString());
            /*char[]t = textBox1.Text.ToCharArray();
            string f = t.Distinct().ToString();
            text = f.ToString();
            textBox1.Text = text;*/
        }
    }
}
