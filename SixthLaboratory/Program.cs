using System;
using System.Collections.Generic;
using System.Linq;

namespace SixthLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>
            {
                -1, 2, 8, 4, 0, -4
            };

            int sum = 0;
            var first = array.IndexOf(array.First(f => f > 0));
            var last = array.LastIndexOf(array.Last(f => f > 0));

            for (int i = first; i <= last; i++) sum += array[i];

            //Console.WriteLine($"Сумма = {sum}");

            var array2 = new int[][]
            {
                new[] { 1, 2, -4 },
                new[] { 1, 2, 3 },
                new[] { 1, 0, 3 }
            };
            sum = 0;

            var array3 = new int[][]
            {
                new[] { 0, 0, 0 },
                new[] { 0, 0, 0 },
                new[] { 0, 0, 0 }
            };

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2[i].Length; j++)
                {
                    array3[j][i] = array2[i][j];
                }
            }

            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i].Any(a => a < 0)) continue;
                for (int j = 0; j < array3[i].Length; j++)
                {
                    Console.WriteLine($"Сумма элементов столбца {j + 1} = {array3[i].Sum()}");
                    break;
                }
            }

            var random = new Random();
            for (int i = 0; i < 3; i++)
            {
                var array4 = new List<int>();
                if (i != 2)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        array4.Add(random.Next(-10, 2));
                    }
                }
                else
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array4.Add(random.Next(-10, 2));
                    }
                }

                sum = Search(array4.ToArray());
                Console.WriteLine($"Сумма = {sum}");
                
                
            }
        }

        public static int Search(int[] array) => array.Where(a => a < 0).ToList().Sum();
    }
}