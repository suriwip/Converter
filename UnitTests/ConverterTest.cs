using NUnit.Framework;
using TestProject.Business;

namespace UnitTests
{
    public class ConverterTest
    {
        [Test]
        public void ConverterTestSuccess()
        {
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] alphabets = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            var converter = new Converter();
            Assert.DoesNotThrow(() => converter.ConvertToDictionary(numbers, alphabets));
        }

        [Test]
        public void ConverterTestFailure()
        {
            int[] numbers = { 2, 2, 4, 5, 6, 7, 8, 9 };
            string[] alphabets = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            var converter = new Converter();
            Assert.DoesNotThrow(() => converter.ConvertToDictionary(numbers, alphabets));
        }

        [Test]
        public void ConverterTestEmptyInputArray()
        {
            int[] numbers = Array.Empty<int>();
            string[] alphabets = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            var converter = new Converter();
            Assert.DoesNotThrow(() => converter.ConvertToDictionary(numbers, alphabets));
        }
    }
}