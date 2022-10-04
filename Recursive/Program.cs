using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Rec(5); 
            Console.WriteLine($"{result:F4}");
        }

        static double Rec(int n)
        {
            if (n < 1) return 1;
            n--;
            return 1 / (1 + Rec(n));
        }
    }
}