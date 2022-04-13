using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num1=0; num1 < 9; num1++){
                for (int num2=1; num2 <= 9; num2++){
                    if (num2 > num1){
                        if (num1 == 8 && num2 == 9)
                            Console.WriteLine("{0}{1}", num1, num2);
                        else
                            Console.Write("{0}{1}, ", num1, num2);
                    }
                }
            }
        }
    }
}
