using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {

             //matrixes
             float [,] matrix_a = new float [2, 2];
             float [,] matrix_b = new float [2, 1];


             //matrix a
             matrix_a [0,0] = float.Parse(args[0]);
             matrix_a [0,1] = float.Parse(args[1]);
             matrix_a [1,0] = float.Parse(args[2]);
             matrix_a [1,1] = float.Parse(args[3]);

             // matrix b
             matrix_b [0,0] = float.Parse(args[4]);
             matrix_b [1,0] = float.Parse(args[5]);



            for(int i = 0; i < 2; i++)
            {
                float result = 0F;

                for(int j = 0; j < 2 ; j++)
                {
                    //matrix multiplication
                    result += matrix_a[i, j] * matrix_b[j, 0];
                }

                Console.WriteLine(result);
            }
        }
    }
}
