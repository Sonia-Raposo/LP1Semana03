using System;

namespace PowTwoUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// It will print power of 2 of numbers 1,2,4,8,16
        /// </summary>
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1<<5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }

    }
}
