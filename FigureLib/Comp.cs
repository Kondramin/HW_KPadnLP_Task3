using System.Collections;

namespace FigureLib
{
    public class Comp : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer().Compare(x, y));
        }
    }
}
