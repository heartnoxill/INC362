using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP04_ConsoleApp
{
    class Program
    {
        // Methods
        // 1. PrintNumber
        // 2. GenerateNumber

        static void PrintNumber(int x)
        {
            Console.WriteLine(x);
        }

        static int GenerateNumber()
        {
            Random r = new Random();
            int a = r.Next(); // Next(): returns non-negative random int
            return a;
        }

        static void Main(string[] args)
        {
            // To allow Main static function to call another function
            // Add static infront of function we would like to call
            int v1 = GenerateNumber();
            PrintNumber(v1);
            Console.ReadKey(); // Then press F5
        }
    }
}
