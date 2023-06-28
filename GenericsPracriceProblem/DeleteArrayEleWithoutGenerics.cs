using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracriceProblem
{
    //Given an array of Integer, Double and Character, write a program to delet the element
    //- Create DeleteArray class and define DeleteMethod to delete corresponding element from the array.
    public class DeleteArrayEleWithoutGenerics
    {
        public static void WithoutGenericMethod()
        {
            // Example usage

            // Integer array
            int[] intArray = { 1, 2, 3, 4, 5 };
            int elementToDelete = 3;

            int[] newIntArray = DeleteArray.DeleteMethod(intArray, elementToDelete);

            Console.WriteLine("New Integer Array:");
            foreach (int num in newIntArray)
            {
                Console.WriteLine(num);
            }

            // Double array
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double doubleElementToDelete = 4.5;

            double[] newDoubleArray = DeleteArray.DeleteMethod(doubleArray, doubleElementToDelete);

            Console.WriteLine("New Double Array:");
            foreach (double num in newDoubleArray)
            {
                Console.WriteLine(num);
            }

            // Character array
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };
            char charElementToDelete = 'C';

            char[] newCharArray = DeleteArray.DeleteMethod(charArray, charElementToDelete);

            Console.WriteLine("New Character Array:");
            foreach (char ch in newCharArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
    public class DeleteArray
    {
        public static int[] DeleteMethod(int[] array, int elementToDelete)
        {
            int elementIndex = Array.IndexOf(array, elementToDelete);

            if (elementIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            Array.Copy(array, 0, newArray, 0, elementIndex);
            Array.Copy(array, elementIndex + 1, newArray, elementIndex, array.Length - elementIndex - 1);

            return newArray;
        }

        public static double[] DeleteMethod(double[] array, double elementToDelete)
        {
            int elementIndex = Array.IndexOf(array, elementToDelete);

            if (elementIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
                return array;
            }

            double[] newArray = new double[array.Length - 1];

            Array.Copy(array, 0, newArray, 0, elementIndex);
            Array.Copy(array, elementIndex + 1, newArray, elementIndex, array.Length - elementIndex - 1);

            return newArray;
        }

        public static char[] DeleteMethod(char[] array, char elementToDelete)
        {
            int elementIndex = Array.IndexOf(array, elementToDelete);

            if (elementIndex == -1)
            {
                Console.WriteLine("Element not found in the array.");
                return array;
            }

            char[] newArray = new char[array.Length - 1];

            Array.Copy(array, 0, newArray, 0, elementIndex);
            Array.Copy(array, elementIndex + 1, newArray, elementIndex, array.Length - elementIndex - 1);

            return newArray;
        }
    }

}
