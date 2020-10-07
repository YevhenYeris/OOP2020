using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;

namespace FifthAssignment
{
    class Rectangle : Figure
    {
        protected double a;
        private double _b;

        public static Rectangle Create(string a, string b)
        {
            return Rectangle.Create(Double.Parse(a), Double.Parse(b));
        }

        public static Rectangle Create(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new Exception("Введено неправильні значення.");
            }

            if (a == b || b == 0)
            {
                return new Square(a);
            }

            return new Rectangle(a, b);
        }

        protected Rectangle(double a, double b)
        {
            this.a = a; 
            _b = b;
            CalcPerimeter();
            CalcArea();
        }

        protected Rectangle()
        {

        }

        protected override double CalcPerimeter()
        {
            return perimeter = 2 * (a + _b);
        }

        protected override double CalcArea()
        {
            return area = a * _b;
        }
    }
}
