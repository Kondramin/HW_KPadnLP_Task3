using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigureLib
{
    public class Triangle : Figure
    {
        public Triangle(Top a, Top b, Top c, Color colorFigure) : base(a, b, c, colorFigure)
        {
            Name = "Triangle";
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }

        public override double Square()
        {
            throw new NotImplementedException();
        }
    }
}
