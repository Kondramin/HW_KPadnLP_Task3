using System;

namespace FigureLib
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Figure
    {
        string name;
        Top a = new Top();
             b, c, d;
        

        public Figure(Top a, Top b, Top c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Figure(Top a, Top b, Top c, Top d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }


        public string Name { get => name; set => name = value; }
        public Top A { get => a; set => a = value; }
        public Top B { get => b; set => b = value; }
        public Top C { get => c; set => c = value; }
        public Top D { get => d; set => d = value; }




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
