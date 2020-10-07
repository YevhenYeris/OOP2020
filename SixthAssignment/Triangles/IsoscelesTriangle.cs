using System;
using System.Collections.Generic;
using System.Text;

namespace SixthAssignment.Triangles
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double b, double angle) : base(a, b, angle)
        {
            if (!IsIsosceles(a, b, angle))
            {
                throw new Exception("Трикутник не є рівнобедреним");
            }
        }
    }
}
