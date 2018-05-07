using System;


namespace lab_7
{
    public class Matrix
    {

        public (int,int) Operation(int[,] matrix)
        {

            int count = 0;
            int sum = 0;
            int mid = 0;
            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum =+ matrix[i,j];
                    
                }
            }
            mid = sum / matrix.GetLength(0);

            int lowerSum = 0;
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {

                    if (b > a && matrix[a, b] > mid)
                    {
                        count++;
                    }
                    if (b < a && matrix[a, b] > mid)
                    {
                        lowerSum += matrix[a, b];
                    }
                }
            }
                                  

            return (count, lowerSum);
        }
        

    }
}