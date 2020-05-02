using System;
using System.Drawing;

namespace FigureLib
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Figure
    {
        string name, colour;
        Top a, b, c, d;

        Color colorFigure;
        
       

        public Figure(Top a, Top b, Top c, Color colorFigure)
        {
            A = a;
            B = b;
            C = c;
            ColorFigure = colorFigure;
        }
        public Figure(Top a, Top b, Top c, Top d, Color colorFigure)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            ColorFigure = colorFigure;
        }


        public string Name { get => name; set => name = value; }
        public Top A { get => a; set => a = value; }
        public Top B { get => b; set => b = value; }
        public Top C { get => c; set => c = value; }
        public Top D { get => d; set => d = value; }
        public string Colour { get => colour; set => colour = value; }
        public Color ColorFigure { get => colorFigure; set => colorFigure = value; }





        /// <summary>
        /// Calculate square of figure.
        /// </summary>
        /// <returns>square</returns>
        public abstract double Square();
    }
    public struct Top
    {
        int x, y;

        public Top(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


    }

}
