using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    class Rhombus : Square
    {
        private double _angle;

        public new static Rhombus Create(double a, double angle)
        {
            if (a <= 0 || angle <= 0)
            {
                throw new Exception("Введено неправильні значення.");
            }
            return new Rhombus(a, angle);
        }

        private Rhombus(double a, double angle)
        {
            this.a = a;
            _angle = Math.PI * angle / 180;
            CalcArea();
            CalcPerimeter();
        }

        protected override double CalcArea()
        {
            return area = a * a * Math.Sin(_angle);
        }
    }
}
