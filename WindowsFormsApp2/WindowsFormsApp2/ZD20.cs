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
    public partial class ZD20 : Form
    {
        public ZD20()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Hide();
        }

        int i = 0;
        int sec = 0;
        int min = 0;
        int clock = 0;
        

        private void ZD20_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;

            if (i==99)
            {
                if (sec == 59)
                {
                    if (min == 59)
                    {
                        min = 0;
                        clock += 1;
                    }
                    else
                    {
                        MessageBox.Show("Прошла минута");
                        min++;
                    }
                    sec = 0;   
                }
                else
                {
                    sec++;
                    
                }
                i = 0;
            }
            else
            {
                i++;
            }
            
            label1.Text = clock.ToString()+" ч."+min.ToString()+" мин."+sec.ToString()+" сек.";
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Обнуление");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Старт";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
                button2.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            sec = 0;
            min = 0;
            clock = 0;
        }
    }
}
