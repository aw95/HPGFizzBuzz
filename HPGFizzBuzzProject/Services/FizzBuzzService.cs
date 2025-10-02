using HPGFizzBuzzProject.Rules;
using HPGFizzBuzzProject.Services.Interfaces;
using System.Reflection;
namespace HPGFizzBuzzProject.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly List<MethodInfo> _ruleMethods;

        public FizzBuzzService()
        {
            _ruleMethods = typeof(FizzBuzzRules)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.GetCustomAttribute<FizzBuzzRuleAttribute>() != null)
                .ToList();
        }

        public List<string> GetFizzBuzzOutput(List<int> numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));

            return numbers.Select(n =>
            {
                foreach (var method in _ruleMethods)
                {
                    var result = method.Invoke(null, new object[] { n }) as string;
                    if (!string.IsNullOrEmpty(result))
                        return result;
                }

                return n.ToString();
            }).ToList();
        }
    }
}
