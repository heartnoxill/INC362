using System;

namespace EP11_Array_Static_methods
{
    class Program
    {
        static void PrintIntArray(int[] arr)
        {
            Console.WriteLine("*** PrintIntArray ***");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]{4, 7, 2, 1, 8, 2, 9, 5, 0, 3};
            //PrintIntArray(arr);

            // IndexOf
            int idx = Array.IndexOf(arr, 9);
            Console.WriteLine("Index of 9 in the arr is {0}", idx);

            // LastIndexOf
            int i2 = Array.LastIndexOf(arr, 2);
            Console.WriteLine("The last index of 2 in the arr is {0}", i2);

            // Sort
            PrintIntArray(arr);
            Array.Sort(arr);
            PrintIntArray(arr);

            // Reverse
            PrintIntArray(arr);
            Array.Reverse(arr);
            PrintIntArray(arr);

            // Clear
            // static void Clear(Array array, int index, int length);
            // Assume this isn't sorted yet
            PrintIntArray(arr); // {4, 7, 2, 1, 8, 2, 9, 5, 0, 3};
            Array.Clear(arr, 0, 3); // {0, 0, 0, 1, 8, 2, 9, 5, 0, 3}
            PrintIntArray(arr);
            Array.Clear(arr, 5, 2); // {0, 0, 0, 1, 8, 0, 0, 5, 0, 3}
            PrintIntArray(arr);
        }
    }
}