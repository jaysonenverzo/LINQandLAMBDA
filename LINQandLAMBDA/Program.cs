using System;

namespace LINQAndLAMBDA
{
    class Program
    {
       public static void Main (string[] args)
        {
            var numbers = new[] { 5, 6, 2, 9, 1 };

            //Using Loop and If-else
            var evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if(number  % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            Console.WriteLine("Foreach and If");
           foreach (var even in numbers)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("******************");
            Console.WriteLine("LINQ");

            //using LINQ
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            foreach (var even in linqEvenNumbers) ;
            Console.WriteLine("even");
        }
    }
}