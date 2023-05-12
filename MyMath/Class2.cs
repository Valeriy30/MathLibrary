using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    internal class Geometry
    {
        public static double SquareTriangle(double p, double a, double b, double c)
        {
            double s = Math.Sqrt(p - (p - a) - (p - b) - (p - c));
            return s;
        }
        public static double SquareSquare(double a)
        {
            double s = a * a; 
            return s;
        }
        public static double SquareSqRectangle(double a, double b)
        {
            double s = a * b;
            return s;
        }
        public static double SquareRhoumbs(double ac, double bd )
        {
            double s = (ac * bd)/2;
            return s;
        }
        public static double SquareCircle(double r)
        {
            double s = r *r*3.14 ;
            return s;
        }
    }
}
