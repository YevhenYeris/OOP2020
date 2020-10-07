using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace FourthAssignment
{
    class Triangle
    {
        protected double a;
        private double _b;
        private double _c;
        private double _perimeter;

        public static Triangle Create(string a, string b, string c)
        {
            if (a == b && b == c)
            {
                return new EquilateralTriangle(a);
            }
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

            _perimeter = GetPerimeter();
        }

        protected Triangle()
        {
        }

        public double GetPerimeter()
        {
            return a + _b + _c;
        }

        private bool IsTriangle(double a, double b, double c)
        {
            bool res = (a + b > c) && (a + c > b) && (b + c > a);
            res &= a != 0 && b != 0 && c != 0;

            return res;
        }

        protected void SetA(double side)
        {
            a = side;
        }

        protected void SetB(double side)
        {
            _b = side;
        }

        protected void SetC(double side)
        {
            _c = side;
        }

        protected double CalcAngle(double a, double b, double c)
        {
            double res = Math.Acos((b * b + c * c - a * a) / (2 * b * c));

            return res;
        }
        protected double GetAngleA()
        {
            return Math.Round(180 / Math.PI * CalcAngle(a, _b, _c), 2);
        }

        protected double GetAngleB()
        {
            return Math.Round(180 / Math.PI * CalcAngle(_b, a, _c), 2);
        }

        protected double GetAngleC()
        {
            return Math.Round(180 / Math.PI * CalcAngle(_c, a, _b), 2);
        }

        public string GetAngles() { return new string("A = " + GetAngleA() + 
                                                    "\nB = " + GetAngleB() + 
                                                    "\nC = " + GetAngleC()); }
    }
}
