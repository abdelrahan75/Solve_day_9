using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual Department Department { get; set; }
        public Person(string name, int age, Department department)
        {
            Name = name;
            Age = age;
            Department = department;
       }
        public override string ToString() =>
            $"Person     [Name={Name,-10} Age={Age,-4} {Department}]";

    }
}
