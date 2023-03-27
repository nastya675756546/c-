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
    public partial class ZD26 : Form
    {
        public ZD26()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void ZD26_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("","наименование изделия");

            dataGridView1.Columns.Add("", "вес");

            dataGridView1.Columns.Add("", "стоимость");

            dataGridView1.Columns[0].Width = 150;

            dataGridView1.Rows.Add("утка по-пекински", "1500 г.", "3 200 руб.");

            dataGridView1.Rows.Add("креветки по-корейски", "300 г.", "1 200 руб.");

            dataGridView1.Rows.Add("многослойный рулет", "380 г.", "400 руб.");

            dataGridView1.Rows.Add("разноцветный кальмар", "380 г.", "500 руб.");

            dataGridView1.Rows.Add("филе морской форели", "300 г.", "1 000 руб.");

            dataGridView1.Rows.Add("кольца кальмра", "350 г.", "750 руб.");
        }
    }
}
