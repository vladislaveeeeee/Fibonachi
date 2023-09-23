using System;

namespace MyApp 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fibonacci : ");
            int fib = Convert.ToInt32(Console.ReadLine());

            if (fib < 2)
            {
                Console.WriteLine("Fibonacci sequence starts with 0 and 1.");
            }
            else
            {
                int[] arr = new int[fib];
                arr[0] = 0;
                arr[1] = 1;

                for (int i = 2; i < fib; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }

                Console.Write("Fibonacci = ");
                foreach (int num in arr)
                {
                    Console.Write($"{num}\t");
                }
            }
    }
}