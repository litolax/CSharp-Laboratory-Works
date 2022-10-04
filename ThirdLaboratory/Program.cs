using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, n;
            Input(out a, out b, out h, out n);

            for (double i = a; i <= b; i += h)
            {
                var Sx = CalculateSx(n, i);
                double Yx = CalculateYx(i);
                double SxYx = Math.Abs(Yx - Sx);
                Console.WriteLine($"x: {i:F4}, Sx: {Sx:F4}, Yx: {Yx:F4}, SxYx: {SxYx:F4}");
            }


            a = -1.9f;
            b = 2.7f;
            h = 0.3f;

            double lastContent = 0;
            bool up = false;
            int index = 0;
            double min = 0;
            double max = 0;
            List<double> values = new();
            for (double i = a; i <= b; i += h)
            {
                double Yx = ((Math.Pow(i, 2) / 4) + (i / 2) - 3) * Math.Pow(Math.E, i / 2);
                if (Yx > lastContent) up = true;
                else up = false;
                lastContent = Yx;
                index++;
                values.Add(Yx);
                Console.WriteLine($"Index: {index}, Yx: {Yx:F4}, {(up ? "Возрастает" : "Убывает")}");
            }


            Console.WriteLine($"Max: {values.Max()}");
            Console.WriteLine($"Min: {values.Min()}");
        }

        static void Input(out double a, out double b, out double h, out double n)
        {
            Console.WriteLine("Введите a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            n = double.Parse(Console.ReadLine());
        }

        static double CalculateSx(double n, double i)
        {
            double Sx = 0;
            for (int k = 0; k < n; k++)
            {
                Sx += ((2 * k + 1) / Factorial(k)) * (Math.Pow(i, 2 * k));
            }

            return Sx;
        }

        static double CalculateYx(double i)
        {
            return (1 + Math.Pow(2 * i, 2)) * Math.Pow(Math.E, Math.Pow(i, 2));
        }

        static double Factorial(double a)
        {
            return Enumerable.Range(1, (int)a).Aggregate(1, (p, item) => p * item);
        }
    }
}