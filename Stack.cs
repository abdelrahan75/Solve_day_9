using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace solve_day_9_C_
{
    internal class Stack<T>
    {
        private List<T> values=new List<T>();

        public void Add(T value)
        {
            values.Add(value);
        }

        public T Pop(T value)
        {
            if (values.Count == 0)
                throw new InvalidOperationException("المكدس فارغ!");

            T item =values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (values.Count == 0)
                throw new InvalidOperationException("المكدس فارغ!");

            return values[values.Count - 1];
        }
    }
}
