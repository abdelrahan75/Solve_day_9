using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace solve_day_9_C_
{
    internal class Program
    {
        enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        enum Grads
        {
            F = 50,
            D = 60 ,
            C = 70 ,
            B = 80,
            A = 90,
        }

        enum Gender : byte
        {
            Male = 1,
            Female = 2,
            Other = 3
        }
        static void Main(string[] args)
        {
            #region part_1

            #region problem_1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //    Console.WriteLine($"  Name: {day,-12}  Value: {(int)day}");
            #endregion

            #region problem_2
            //foreach (Grads g in Enum.GetValues(typeof(Grads)))
            //    Console.WriteLine($"  Grade: {g,-5}  Value (short): {(short)g}");
            #endregion

            #region problem_3
            //Person p1 = new Person("Alice", 30, new Department("Engineering"));
            //Person p2 = new Person("Bob", 25, new Department("Marketing"));
            //Console.WriteLine($"  {p1}");
            //Console.WriteLine($"  {p2}");
            #endregion
            #region problem_4
            //Child child = new Child(1, "Charlie", 22, 35000m, new Department("Intern"));
            //Console.WriteLine($"  {child}");
            //child.DisplaySalary();
            #endregion

            #region problem_5
            //Console.WriteLine($"  Perimeter(5, 3)  = {Utility.RectanglePerimeter(5, 3)}");
            //Console.WriteLine($"  Perimeter(8, 4)  = {Utility.RectanglePerimeter(8, 4)}");
            //Console.WriteLine("  Called without creating any Utility instance.");
            #endregion

            #region problem_6
            //ComplexNumber cn1 = new ComplexNumber(3, 2);
            //ComplexNumber cn2 = new ComplexNumber(1, 4);
            //ComplexNumber cn3 = new ComplexNumber(5, -3);
            //Console.WriteLine($"  cn1 = {cn1}");
            //Console.WriteLine($"  cn2 = {cn2}");
            //Console.WriteLine($"  cn1 + cn2 = {cn1 + cn2}");
            //Console.WriteLine($"  cn1 * cn2 = {cn1 * cn2}    (3*1-2*4) + (3*4+2*1)i = -5+14i");
            //Console.WriteLine($"  cn2 * cn3 = {cn2 * cn3}");
            #endregion

            #region Problem_7
            //Console.WriteLine($"  sizeof(int)  = {sizeof(int)} bytes  (default enum size)");
            //Console.WriteLine($"  sizeof(byte) = {sizeof(byte)} byte   (Gender enum size)");
            //Console.WriteLine($"  Memory saved per element: {sizeof(int) - sizeof(byte)} bytes");
            //foreach (Gender g in Enum.GetValues(typeof(Gender)))
            //    Console.WriteLine($"  Gender: {g,-8}  Value (byte): {(byte)g}");
            #endregion

            #region problem_8
            //double[] celsiusValues = { 0, 100, -40, 37 };
            //double[] fahrenheitValues = { 32, 212, -40, 98.6 };
            //foreach (double c in celsiusValues)
            //    Console.WriteLine($"  {c,6}°C = {Utility.CelsiusToFahrenheit(c),8:F2}°F");
            //foreach (double f in fahrenheitValues)
            //    Console.WriteLine($"  {f,6}°F = {Utility.FahrenheitToCelsius(f),8:F2}°C");
            #endregion
            #region problem_9
            //string[] inputs = { "A", "B", "Z", "3", "F", "invalid", "" };
            //foreach (string input in inputs)
            //{
            //    if (Enum.TryParse<Grads>(input, ignoreCase: true, out Grads result))
            //        Console.WriteLine($"  '{input,-10}' → Parsed successfully: {result} = {(short)result}");
            //    else
            //        Console.WriteLine($"  '{input,-10}' → Invalid input, handled gracefully.");
            //}
            #endregion

            #region problem_10
            //    Department devDept = new Department("Development");
            //    Department hrDept = new Department("HR");

            //    Employee[] employees =
            //    {
            //    new Employee(101, "Diana",  28, 60000m, devDept),
            //    new Employee(102, "Edward", 35, 80000m, hrDept),
            //    new Employee(103, "Fiona",  29, 70000m, devDept),
            //    new Employee(104, "George", 40, 90000m, hrDept),
            //};

            //    foreach (var e in employees) Console.WriteLine($"  {e}");
            #endregion

            #region problem_11
            //Console.WriteLine($"  Max(10, 25)          = {Helper.Max(10, 25)}");
            //Console.WriteLine($"  Max(3.14, 2.71)      = {Helper.Max(3.14, 2.71)}");
            //Console.WriteLine($"  Max(\"Apple\",\"Zebra\") = {Helper.Max("Apple", "Zebra")}");
            //Console.WriteLine($"  Max('A', 'Z')        = {Helper.Max('A', 'Z')}");
            #endregion

            #region problem_12
            //int[] intArr = { 1, 2, 3, 2, 4, 2, 5 };
            //Console.WriteLine($"  int[] Before: [{string.Join(", ", intArr)}]");
            //Helper2<int>.ReplaceArray(intArr, oldValue: 2, newValue: 99);
            //Console.WriteLine($"  int[] After (replace 2→99): [{string.Join(", ", intArr)}]");
            #endregion

            #region problem_15
            //Department searchDept = new Department("Development");
            //Console.WriteLine($"  Searching for department: '{searchDept.Name}'");
            //Console.WriteLine("\n  Employees in Development:");
            #endregion

            #region problem_16
            //CircleStruct cs1 = new CircleStruct(5.0, "Red");
            //CircleStruct cs2 = new CircleStruct(5.0, "Red");
            //CircleStruct cs3 = new CircleStruct(3.0, "Blue");
            #endregion

            #endregion

            #region Part_2

            #region problem_1
            //MAXimam_Reverse part_2 = new MAXimam_Reverse();

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //int[] ans = part_2.reverse(arr);
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region problme_3
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //MAXimam_Reverse.Reverse_two_item(ref arr, 1, 2);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region problem_4
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var ans = MAXimam_Reverse.Max(arr);
            Console.WriteLine(ans);

            #endregion
            #endregion
        }
    }
}
