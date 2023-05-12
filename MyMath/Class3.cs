using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    internal class Class3
    {
        public static double Sinus(double a)
        {
            double r = Math.Sin(a);
            return r;
        }
        public static double Cosinus(double a)
        {
            double r = Math.Cos(a);
            return r;
        }
        public static double Catangens(double a)
        {
            double r = 1/Math.Tan(a);
            return r;
        }
        public static double Tangens(double a)
        {
            double r = Math.Tan(a);
            return r;
        }
    }
}
