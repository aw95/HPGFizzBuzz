using HPGFizzBuzzProject.Services;
using HPGFizzBuzzProject.Services.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = Enumerable.Range(1, 100).ToList();

        var fizzBuzzService = new FizzBuzzService();

        var result = fizzBuzzService.GetFizzBuzzOutput(numbers);

        result.ForEach(Console.WriteLine);
    }
}