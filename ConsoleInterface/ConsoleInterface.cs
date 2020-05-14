using FigureLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleInterface
{
    /// <summary>
    /// Class realize CI.
    /// </summary>
    public class ConsoleInterface1
    {
        Quadrangle quad = new Quadrangle();


        /// <summary>
        /// Simple initialization.
        /// </summary>
        public ConsoleInterface1()
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
                Console.WriteLine("7. Check second quarter");
                Console.WriteLine("8. Clear console.");
                Console.WriteLine("9. Close console.");
                Console.WriteLine();
                int start_value = CheckNumber();

                if ((start_value > 0) & (start_value < 10))
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
                            quad.SerializeAndSave(quad.FigureList);
                            break;
                        case 4:
                            quad.SerializeAndRewritingSave(quad.FigureList);
                            break;
                        case 5:
                            quad.FigureList = new List<Figure>(quad.ReadAndDeserialize());
                            break;
                        case 6:
                            Comp cp = new Comp();
                            quad.FigureList.Sort(cp.Compare);
                            break;
                        case 7:
                            quad.SecondQuarterChek(quad.FigureList);
                            break;
                        case 8:
                            Console.Clear();
                            break;
                        case 9:
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


        /// <summary>
        /// Class of create figure.
        /// </summary>
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

            quad.FigureList.Add(triangle);
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
            
            quad.FigureList.Add(quadrangle);
        }


        /// <summary>
        /// Show all figures in list.
        /// </summary>
        public void ShowFigureList()
        {
            Console.WriteLine();
            if (quad.FigureList.Count < 1)
            {
                Console.WriteLine("List is empty");
                Console.ReadLine();
                return;
            }
            int i = 1;
            foreach (Figure figure in quad.FigureList)
            {
                Console.WriteLine($"{i} figure is");
                figure.ShowInfo();
                i++;
            }
            Console.WriteLine();
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



