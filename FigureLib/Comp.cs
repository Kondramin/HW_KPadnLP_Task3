using System.Collections;

namespace FigureLib
{
    /// <summary>
    /// Realize interface IComparer
    /// </summary>
    public class Comp : IComparer

    {
        /// <summary>
        /// Simple method realization
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            //проверка на null
            Figure figureX = x as Figure;
            Figure figureY = y as Figure;
            return (new CaseInsensitiveComparer().Compare(figureX.Area(), figureY.Area()));
        }
    }
}
