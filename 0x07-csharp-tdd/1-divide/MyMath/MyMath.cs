using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            int result = 0;
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int[,] newMatrix = new int [row, column];

            for(int i = 0; i < row ; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    try
                    {
                        result = matrix[i,j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                    finally
                    {
                        newMatrix[i,j] = result;
                    }
                }
                
            }
            return newMatrix;
        }
    }
}
