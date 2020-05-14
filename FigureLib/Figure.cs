using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FigureLib
{
    /// <summary>
    /// abstract base class figure
    /// </summary>   
    [Serializable(), XmlInclude(typeof(Triangle)), XmlInclude(typeof(Quadrangle))]
    public abstract class Figure : Comp
    {
        string name;
        Top a, b, c, d;
        Color colorFigure;
        /// <summary>
        /// Array Tops
        /// </summary>
        public Top[] Tops;
        /// <summary>
        /// List exemplars classes
        /// </summary>
        public List<Figure> FigureList = new List<Figure>();
       
        


        /// <summary>
        /// Simple constructor.
        /// </summary>
        public Figure()
        { }

        
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
        [XmlIgnore]
        public Color ColorFigure { get => colorFigure; set => colorFigure = value; }

        /// <summary>
        /// Method to serialize color
        /// </summary>
        [XmlElement("Color")] // Или Attribute
        public int ColorSerialized
        {
            get => ColorFigure.ToArgb();
            set => ColorFigure = Color.FromArgb(value);
        }


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
            
            var cc = ClosestConsoleColor(ColorFigure.R, ColorFigure.G, ColorFigure.B);

            Console.ForegroundColor = cc;

            Console.ForegroundColor = cc;
            Console.WriteLine(Name);
            Console.WriteLine($"Color {ColorFigure}");
            Console.WriteLine("Coordinates");
            foreach (Top top in Tops)
            {
                Console.WriteLine($"{top.X}, {top.Y}");
            }
            Console.WriteLine($"Perimeter = {Perimeter()}");
            Console.WriteLine($"Area = {Area()}");
            Console.ResetColor();
            Console.WriteLine();
        }


        /// <summary>
        /// Selects the applied color
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        protected ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
        {
            ConsoleColor ret = 0;
            double rr = r, gg = g, bb = b, delta = double.MaxValue;

            foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
            {
                var n = cc.ToString();//Enum.GetName(typeof(ConsoleColor), cc);
                var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
                var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
                if (t == 0.0)
                    return cc;
                if (t < delta)
                {
                    delta = t;
                    ret = cc;
                }
            }
            return ret;
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


        /// <summary>
        /// Read info of objects class
        /// </summary>
        /// <returns></returns>
        public List<Figure> ReadAndDeserialize(/*string path*/)
        {
            var serializer = new XmlSerializer(typeof(List<Figure>));
            using (var sr = new StreamReader(/*path*/"searilize.xml"))
            {
                return (List<Figure>)serializer.Deserialize(sr);
            }
        }


        /// <summary>
        /// Safe info if objects class
        /// </summary>
        /// <param name="data"></param>
        public void SerializeAndSave(/*string path,*/ List<Figure> data)
        {
            var serializer = new XmlSerializer(typeof(List<Figure>));
            using (var sw = new StreamWriter(/*path*/"searilize.xml", true))
            {
                serializer.Serialize(sw, data);
            }
        }


        /// <summary>
        /// Rewriting safe info if objects class
        /// </summary>
        /// <param name="data"></param>
        public void SerializeAndRewritingSave(/*string path,*/ List<Figure> data)
        {
            var serializer = new XmlSerializer(typeof(List<Figure>));
            using (var sw = new StreamWriter(/*path*/"searilize.xml"))
            {
                serializer.Serialize(sw, data);
            }
        }


        public void SecondQuarterChek(List<Figure> figures)
        {
            bool chek = true;
            foreach (Figure figure in figures)
            {
                foreach (Top top in figure.Tops)
                {
                    if ((top.X < 0)||(top.Y>0))
                    {
                        chek = false;
                        break;
                    }           
                }
                if(chek)
                {
                    figure.ColorFigure = Color.Green;
                }
            }
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
