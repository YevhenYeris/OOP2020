using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    abstract class Figure
    {
        protected double area;
        protected double perimeter;

        protected virtual double CalcArea()
        {
            return area;
        }

        protected virtual double CalcPerimeter()
        {
            return perimeter;
        }

        public double GetArea()
        {
            return area;
        }

        public double GetPerimeter()
        {
            return perimeter;
        }
    }
}
