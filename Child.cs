using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace solve_day_9_C_
{
    internal class Child : Employee
    {
        public sealed override decimal Salary { get; set; }

        public Child(int id, string name, int age, decimal salary, Department department)
            : base(id, name, age, salary, department) { }

        public void DisplaySalary()
        {
            Console.WriteLine($"  {Name}'s Salary (sealed property): {Salary:C}");
        }

        public override string ToString() =>
            $"Child      [Id={Id} Name={Name} Age={Age} Salary={Salary} ,  {Department}]";
    }
}
