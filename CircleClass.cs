using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override string ToString() =>
            $"CircleClass [Radius={Radius}, Color={Color}]";
    }
}
