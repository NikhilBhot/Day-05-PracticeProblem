using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracriceProblem
{
    /*   Given 3 Integers find the minimum.
         Given 3 Floats find the minimum.
         Given 3 strings find the minimum.
     */
    public class MinimumFinder
    {
        public static int FindMinimum(int num1, int num2, int num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);
        }

        public static float FindMinimum(float num1, float num2, float num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);
        }

        public static string FindMinimum(string str1, string str2, string str3)
        {
            string minimum = str1;

            if (str2.CompareTo(minimum) < 0)
            {
                minimum = str2;
            }

            if (str3.CompareTo(minimum) < 0)
            {
                minimum = str3;
            }

            return minimum;
        }

        public static void FindMimimumMethod()
        {
            // Example usage

            // Find minimum among three integers
            int intMinimum = FindMinimum(10, 5, 8);
            Console.WriteLine("Minimum integer: " + intMinimum);

            // Find minimum among three floats
            float floatMinimum = FindMinimum(1.5f, 2.7f, 1.2f);
            Console.WriteLine("Minimum float: " + floatMinimum);

            // Find minimum among three strings
            string stringMinimum = FindMinimum("Apple", "Banana", "Carrot");
            Console.WriteLine("Minimum string: " + stringMinimum);
        }
    }

}
