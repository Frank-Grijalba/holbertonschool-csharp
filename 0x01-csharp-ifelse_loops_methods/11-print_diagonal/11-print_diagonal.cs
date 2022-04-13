using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0){
                Console.Write("\n");
            }
            else{
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (i > j)
                            Console.Write(" ");
                    }
                    Console.Write("\\");
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
        }
    }
}
