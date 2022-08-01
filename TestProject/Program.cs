using Microsoft.Extensions.DependencyInjection;
using TestProject.Business.Interfaces;

namespace TestProject
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var host = Startup.CreateHostBuilder(args).Build();

            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] alphabets = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

            var result = host.Services.GetRequiredService<IConverter>().ConvertToDictionary(numbers, alphabets);
            Console.WriteLine(result?.Count);
        }
    }
}