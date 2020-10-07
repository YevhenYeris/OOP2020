using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    class FigureManager
    {
        private Figure _figure;

        public FigureManager(int index, List<double> measurments)
        {
            switch (index)
            {
                case 0: _figure = Triangle.Create(measurments[0], measurments[1], measurments[2]);
                    break;
                case 1: _figure = Circle.Create(measurments[0]);
                    break;
                case 2: _figure = Rectangle.Create(measurments[0], measurments[1]);
                    break;
                case 3:
                    _figure = Square.Create(measurments[0]);
                    break;
                case 4: _figure = Rhombus.Create(measurments[0], measurments[1]);
                    break;
            }
        }

        public double GetArea()
        {
            return _figure.GetArea();
        }

        public double GetPerimeter()
        {
            return _figure.GetPerimeter();
        }
    }
}
