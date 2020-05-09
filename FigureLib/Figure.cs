using System;
using System.Drawing;

namespace FigureLib
{
    /// <summary>
    /// abstract base class figure
    /// </summary>
    public abstract class Figure
    {
        string name, colour;
        Top a, b, c, d;
        Top[] Tops;
        Color colorFigure;
               
        /// <summary>
        /// Simple constructor to triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="colorFigure"></param>
        public Figure(Top a, Top b, Top c, Color colorFigure)
        {
            A = a;
            B = b;
            C = c;
            ColorFigure = colorFigure;
            Tops = new Top[3] { A, B, C };
        }
        /// <summary>
        /// Simple constructor to quadrangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="colorFigure"></param>
        public Figure(Top a, Top b, Top c, Top d, Color colorFigure)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            ColorFigure = colorFigure;
            Tops = new Top[4] { A, B, C, D };
        }

        /// <summary>
        /// Name prop
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Top prop
        /// </summary>
        public Top A { get => a; set => a = value; }
        /// <summary>
        /// Top prop
        /// </summary>
        public Top B { get => b; set => b = value; }
        /// <summary>
        /// Top prop
        /// </summary>
        public Top C { get => c; set => c = value; }
        /// <summary>
        /// Top prop
        /// </summary>
        public Top D { get => d; set => d = value; }
        /// <summary>
        /// Color of figure prop
        /// </summary>
        public Color ColorFigure { get => colorFigure; set => colorFigure = value; }

        /// <summary>
        /// Calculate square of figure.
        /// </summary>
        /// <returns>square</returns>
        public abstract double Area();
        /// <summary>
        /// Calculate perimeter of figure
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();
        /// <summary>
        /// Show info of class figure
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine($"Color {ColorFigure}");
            Console.WriteLine("Coordinates");
            foreach(Top top in Tops)
            {
                Console.WriteLine(top);
            }
        }
        /// <summary>
        /// Calculate Side length of figure
        /// /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double SideLength(Top a, Top b)
        {
            return Math.Sqrt((Math.Pow((a.X - b.X), 2)) + (Math.Pow((a.Y - b.Y), 2)));
        }
    }
    /// <summary>
    /// Simple structure top of figure
    /// </summary>
    public struct Top
    {
        int x, y;
        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Top(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// X prop
        /// </summary>
        public int X { get => x; set => x = value; }
        /// <summary>
        /// Y prop
        /// </summary>
        public int Y { get => y; set => y = value; }        
    }
}
