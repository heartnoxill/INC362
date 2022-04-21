using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP08_Basic_dataGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            /*int x = rnd.Next();
            int y = rnd.Next();

            Console.WriteLine("{0}, {1}", x, y);

            double d1 = rnd.NextDouble();
            double d2 = rnd.NextDouble();
            // Console.WriteLine("{0}, {1}", d1, d2);
            Console.WriteLine("{0:0.000}, {1:0.00000}", d1, d2);*/

            /*int a1 = rnd.Next(2); // can either get 0 or 1
            // Return a non-negative random interger that is less than the specified maximum
            Console.WriteLine("{0}", a1);*/

            for(int i=0; i<20; i++)
            {
                int a2 = rnd.Next(1, 4);
                Console.WriteLine("{0}", a2);
            }

            // rnd.Sample(); // Only in .NET Framework 5

            // Console.ReadKey();
        }
    }
}
