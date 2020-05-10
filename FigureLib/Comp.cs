using System.Collections;

namespace FigureLib
{
    public class Comp : IComparer
    {
        public int Compare(Figure x, Figure y)
        {
            return (new CaseInsensitiveComparer().Compare(x.Area(), y.Area()));
        }
    }
}
