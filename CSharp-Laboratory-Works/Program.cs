using CSharp_Laboratory_Works;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IFirst, First>()
            .BuildServiceProvider(true);

        var first = serviceProvider.GetService<IFirst>();
        first!.FirstTask();
    }
}