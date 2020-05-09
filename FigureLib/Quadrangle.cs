using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigureLib
{
    class Quadrangle : Figure
    {
        public Quadrangle(Top a, Top b, Top c, Top d, Color colorFigure) : base(a, b, c, d, colorFigure)
        {
            Name = "Quadrangle";
        }

        public override double Area()
        {
            double hafPer = Perimeter() / 2;
            return (Math.Sqrt((hafPer - SideLength(A, B)) * (hafPer - SideLength(B, C)) * (hafPer - SideLength(C, D)) * (hafPer - SideLength(A, D))));
        }

        public override double Perimeter()
        {
            return (SideLength(A, B) + SideLength(B, C) + SideLength(C, D) + SideLength(A, D));
        }
    }
}
