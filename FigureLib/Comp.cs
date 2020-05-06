using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FigureLib
{
    class Comp : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer().Compare(x, y));
        }
    }
}
