using System;

namespace _0_dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Rating rating;

            rating = Rating.Good;

            Console.WriteLine("Score: " + rating);
            Console.WriteLine("Score: " + (int)rating);
        }
    }
}
