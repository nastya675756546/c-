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
    public partial class ZD15 : Form
    {
        public ZD15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        int x = 0;

        int y = 0;

        int[,] array;

        Random Random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(numericUpDown1.Value);

            y = Convert.ToInt32(numericUpDown2.Value);

            array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = Random.Next(-100, 100);

                    textBox1.Text += array[i, j].ToString()+" ";
                }
                textBox1.Text += "\r\n";
            }
        }

        int k = 0;

        int z = 0;

        int[] onearray;

        private void button3_Click(object sender, EventArgs e)
        {
            onearray = new int[x * y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    onearray[k] = array[i, j];

                    k++;
                }
            }

            Array.Sort(onearray);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = onearray[z];

                    z++;
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    textBox2.Text += array[i, j].ToString() + " ";
                }
                textBox2.Text += "\r\n";
            }
        }
        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(numericUpDown1, "Кол-во столбцов");
            
        }

        private void numericUpDown2_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip2.SetToolTip(numericUpDown2, "Кол-во строк");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
