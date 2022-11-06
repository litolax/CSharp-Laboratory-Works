using System;
using System.Linq;

namespace SeventhLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            // First();
            // Second();
            // Third();
            Fourth();
            Console.ReadKey();
        }

        static void First()
        {
            var text = "Аврора будет ходить по Атомным станциям и находить там мало доллар";
            var words = text.Split(' ').ToList();
            var countsWordsWithA = words.Count(w => w.StartsWith("А"));
            Console.WriteLine($"Количество слов начинающихся с А: {countsWordsWithA}");
            var countsWordsWithLittle = words.Count(w => w.ToLowerInvariant() == "мало");
            Console.WriteLine($"Количество слов мало: {countsWordsWithLittle}");
            var newText = text.Replace("доллар", "рубль");
            Console.WriteLine($"Новый текст: {newText}");
        }

        static void Second()
        {
            var textBefore = "Это предложение. без больших букв. и оно для тестирование. программы сделано";
            var words = textBefore.Split(' ').ToList();
            var countsWordsWithA = words.Count(w => w.StartsWith("А"));

            var arr = textBefore.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length && arr[i] == '.')
                {
                    arr[i + 2] = arr[i + 2].ToString().ToUpperInvariant().ToCharArray()[0];
                }
            }

            var textAfter = new string(arr);
            Console.WriteLine($"Текст после: {textAfter}");
        }

        static void Third()
        {
            var textBefore = "Я Юра и я делаю лабораторную, помогите";
            var arr = textBefore.ToCharArray().ToList();
            arr.RemoveRange(0, arr.Count - 7);
            arr.Sort();
        }

        static void Fourth()
        {
            var textBefore = "a aabbb gg";
            var uniqueSymbols = string.Join("", textBefore.Distinct());
            foreach (var element in uniqueSymbols)
            {
                Console.WriteLine($"Символ: {element}, встречается {textBefore.Count(e => e.Equals(element))}");
            }

            var spaceCounts = textBefore.Count(e => e.Equals(' '));
            Console.WriteLine($"Количество пробелов в строке: {spaceCounts}");
        }
    }
}