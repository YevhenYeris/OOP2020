using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    class Triangle : Figure
    {
        protected double a;
        protected double b;
        private double _c;

        public static Triangle Create(string a, string b, string c)
        {
            return new Triangle(a, b, c);
        }

        public static Triangle Create(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        protected Triangle(string a, string b, string c) :
            this(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c))
        {
        }

        private Triangle(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new Exception("Трикутника зі вказаними параметрами не існує");
            }

            SetA(a);
            SetB(b);
            SetC(c);

            CalcArea();
        }

        private bool IsTriangle(double a, double b, double c)
        {
            bool res = (a + b > c) && (a + c > b) && (b + c > a);
            res &= a != 0 && b != 0 && c != 0;

            return res;
        }

        protected Triangle()
        {
            //throw new Exception("Сторони не можуть дорівнювати 0");
        }
       
        protected override double CalcPerimeter()
        {
            return perimeter = a + b + _c;
        }

        protected override double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return area = Math.Sqrt(p * (p - a) * (p - b) * (p - _c));
        }

        protected double CalcAngle(double a, double b, double c)
        {
            double res = Math.Acos((b * b + c * c - a * a) / (2 * b * c));

            return res;
        }

        protected double GetAngleA()
        {
            return Math.Round(180 / Math.PI * CalcAngle(a, b, _c), 2);
        }

        protected double GetAngleB()
        {
            return Math.Round(180 / Math.PI * CalcAngle(b, a, _c), 2);
        }

        protected double GetAngleC()
        {
            return Math.Round(180 / Math.PI * CalcAngle(_c, a, b), 2);
        }

        public string GetAngles()
        {
            return new string("a = " + GetAngleA() +
                            "\nB = " + GetAngleB() +
                            "\nC = " + GetAngleC());
        }
        
        protected void SetA(double side)
        {
            a = side;
        }

        protected void SetB(double side)
        {
            b = side;
        }

        protected void SetC(double side)
        {
            _c = side;
        }

    }
}
