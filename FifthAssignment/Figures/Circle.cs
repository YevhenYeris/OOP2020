using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FifthAssignment
{
    class Circle : Figure
    {
        private double _radius;

        public static Circle Create(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Введено неправильні значення.");
            }
            return new Circle(radius);
        }

        private Circle(double radius)
        {
            this._radius = radius;
            CalcArea();
            CalcPerimeter();
        }

        protected override double CalcPerimeter()
        {
            return perimeter = 2 * Math.PI * _radius;
        }

        protected override double CalcArea()
        {
            return area = Math.PI * Math.Pow(_radius, 2);
        }
    }
}
