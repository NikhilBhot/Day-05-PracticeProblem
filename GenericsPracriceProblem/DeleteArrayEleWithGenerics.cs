using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracriceProblem
{
    public class DeleteArray1
    {
        public static T[] DeleteMethod<T>(T[] array, T elementToDelete)
        {
            int elementIndex = Array.IndexOf(array, elementToDelete);

            if (elementIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
                return array;
            }

            T[] newArray = new T[array.Length - 1];

            Array.Copy(array, 0, newArray, 0, elementIndex);
            Array.Copy(array, elementIndex + 1, newArray, elementIndex, array.Length - elementIndex - 1);

            return newArray;
        }
    }
    public class DeleteArrayEleWithGenerics
    {
        public static void WithGenericMethod()
        {
            // Example usage

            // Integer array
            int[] intArray = { 1, 2, 3, 4, 5 };
            int elementToDelete = 3;

            int[] newIntArray = DeleteArray1.DeleteMethod(intArray, elementToDelete);

            Console.WriteLine("New Integer Array:");
            foreach (int num in newIntArray)
            {
                Console.WriteLine(num);
            }

            // Double array
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double doubleElementToDelete = 4.5;

            double[] newDoubleArray = DeleteArray1.DeleteMethod(doubleArray, doubleElementToDelete);

            Console.WriteLine("New Double Array:");
            foreach (double num in newDoubleArray)
            {
                Console.WriteLine(num);
            }

            // Character array
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };
            char charElementToDelete = 'C';

            char[] newCharArray = DeleteArray1.DeleteMethod(charArray, charElementToDelete);

            Console.WriteLine("New Character Array:");
            foreach (char ch in newCharArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
