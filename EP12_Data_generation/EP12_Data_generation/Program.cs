using System;

namespace EP12_Data_generation
{
    class Program
    {
        // 1) Integer data generation
        // nElements=5 -> default parameter
        // so int[] a1 = GenerateIntData(3,6) will have nElements=5 by default
        static int[] GenerateIntData(int minVal, int maxVal, int nElements=5)
        {
            Random rnd = new Random();
            int[] arr = new int[nElements];
            for(int i = 0; i < arr.Length; i++)
            {
                //arr[i] = rnd.Next(5); // 5 = random number < 5
                //arr[i] = rnd.Next(maxVal);
                arr[i] = rnd.Next(minVal, maxVal);
            }
            return arr;
        }

        // 2) Floating-point data generation
        static double[] GenerateDblData(double minVal, double maxVal, int nElements)
        {
            Random rnd = new Random();
            double[] arr = new double[nElements];
            for(int i=0; i < arr.Length; i++)
            {
                // e.g., if minVal=2.0, maxVal=5.0, 2.0<->5.0 = 3.0; max-min=3.0
                // double x = rnd.NextDouble() * 3; //rnd.NextDouble() -> 0-1 *3 -> 0-3
                double x = rnd.NextDouble() * (maxVal - minVal); // x=[0,3] 
                x = x + minVal; // x=[0,3] + 2 -> [2,5}, 2 is minVal
                arr[i] = x;
            }
            return arr;
        }

        // 3) Boolean data generation
        static bool[] GenerateBoolData(int nElements=10)
        {
            Random rnd = new Random();
            bool[] arr = new bool[nElements];
            for(int i=0; i < arr.Length; i++)
            {
                int i01 = rnd.Next(0, 2);
                //if (i01 < 0)
                //{
                //    arr[i] = true;
                //}
                //else
                //{
                //    arr[i] = false;
                //}
                arr[i] = i01 > 0;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] a1 = GenerateIntData(3, 6, 20);
            double[] a2 = GenerateDblData(1.0, 3.0, 10);
            bool[] a3 = GenerateBoolData();

            for(int i=0; i<a1.Length; i++)
            {
                //Console.WriteLine("arr[{0}] = {1}", i, a1[i]);
                //Console.WriteLine("arr[{0}] = {1}", i, a2[i]);
                Console.WriteLine("arr[{0}] = {1}", i, a3[i]);
            }
        }
    }
}