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

        private void ZD12_Load(object sender, EventArgs e)
        {

        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
          Program.zd9.listView1.Items.RemoveAt(checkedListBox1.SelectedIndex);
          this.Hide();
    
          checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            
        }
    }
}
