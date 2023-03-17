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
    public partial class ZD10 : Form
    {
        public ZD10()
        {
            InitializeComponent();
        }

        int[] array = new int[12];

        Random random = new Random();

        int f = 0;

        string str = "";

        private void ZD10_Load(object sender, EventArgs e)
        {
            f = 4;

            for (int i = 0; i < 4 ; i++)
            {
                str = "";
                for (int j = 0; j < f; j++)
                {
                    array[i] = random.Next(-100, 100);

                    str += Convert.ToInt32(array[i])+" ";
                }
                listView1.Items.Add(str+"\r\n");

                f--;
            }
        }
    }
}
