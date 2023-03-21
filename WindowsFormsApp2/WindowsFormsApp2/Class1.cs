using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Class1
    {
        public static double g(double x, double y)
        {

            double res = Math.Log10(x) - Math.Log10(y) + Math.Log10(y + 1) - Math.Log10(x);

            return res;
        }
        public static double koordinata(double a, double b)
        {
            double k = Math.Tan(a / b);
            return k;
        }

    }
}
