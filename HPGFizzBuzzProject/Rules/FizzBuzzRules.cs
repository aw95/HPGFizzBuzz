namespace HPGFizzBuzzProject.Rules
{
    public static class FizzBuzzRules
    {
        [FizzBuzzRule]
        public static string? FizzBuzz(int n) => n % 15 == 0 ? "FizzBuzz" : null;

        [FizzBuzzRule]
        public static string? Fizz(int n) => n % 3 == 0 ? "Fizz" : null;

        [FizzBuzzRule]
        public static string? Buzz(int n) => n % 5 == 0 ? "Buzz" : null;
    }
}
