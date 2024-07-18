using NUnit.Framework; // Ensure NUnit framework is referenced
using FizzBuzz;

namespace FizzBuzz.Tests
{

    public class FizzBuzzGeneratorTests
    {
        [Test]
        public void ShouldReturnOneAsTest_WhenOneIsSpecified()
        {
            string fizzBuzzResult = FizzBuzzGenerator.Generate(1);
            Assert.(fizzBuzzResult).IsEqualTo("1");
        }
    }
}