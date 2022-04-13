using System;

namespace _3_print_array_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            int[] array2 = null;
            int[] array3 = {};
            int[] array4 = {98, -10, 0, 972, -42};

            Array.Reverse(array1);
            Array.Reverse(array2);
            Array.Reverse(array3);
            Array.Reverse(array4);
        }
    }
}