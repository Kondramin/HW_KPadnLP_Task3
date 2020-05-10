using FigureLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleInterface
{
    public class ConsoleInterface
    {

        List<Figure> FigureList = new List<Figure>();
        /// <summary>
        /// Simple initialization.
        /// </summary>
        public ConsoleInterface()
        {
        }
        /// <summary>
        /// Method start UI.
        /// </summary>
        public void StartInterface()
        {
            while (true)
            {
                Console.WriteLine("1. Add new figure.");
                Console.WriteLine("2. Show list of figures.");
                Console.WriteLine("3. Safe data.");
                Console.WriteLine("4. Rewind safe data.");
                Console.WriteLine("5. Read data");
                Console.WriteLine("6. Sort List");
                Console.WriteLine("7. Clear console.");
                Console.WriteLine("8. Close console.");
                Console.WriteLine();
                int start_value = CheckNumber();

                if ((start_value > 0) & (start_value < 7))
                {
                    switch (start_value)
                    {
                        case 1:
                            CreateFugure();
                            break;
                        case 2:
                            ShowFigureList();
                            break;
                        case 3:
                            SerializeAndSave(FigureList);
                            break;
                        case 4:
                            SerializeAndRewritingSave(FigureList);
                            break;
                        case 5:
                            FigureList = ReadAndDeserialize();
                            break;
                        case 6:
                            Comp cp = new Comp();
                            FigureList.Sort(cp.Compare);
                            break;
                        case 7:
                            Console.Clear();
                            break;
                        case 8:
                            Environment.Exit(0);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("You need select correct menu item");
                }
            }
        }

        public void CreateFugure()
        {
            Console.WriteLine("What figure you want create?");
            Console.WriteLine("1. Triangle.");
            Console.WriteLine("2. Quadrangle.");
            int item = CheckNumber();
            switch (item)
            {
                case 1:
                    CreateTriangle();
                    break;
                case 2:
                    CreateQuadrangle();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }


        /// <summary>
        /// Create triangle
        /// </summary>
        public void CreateTriangle()
        {
            Console.WriteLine("Write 3 tops:");
            Console.WriteLine("1: ");
            Top a = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("2: ");
            Top b = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("3: ");
            Top c = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("Write a color");
            Color color = Color.FromName(Console.ReadLine());

            var triangle = new Triangle(a, b, c, color);
            FigureList.Add(triangle);
        }


        /// <summary>
        /// Create quadrangle
        /// </summary>
        public void CreateQuadrangle()
        {
            Console.WriteLine("Write 4 tops:");
            Console.WriteLine("1: ");
            Top a = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("2: ");
            Top b = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("3: ");
            Top c = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("4: ");
            Top d = new Top(CheckNumber(), CheckNumber());
            Console.WriteLine("Write a color");
            Color color = Color.FromName(Console.ReadLine());

            var quadrangle = new Quadrangle(a, b, c, d, color);
            FigureList.Add(quadrangle);
        }


        /// <summary>
        /// Show all figures in list.
        /// </summary>
        public void ShowFigureList()
        {
            Console.WriteLine();
            if (FigureList.Count < 1)
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
                return;
            }
            int i = 1;
            foreach (Figure figure in FigureList)
            {
                Console.WriteLine($"{i} figure is");
                figure.ShowInfo();
                i++;
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Read info of objects class
        /// </summary>
        /// <returns></returns>
        public List<Figure> ReadAndDeserialize(/*string path*/)
        {
            var serializer = new XmlSerializer(typeof(List<Figure>));
            using (var sr = new StreamReader(/*path*/"task.txt"))
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
            using (var sw = new StreamWriter(/*path*/"task.txt", true))
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
            using (var sw = new StreamWriter(/*path*/"task.txt"))
            {
                serializer.Serialize(sw, data);
            }
        }


        /// <summary>
        /// Check correct input.
        /// </summary>
        /// <returns>number</returns>
        public int CheckNumber()
        {
            int result;
            while (!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("You must write number");
            }
            return result;
        }

    
  
    }
}



