using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;

        if (size == 0){
            Console.Write('\n');
        }
        else if (size < 0){
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        int[] array = new int[size];
        for (i = 0 ; i < array.Length ; i++){
            array[i] = i;
            if (i < array.Length - 1)
                Console.Write(array[i] + " ");
            else
                Console.WriteLine(array[i]);
        }
        return(array);
    }
}
