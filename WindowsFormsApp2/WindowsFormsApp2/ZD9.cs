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
    public partial class ZD9 : Form
    {
        public ZD9()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.zd11.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }


        string str = "";

        string file = "";

        private void button5_Click(object sender, EventArgs e)
        {

            file = textBox1.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;

            str = saveFileDialog1.FileName;

            File.WriteAllText(str, textBox1.Text);
      
        }

        string open = "";

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            str = openFileDialog1.FileName;

            open = File.ReadAllText(str);

            textBox1.Text = open;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text+= Clipboard.GetText();
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1,"для добавление текста нажмите кнопку добавить или введите текс в textbox ");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(button4, "выделите текст и нажмите удалить");
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(button7, "выделите текст и нажмите копировать");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(button3, "выделите текст и нажмите вставить");
        }
    }
}
