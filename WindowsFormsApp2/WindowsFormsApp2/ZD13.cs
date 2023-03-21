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
    public partial class ZD13 : Form
    {
        public ZD13()
        {
            InitializeComponent();
        }

        private void ZD13_Load(object sender, EventArgs e)
        {
           
        }
        int n = 0;
        int[,] vs;
        Random Random = new Random();


        private void button1_Click(object sender, EventArgs e)
        {

            n = Convert.ToInt32(numericUpDown1.Value);
            vs = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns.Add("", "");
                for (int j = 0; j < 1; j++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vs[i, j] = Random.Next(-100, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = vs[i, j];
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < n; i++)
            {
                dataGridView2.Columns.Add("", "");
                for (int j = 0; j < 1; j++)
                {
                    dataGridView2.Rows.Add();
                }
            }
            int f = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    f = vs[i, j];
                    vs[i, j] = vs[j, n - 1 - i];
                    vs[j, n - 1 - i] = f;
                    
                }
            }
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = vs[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Rows.Clear();

            dataGridView2.Rows.Clear();

            dataGridView2.Columns.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
