using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Helper2<T>
    {
        public static int SearchArray(T[] array, T target)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(target))
                    return i;
            return -1;
        }

        // Problem 12: Replace all occurrences
        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(oldValue))
                    array[i] = newValue;
        }
    }
}
