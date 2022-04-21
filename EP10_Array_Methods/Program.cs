using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP10_Array_Methods
{
    class Program
    {
        // This method receives an array of integer and prints all elements of the received array
        static void PrintIntArray(int[] arr)
        {
            Console.WriteLine("*** PrintIntArray ***");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
        static void Main(string[] args)
        {
            // Methods of array
            int[] aar = new int[] { 4, 7, 2, 1 };
            PrintIntArray(aar);
            // "arr" in Main is the name that we will input to the function above

            // M1) CopyTo
            // public void CopyTo (Array array, int index);

            // int[] a1 = new int[aar.Length];
            // aar.CopyTo(a1, 0); // Starts copying at index 0 -> 0 1 2 3
            // aar.CopyTo(a1, 2); // Starts copying at index 2 -> 2 3 ...
            // It will exceed the length of a1[]
            // Therefore we'll increase size of a1

            int[] a1 = new int[aar.Length+2];
            aar.CopyTo(a1, 2);
            PrintIntArray(a1); // [0] [1] will be 0

            // M2) Clone
            // public object Clone();

            // int[] a2 = (int[])aar.Clone(); // specify datatype
            // PrintIntArray(a2);

            var a2 = aar.Clone(); // Didn't specify datatype
            PrintIntArray((int[])a2);

            // M3) GetType
            // public Type GetType();

            float[] arr3 = new float[2];
            Type type = a2.GetType();
            Type typef = arr3.GetType();
            Console.WriteLine("*** GetType ***");
            Console.WriteLine("{0}, {1}, {2}", type.Name, type.FullName, type.IsClass);
            Console.WriteLine("{0}, {1}, {2}", typef.Name, typef.FullName, typef.IsClass);
            // Float -> Single[] -> Single-Precision of Real-Number
            // Double -> Double[] -> Double-Precision of Real-Number

            // M4) Equals
            // public virtual bool Equals (object? obj);
            // PrintIntArray(a1);
            // PrintIntArray((int[])a2);

            bool eql = a1.Equals(a2);
            Console.WriteLine("a1 == a2 ? {0}", eql);

            int[] a3 = a1;
            a3[1] = 99; // a3 will always = a1
            a1[0] = 123; // a1 changes, a3 changes too
            PrintIntArray(a1);
            PrintIntArray(a3);
            bool eql2 = a1.Equals(a3);
            Console.WriteLine("a1 == a2 ? {0}", eql2);

            // M5) SetValue, GetValue
            // public void SetValue (object? value, int index);
            PrintIntArray(aar);
            aar.SetValue(90, 0); // Set 90 to index 0
            // cannot set the index that is out of range
            PrintIntArray(aar);

            int v1 = (int)aar.GetValue(1); // get value from index 1
            Console.WriteLine("v1 = {0}", v1);
        }
    }
}
