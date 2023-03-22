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

        double valueX = 0;

        double a = 0;

        double k = 0;

        double[] x;



        Random Random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            x = new double[Random.Next(5, 10)];
            if (radioButton1.Checked==true)
            {
                try
                {
                    double valueX = double.Parse(textBox1.Text);

                    //double a = double.Parse(textBox2.Text);
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("неверное значение");
                }

                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = valueX;
                    valueX = valueX + 0.1;
                    textBox2.Text += x[i].ToString();
                }


            }
            else
            {
                if (radioButton2.Checked==true)
                {
                    
                }
            }
        }
    }
}
