﻿using System;
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
    public partial class ZD9 : Form
    {
        public ZD9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.f1.Show();
            this.Hide();
        }
    }
}
