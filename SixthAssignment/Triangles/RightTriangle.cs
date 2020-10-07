using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SixthAssignment.Triangles
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double angle) : base(a, b, angle)
        {
            if (!IsRight(a, b, angle))
            {
                throw new Exception("Трикутник не є прямокутним");
            }
        }
    }
}
