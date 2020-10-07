using System;
using System.Collections.Generic;
using System.Text;

namespace FourthAssignment
{
    class EquilateralTriangle : Triangle
    {
        private double _a;
        private double _area;

        public EquilateralTriangle(string a) : base(a, a, a)
        {
            SetA(a);
            SetArea();
        }

        private void SetArea()
        {
            this._area = _a * _a * Math.Sqrt(3) / 4;
        }

        private void SetA(string side)
        {
            this._a = Convert.ToDouble(side);
        }
    }
}
