using HPGFizzBuzzProject.Services;
using HPGFizzBuzzProject.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
                            .AddScoped<IFizzBuzzService, FizzBuzzService>()
                            .BuildServiceProvider();

        var fizzBuzzService = serviceProvider.GetRequiredService<IFizzBuzzService>();

        var numbers = Enumerable.Range(1, 100).ToList();
        var output = fizzBuzzService.GetFizzBuzzOutput(numbers);

        output.ForEach(Console.WriteLine);
    }
}