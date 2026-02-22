using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Employee : Person
    {
        public int Id { get; set; }
        public virtual decimal Salary { get; set; }

        public Employee(int id, string name, int age, decimal salary, Department department)
            : base(name, age, department)
        {
            Id = id;
            Salary = salary;
        }

        public override bool Equals(object obj) =>
        obj is Employee other && Id == other.Id && Name == other.Name;

        public override string ToString() =>
       $"Employee   [Id={Id} Name={Name} Age={Age} Salary={Salary} , {Department}]";
    }

}

