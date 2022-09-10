namespace CSharp_Laboratory_Works;

public interface ISecond
{
    void SecondTaskOne();
    void SecondTaskSecond();
    void SecondTaskThird();
}

public class Second : ISecond
{
    public void SecondTaskOne()
    {
        Console.WriteLine("Введите сторону а");
        double a = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите сторону b");
        double b = double.Parse(Console.ReadLine()!);

        double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        double s = a * b;
        double p = 2 * (a + b);

        Console.WriteLine($"D = {d}");
        Console.WriteLine($"S = {s}");
        Console.WriteLine($"P = {p}");
    }

    public void SecondTaskSecond()
    {
        Console.WriteLine("Введите X");
        double x = double.Parse(Console.ReadLine()!);
        double y = 3 * x * 6 - 6 * x * 2 - 7;
        Console.WriteLine($"Y = {y}");
    }

    public void SecondTaskThird()
    {
        Console.WriteLine("Введите сторону a");
        double a = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите высоту h");
        double h = double.Parse(Console.ReadLine()!);
        
        double SBock = 3 * 0.5f * a * h;
        double Sosn = a * 2 * Math.Sqrt(3) / 4;
        double S = Sosn + SBock;
        
        Console.WriteLine($"S = {S}");

        double v = 0.33f * Sosn * h;
        Console.WriteLine($"V = {v}");
    }
}