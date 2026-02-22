using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class MAXimam_Reverse
    {
        #region problem_1
        public T[] reverse<T>(T[] arr   )
        {
            T[] ans = new T[arr.Length];
            int Postion = 0;
            for (int i= arr.Length-1; i>=0; i--)
            {
                 ans [Postion] = arr[i];
                Postion++;
            }
            return ans;
        }
        #endregion

        #region problem_2

        public static void Reverse_two_item<T>( ref T[] arr, int index1, int index2)
        {
            if (index1 >= 0 && index1 < arr.Length && index2 >= 0 && index2 < arr.Length)
            {
                T temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }
        }

        public static T Max<T> (T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                // استخدام CompareTo بدلاً من > لأن النوع T غير محدد
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }


        #endregion
    }
}
