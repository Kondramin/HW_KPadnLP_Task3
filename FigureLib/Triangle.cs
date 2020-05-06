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
            return (SideLength(A, B) + SideLength(B, C) + SideLength(A, C));
        }

        public override double Area()
        {
            double hafPer = Perimeter()/2;
            //S=√p(p−a)(p−b)(p−c)
            return (Math.Sqrt(hafPer * (hafPer - SideLength(A, B)) * (hafPer - SideLength(A, C)) * (hafPer * SideLength(B, C))));
        }
    }
}
