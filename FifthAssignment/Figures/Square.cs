using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    class Square : Rectangle
    {
        public static Square Create(double a)
        {
            return new Square(a);
        }

        public Square(double a)
        {
            this.a = a;
            CalcPerimeter();
            CalcArea();
        }

        public Square()
        {

        }

        protected override double CalcPerimeter()
        {
            return perimeter = 2 * (a + a);
        }
        protected override double CalcArea()
        {
            return area = a * a;
        }
    }
}
