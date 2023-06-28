using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracriceProblem
{
    public class DeleteArray<T>
    {
        private T[] array;

        public DeleteArray(T[] array)
        {
            this.array = array;
        }

        public T[] DeleteMethod(T elementToDelete)
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
    public class DeleteArrayEleWithGenericClass
    {
        public static void WithGenericClass()
        {
            // Example usage

            // Integer array
            int[] intArray = { 1, 2, 3, 4, 5 };
            int elementToDelete = 3;

            DeleteArray<int> intDeleteArray = new DeleteArray<int>(intArray);
            int[] newIntArray = intDeleteArray.DeleteMethod(elementToDelete);

            Console.WriteLine("New Integer Array:");
            foreach (int num in newIntArray)
            {
                Console.WriteLine(num);
            }

            // Double array
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double doubleElementToDelete = 4.5;

            DeleteArray<double> doubleDeleteArray = new DeleteArray<double>(doubleArray);
            double[] newDoubleArray = doubleDeleteArray.DeleteMethod(doubleElementToDelete);

            Console.WriteLine("New Double Array:");
            foreach (double num in newDoubleArray)
            {
                Console.WriteLine(num);
            }

            // Character array
            char[] charArray = { 'A', 'B', 'C', 'D', 'E' };
            char charElementToDelete = 'C';

            DeleteArray<char> charDeleteArray = new DeleteArray<char>(charArray);
            char[] newCharArray = charDeleteArray.DeleteMethod(charElementToDelete);

            Console.WriteLine("New Character Array:");
            foreach (char ch in newCharArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
