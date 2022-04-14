using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null){
            Console.WriteLine("");
        }
        else{
            for (int i = array.Length - 1; i >= 0; i--){
                if (i == 0 || array == null)
                    Console.Write("{0}", array[i]);
                else
                    Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("");
        } 
    }
}
