using HPGFizzBuzzProject.Services;
using HPGFizzBuzzProject.Services.Interfaces;


namespace HPGFizzBuzzProject.Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly IFizzBuzzService _service;

        public FizzBuzzServiceTests()
        {
            _service = new FizzBuzzService();
        }

        [Fact]
        public void GetFizzBuzzOutput_ShouldReturnFizz()
        {
            // Arrange
            var input = new List<int> { 3 };

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            var expected = new List<string> { "Fizz" };
            Assert.Equal(expected, result);
        }
    }
}
