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
    public partial class ZD11 : Form
    {
        public ZD11()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zd9.listView1.Items.Add( "- " + this.comboBox1.Text);
            this.Hide();

            comboBox1.Items.Add(comboBox1.Text);

            Program.zd12.checkedListBox1.Items.Add("- " + comboBox1.Text);
        }
    }
}
