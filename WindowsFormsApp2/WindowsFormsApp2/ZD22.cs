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
    public partial class ZD22 : Form
    {
        public ZD22()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void ZD22_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        string saveFile = "";
        string text = "";

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            if (saveFileDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            saveFile = saveFileDialog1.FileName;
            File.WriteAllText(saveFile, textBox1.Text);
            button2.Enabled = true;
            button5.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Lines.Length>=15)
            {
                button1.Enabled = true;
            }
        }
    }
}
