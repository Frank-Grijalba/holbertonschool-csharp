using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last = number % 10;
        string msg = $"The last digit of {number} is {last} and ";
        if (last > 5){
            msg = msg + "is greater than 5";
	        Console.WriteLine("{0}",msg);
        }
        else if (last == 0){
            msg = msg + "is 0";
	        Console.WriteLine("{0}",msg);
        }
        else {
            msg = msg + "is less than 6 and not 0";
	        Console.WriteLine("{0}",msg);
        }
    }
}
