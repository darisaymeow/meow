using System;


namespace lab_7
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100);
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Matrix newmatrix = new Matrix();
            (int count, int sum) = newmatrix.Operation(matrix);
            Console.Write("{0} ", count);
            Console.Write("{0} ", sum);
            Console.ReadLine();

        }
    }
}

