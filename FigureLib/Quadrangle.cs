using System;
using System.Drawing;

namespace FigureLib
{
    /// <summary>
    /// Class Quadrangle
    /// </summary>
    [Serializable]
    public class Quadrangle : Figure
    {

        /// <summary>
        /// Simple constructor
        /// </summary>
        public Quadrangle()
        { }


        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="colorFigure"></param>
        public Quadrangle(Top a, Top b, Top c, Top d, Color colorFigure) : base(a, b, c, d, colorFigure)
        {
            Name = "Quadrangle";
        }


        /// <summary>
        /// Calculate Area quadrangle
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double hafPer = Perimeter() / 2;
            return Math.Round(Math.Sqrt((hafPer - SideLength(A, B)) * (hafPer - SideLength(B, C)) * (hafPer - SideLength(C, D)) * (hafPer - SideLength(A, D))), 2);
        }


        /// <summary>
        /// Calculate Perimeter quadrangle
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return Math.Round(SideLength(A, B) + SideLength(B, C) + SideLength(C, D) + SideLength(A, D), 2);
        }
    }
}
