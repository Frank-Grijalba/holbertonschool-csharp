using System;
using System.Collections.Generic;


namespace _1_common_elements
{
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            List<int> myList1 = new List<int>() {1, 3, 4, 5, 6, 2};
            List<int> myList2 = new List<int>() {0, 2, 4, 6, 5, 8};
            List<int> newList = new List<int>();

            newList = List.CommonElements(myList1, myList2);

            foreach (int i in newList)
                Console.WriteLine(i);
        }
    }
}
