using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

             float [,] matrix_a = new float [2, 2];
             float [,] matrix_b = new float [2, 1];

             matrix_a [0,0] = float.Parse(args[0]);
             matrix_a [0,1] = float.Parse(args[1]);
             matrix_a [1,0] = float.Parse(args[2]);
             matrix_a [1,1] = float.Parse(args[3]);

             matrix_b [0,0] = float.Parse(args[4]);
             matrix_b [1,0] = float.Parse(args[5]);
        }
    }
}
