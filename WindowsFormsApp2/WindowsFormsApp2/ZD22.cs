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
        ToolStripLabel infOdataLabel;

        ToolStripLabel dataLabel;

        ToolStripLabel infOtimeLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infOfileLabel;

        ToolStripLabel fileLabel;

        public ZD22()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            infOdataLabel = new ToolStripLabel();
            infOdataLabel.Text = "Дата:";

            dataLabel = new ToolStripLabel();

            infOtimeLabel = new ToolStripLabel();
            infOtimeLabel.Text = "Время:";

            timeLabel = new ToolStripLabel();

            infOfileLabel = new ToolStripLabel();
            infOfileLabel.Text = "Путь к файлу:";

            fileLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infOdataLabel);

            statusStrip1.Items.Add(dataLabel);

            statusStrip1.Items.Add(infOtimeLabel);

            statusStrip1.Items.Add(timeLabel);

            statusStrip1.Items.Add(infOfileLabel);

            statusStrip1.Items.Add(fileLabel);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        private void ZD22_Load(object sender, EventArgs e)
        {
            timer1.Start();
            button5.Enabled = false;

            button2.Enabled = false;

            button1.Enabled = false;
        }

        string saveFile = "";
        string text = "";

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;

            button5.Enabled = true;

            text = textBox1.Text;

            if (saveFileDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            saveFile = saveFileDialog1.FileName;

            File.WriteAllText(saveFile, textBox1.Text);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Lines.Length >= 1)
            {
                button1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        string openFile = "";

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = openFileDialog1.FileName;

            text = File.ReadAllText(openFile);

            textBox1.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            fileLabel.Text = Path.GetFullPath(openFileDialog1.FileName).ToString();
        }

        string[] str;

        private void button5_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(' ', '.',',',':',';');
            for (int i = 0; i < str.Length; i++)
            {
               // str[i];
            }
        }
    }
}
