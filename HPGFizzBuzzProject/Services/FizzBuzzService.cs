using HPGFizzBuzzProject.Config;
using HPGFizzBuzzProject.Enums;
using HPGFizzBuzzProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPGFizzBuzzProject.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> GetFizzBuzzOutput(List<int> numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));

            return numbers.Select(number =>
            {
                return (number % FizzBuzzConfig.FizzDivisor, number % FizzBuzzConfig.BuzzDivisor) switch
                {
                    (0, 0) => FizzBuzzValue.FizzBuzz.ToString(),
                    (0, _) => FizzBuzzValue.Fizz.ToString(),
                    (_, 0) => FizzBuzzValue.Buzz.ToString(),
                    _ => number.ToString()
                };
            }).ToList();
        }
    }
}
