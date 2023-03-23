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
    public partial class ZD19 : Form
    {
        public ZD19()
        {
            InitializeComponent();
        }

        double x = 0;
        double endX = 0;

        double a = 0;
        double b = 0;
        double c = 0;

        double k = 0;
        double h = 0;

        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("Выберите график");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите значения");
                return;
            }

            try
            {
                x = double.Parse(textBox1.Text);
                a = double.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат");
                return;
            }

            if (radioButton1.Checked ==true)
            {
                h = 0.1;
                
                endX = x + h * 1000;

                if (x > 0 && x < 1)
                {
                    while (x<=endX)
                    {
                        k = a * (x + 1) + 2;

                        chart1.Series[0].Points.AddXY(x, k);

                        x += h;
                    }
                }
                else
                {
                    MessageBox.Show("не удолетворяет условию: 0 < x < 1");
                }
            }
            if (radioButton2.Checked == true)
            {
                h = 2;
               
                endX = x + h * 10;

                b = r.Next(-100, 100);

                c = r.Next(-100, 100);

                if (x > -10 && x < 10)
                {
                    while (x<=endX)
                    {
                        k = a * x * x + b * x + c;

                        chart1.Series[1].Points.AddXY(x, k);

                        x += h;
                    }
                   
                }

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k !=',' && k != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (!Char.IsDigit(k) && k != ',' && k != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                chart1.Series[0].Points.Clear();
            }
            if (radioButton2.Checked==true)
            {
                chart1.Series[1].Points.Clear();
            }
            
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }
    }
}
