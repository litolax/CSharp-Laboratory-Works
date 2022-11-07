using System.Text.RegularExpressions;

namespace EigthLaboratory
{
    class Program
    {
        private static void PrintVremya()
        {
            const string time = "Текущее время 22:04:07";
            var regex = new Regex(@"(\d\d)");
            foreach (Match match in regex.Matches(time)) Console.WriteLine(match.Groups[0]);
        }

        private static void PrintData()
        {
            var time = "До конца нашего учебного кода осталось осталось 15/02/09» ";
            var regex = new Regex(@"(\d\d)");
            foreach (Match match in regex.Matches(time)) Console.WriteLine(match.Groups[0]);
        }

        static void Main(string[] args)
        {
            PrintData();
            Console.WriteLine();
            PrintVremya();
        }
    }
}