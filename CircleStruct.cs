using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public static bool operator ==(CircleStruct a, CircleStruct b) =>
            a.Radius == b.Radius && a.Color == b.Color;

        public static bool operator !=(CircleStruct a, CircleStruct b) =>
            !(a == b);

    }
}
