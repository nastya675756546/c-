﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static Form1 f1 = new Form1();
        public static ZD1 zd1 = new ZD1();
        public static ZD2 zd2 = new ZD2();
        public static ZD3 zd3 = new ZD3();
        public static ZD4 zd4 = new ZD4();
        public static ZD5 zd5 = new ZD5();
        public static ZD6 zd6 = new ZD6();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
