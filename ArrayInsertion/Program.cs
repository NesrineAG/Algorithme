using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInsertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array = InsertValue(array, 10, 2);

            Console.WriteLine("Array after insertion:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }

        static int[] InsertValue(int[] arr, int value, int index)
        {
            int[] newArray = new int[arr.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }

            newArray[index] = value;

            for (int i = index; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }

            return newArray;
        }


    }
}
