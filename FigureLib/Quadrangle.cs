using System;
using System.Drawing;

namespace FigureLib
{
    [Serializable]
    public class Quadrangle : Figure
    {
        public Quadrangle()
        { }
        public Quadrangle(Top a, Top b, Top c, Top d, Color colorFigure) : base(a, b, c, d, colorFigure)
        {
            Name = "Quadrangle";
        }

        public override double Area()
        {
            double hafPer = Perimeter() / 2;
            return Math.Round(Math.Sqrt((hafPer - SideLength(A, B)) * (hafPer - SideLength(B, C)) * (hafPer - SideLength(C, D)) * (hafPer - SideLength(A, D))), 2);
        }

        public override double Perimeter()
        {
            return Math.Round(SideLength(A, B) + SideLength(B, C) + SideLength(C, D) + SideLength(A, D), 2);
        }
    }
}
