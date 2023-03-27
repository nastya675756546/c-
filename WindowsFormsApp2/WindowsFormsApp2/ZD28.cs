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
    public partial class ZD28 : Form
    {
        public ZD28()
        {
            InitializeComponent();
        }

        int i = 0;

        private void ZD28_Load(object sender, EventArgs e)
        {
            i++;
            dataGridView1.Columns.Add("", "№");

            dataGridView1.Columns.Add("", "Имя");

            dataGridView1.Columns.Add("", "Фамилия");

            dataGridView1.Columns.Add("", "Класс");

            dataGridView1.Columns.Add("", "Средний балл");

            dataGridView2.Columns.Add("", "№");

            dataGridView2.Columns.Add("", "Имя");

            dataGridView2.Columns.Add("", "Фамилия");

            dataGridView2.Columns.Add("", "Класс");

            dataGridView2.Columns.Add("", "Средний балл");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "заполните данные");
        }
        string d="";
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 2; i < dataGridView1.Columns.Count;)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1[i,j]==dataGridView1[i,j+1])
                    {
                        MessageBox.Show("");
                    }
                }
            }
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < dataGridView1.Columns.Count;)
            {
                for (int j = 0; j < dataGridView1.Rows.Count+1; j++)
                {
                    if (dataGridView1[i, j] == dataGridView1[i, j + 1])
                    {
                        MessageBox.Show("");
                    }
                }
            }
        }
    }
}
