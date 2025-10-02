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
            List<string> output = new List<string>();

            foreach (int number in numbers)
            {
                if (number % FizzBuzzConfig.FizzDivisor == 0 && number % FizzBuzzConfig.BuzzDivisor == 0)
                    output.Add(FizzBuzzValue.FizzBuzz.ToString());
                else if (number % FizzBuzzConfig.FizzDivisor == 0)
                    output.Add(FizzBuzzValue.Fizz.ToString());
                else if (number % FizzBuzzConfig.BuzzDivisor == 0)
                    output.Add(FizzBuzzValue.Buzz.ToString());
                else
                    output.Add(number.ToString());
            }

            return output;
        }
    }
}
