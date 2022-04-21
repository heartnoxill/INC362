using System;

namespace Quizzz
{
    class Program
    {
        public static void Main()
        {
            int[] a1 = new int[5];
            int[] a2 = new int[5];

            Array.Copy(a1, 2, a2, 0, 2);

		}
    }
}