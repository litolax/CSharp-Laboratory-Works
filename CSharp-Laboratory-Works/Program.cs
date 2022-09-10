using CSharp_Laboratory_Works;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IFirst, First>()
            .AddSingleton<ISecond, Second>()
            .BuildServiceProvider(true);

        var first = serviceProvider.GetService<IFirst>();
        var second = serviceProvider.GetService<ISecond>();
        
        first!.FirstTask();
        second!.SecondTaskOne();
        second.SecondTaskSecond();
        second.SecondTaskThird();
    }
}