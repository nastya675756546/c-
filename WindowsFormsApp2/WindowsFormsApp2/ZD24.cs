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
    public partial class ZD24 : Form
    {
        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD24()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.MP4)|*.MP3|All files(*.*)|*.*";

            infOfileLabel = new ToolStripLabel();

            infOfileLabel.Text = "Путь к файлу:";

            fileLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infOfileLabel);

            statusStrip1.Items.Add(fileLabel);
        }


        string file = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }

            file = openFileDialog1.FileName;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
