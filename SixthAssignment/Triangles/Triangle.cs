using SixthAssignment.Triangles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SixthAssignment
{
    abstract public class Triangle
    {
        protected double a;
        protected double b;
        protected double angle;

        public static Triangle Create(double sideA, double sideB, double angle)
        {
            if (IsIsosceles(sideA, sideB, angle))
            {
                return new IsoscelesTriangle(sideA, sideB, angle);
            }

            if (IsRight(sideA, sideB, angle))
            {
                return new RightTriangle(sideA, sideB, angle);
            }

            throw new Exception("Трикутник не є ні рівнобедреним, ні прямокутним.");
        }

        public static Triangle Create(string sideA, string sideB, string angle)
        {
            return Create(Double.Parse(sideA), Double.Parse(sideB), Double.Parse(angle));
        }

        public Triangle(double sideA, double sideB, double angle)
        {
            if (!IsTriangle(sideA, sideB, GetC(sideA, sideB, angle)))
            {
                throw new Exception("Трикутник із такими параметрами не існує");
            }
            a = sideA;
            b = sideB;
            this.angle = angle;
        }

        private bool IsTriangle(double a, double b, double c)
        {
            bool res = (a + b > c) && (a + c > b) && (b + c > a);
            res &= a != 0 && b != 0 && c != 0;

            return res;
        }

        protected static bool IsRight(double a, double b, double angle)
        {
            double c = GetC(a, b, angle);
            return angle == 90 || a * a + b * b == c * c ||
                   a * a + c * c == b * b ||
                   b * b + c * c == a * a;
        }

        protected static bool IsIsosceles(double a, double b, double angle)
        {
            double c = GetC(a, b, angle);
            return a == b || a == c || b == c;
        }

        public virtual double CalcPerimeter()
        {
            double c = GetC(a, b, angle);
            return a + b + c;
        }

        public virtual double CalcArea()
        {
            return a * b * Math.Sin(Math.PI * angle / 180) / 2;
        }

        private static double GetC(double a, double b, double angle)
        {
            return Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(Math.PI * angle / 180));
        }
    }
}
