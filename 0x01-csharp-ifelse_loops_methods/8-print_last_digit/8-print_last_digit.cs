using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            if (number < 0){
                number = Math.Abs(number);
            }
            int lastDigit = number % 10;
            Console.Write("{0}", lastDigit);
            return lastDigit;
        }
    }
}
