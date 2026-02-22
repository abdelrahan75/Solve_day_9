using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Helper
    {
        public static T Max<T>(T a, T b) where T : IComparable<T> =>
        a.CompareTo(b) >= 0 ? a : b;

        // Problem 14: Non-generic Swap for Rectangle struct
        public static void Swap(ref Rectangle a, ref Rectangle b)
        {
            Rectangle temp = a;
            a = b;
            b = temp;
        }
    }
}
