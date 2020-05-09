using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace FigureLib
{
    /// <summary>
    /// Class of triangle
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="colorFigure"></param>
        public Triangle(Top a, Top b, Top c, Color colorFigure) : base(a, b, c, colorFigure)
        {
            Name = "Triangle";
        }
        /// <summary>
        /// Override method of perimeter
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return Math.Round(SideLength(A, B) + SideLength(B, C) + SideLength(A, C),2);
        }
        /// <summary>
        /// Override method of area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double hafPer = Perimeter()/2;
            return Math.Round(Math.Sqrt(hafPer * (hafPer - SideLength(A, B)) * (hafPer - SideLength(A, C)) * (hafPer * SideLength(B, C))),2);
        }
    }
}
