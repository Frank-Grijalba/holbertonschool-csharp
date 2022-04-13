using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            int numLine = 0;
            if (length <= 0){
                Console.WriteLine("");
            }
            else{
                while (numLine < length){
                    Console.Write("_");
                    numLine++;
                }
                Console.WriteLine("");
            }
        }
    }
}
