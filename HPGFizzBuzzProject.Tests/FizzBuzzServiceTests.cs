using HPGFizzBuzzProject.Services;
using HPGFizzBuzzProject.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HPGFizzBuzzProject.Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly IFizzBuzzService _service;

        public FizzBuzzServiceTests()
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IFizzBuzzService, FizzBuzzService>()
                .BuildServiceProvider();

            _service = serviceProvider.GetRequiredService<IFizzBuzzService>();
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

        [Fact]
        public void GetFizzBuzzOutput_ShouldReturnBuzz()
        {
            // Arrange
            var input = new List<int> { 5 };

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            var expected = new List<string> { "Buzz" };
            Assert.Equal(expected, result);
        }


        [Fact]
        public void GetFizzBuzzOutput_ShouldReturnFizzBuzz()
        {
            // Arrange
            var input = new List<int> { 15 };

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            var expected = new List<string> { "FizzBuzz" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetFizzBuzzOutput_EmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            var input = new List<int>();

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetFizzBuzzOutput_NonMatchingNumbers_ShouldReturnNumberValue()
        {
            // Arrange
            var input = new List<int>() { 1, 2, 4, 7 };

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            var expected = new List<string> { "1", "2", "4", "7" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetFizzBuzzOutput_NegativeNumbers_ShouldHandleCorrectly()
        {
            // Arrange
            var input = new List<int> { -3, -5, -15, -1 };

            // Act
            var result = _service.GetFizzBuzzOutput(input);

            // Assert
            var expected = new List<string> { "Fizz", "Buzz", "FizzBuzz", "-1" };
            Assert.Equal(expected, result);
        }
    }
}
