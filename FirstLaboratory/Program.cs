using System;

namespace FirstLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, a = 0, x = 0, b = 0, z = 0, fi = 0;
            bool result = true;
            Console.WriteLine("Введите a:");
            a = double.Parse(Console.ReadLine()!);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("Введите b:");
            b = double.Parse(Console.ReadLine()!);
            Console.WriteLine("b = {0:f2}", b);
            Console.WriteLine("Введите z:");
            z = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"z = {z}");

            Console.WriteLine("Введите число от 1 до 3 для выбора 1 из функций (2x, x^2, x/3)");
            var variant = int.Parse(Console.ReadLine()!);

            switch (variant)
            {
                case 1:
                {
                    fi = 2 * x;
                    break;
                }
                case 2:
                {
                    fi = Math.Pow(x, 2);
                    break;
                }
                case 3:
                {
                    fi = x / 3;
                    break;
                }
                default:
                {
                    result = false;
                    break;
                }
            }

            //Выбор x
            switch (z)
            {
                case < 0:
                {
                    x = z;
                    break;
                }
                case >= 0:
                {
                    x = Math.Sin(z);
                    break;
                }
                default:
                {
                    result = false;
                    break;
                }
            }

            if (!result)
            {
                Console.WriteLine("Error");
                return;
            }

            //Выбор функции

            y = 0.66f * a * Math.Pow(Math.Sin(x), 2) - 3 * b / 4 * Math.Pow(Math.Cos(fi), 2);
            Console.WriteLine($"y = {y}");
        }
    }
}