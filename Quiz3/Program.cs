using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[] RealDataArray = new double[32];
            long index=4;
            for (index = 8; index > 2; index -= 2)
            {
                RealDataArray[index] = index % 2;
            }
            Console.WriteLine("{1}, {0}", index, RealDataArray[index]);*/

            double[] array = new double[8];
            for(int i =0; i<array.Length; i++)
            {
                array[i] = 0.0;
            }
            array.SetValue(8,5);
            double avg = 0.0;
            for(int i =array.Length-1; i>=0; i--)
            {
                avg += array[i];
            }
            avg /= array.Length;
            Console.WriteLine("{0}" ,array[0]);


        }
    }
}
