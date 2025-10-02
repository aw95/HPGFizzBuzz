using HPGFizzBuzzProject.Config;
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
                    output.Add("FizzBuzz");
                else if (number % FizzBuzzConfig.FizzDivisor == 0)
                    output.Add("Fizz");
                else if (number % FizzBuzzConfig.BuzzDivisor == 0)
                    output.Add("Buzz");
                else
                    output.Add(number.ToString());
            }

            return output;
        }
    }
}
