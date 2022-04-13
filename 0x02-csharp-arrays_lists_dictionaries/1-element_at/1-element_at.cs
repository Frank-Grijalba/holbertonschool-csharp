using System;

namespace _1_element_at
{
    class Array
    {
        public static int elementAt(int[] array, int index)
        {
            
            if (index > array.Length || index < 0){
                Console.WriteLine("Index out of range");
                return -1;
            }
                
            int value = array[index];
            return value;
        }
    }
}
