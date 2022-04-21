using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP09_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic array
            // B1) Array creation

            int[] arr1 = new int[5]; // [] [] [] [] []
            double[] arr2 = new double[7]; // [] [] [] [] [] [] []
            Console.WriteLine("{0} {1}", arr1.Length, arr2.Length);

            // B2) Array creation and initialization
            float[] arr3 = new float[3] { 1.23f, 4.56f, 7.89f };
            bool[] arr4 = new bool[4] { true, false, false, true };
            long[] arr5 = new long[] { 20, 24, 89 };
            Console.WriteLine(arr5.Length);

            // B3) Writing data to array
            arr1[1] = 3; // [?] [3] [?] [?] [?]
            arr1[4] = 7; // [?] [3] [?] [?] [7]
            arr4[3] = false; // [true] [false] [false] [false]
            Console.WriteLine("{0}, {1}, {2}", arr1[1], arr1[4], arr4[3]);

            // B4) Reading data from array
            float v1 = arr3[1];
            long v2 = arr5[0];
            Console.WriteLine($"{v1}, {v2}");
            // is equal to Console.WriteLine("{0}, {1}", v1, v2);

            // B5) Print array elements using for-loop
            // B5.1) Using ToString() method
            for(int i=0; i<arr5.Length; i++)
            {
                Console.WriteLine(arr5[i].ToString());
            }

            // B5.2) Using composite formatting
            for(int i=0; i<arr3.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr3[i]);
            }

            // B5.3) Using interpolated strings
            for(int i=0; i<arr3.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr3[i]}");
            }

        }
    }
}
