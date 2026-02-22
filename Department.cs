using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Department
    {
        public string Name { get; set; }

        public Department(string name) { Name = name; }

        // Overriding Equals improves search accuracy in SearchArray
        public override bool Equals(object obj) =>
            obj is Department other && Name == other.Name;

        public override int GetHashCode() => HashCode.Combine(Name);

        public override string ToString() => $"Department: {Name}";
    }
}
