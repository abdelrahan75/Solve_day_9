using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class Utility
    {
        public static double RectanglePerimeter(double length, double width) =>
        2 * (length + width);

      
        public static double CelsiusToFahrenheit(double celsius) =>
            celsius * 9.0 / 5.0 + 32;

        public static double FahrenheitToCelsius(double fahrenheit) =>
            (fahrenheit - 32) * 5.0 / 9.0;
    }
}
