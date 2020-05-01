using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib
{
    public class Triangle : Figure
    {
        
        public Triangle(Top a, Top b, Top c) : base(a, b, c)
        {
            Name = "Triangle";
        }

        public override double Square()
        {
            throw new NotImplementedException();
        }
    }
}
