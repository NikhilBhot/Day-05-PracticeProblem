using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracriceProblem
{
    /* Refactor all the 3 to One Generic Method and find the minimum. Ensure
    the Generic Type extends Comparable.
    */
    public class MinimumFinderRefactor
    {
       
            public static T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
            {
                T minimum = value1;

                if (value2.CompareTo(minimum) < 0)
                {
                    minimum = value2;
                }

                if (value3.CompareTo(minimum) < 0)
                {
                    minimum = value3;
                }

                return minimum;
            }

            public static void MinimumFinderMethodRefactor()
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
