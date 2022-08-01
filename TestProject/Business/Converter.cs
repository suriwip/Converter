using TestProject.Business.Interfaces;

namespace TestProject.Business
{
    /// <summary>
    /// Converter class
    /// </summary>
    public class Converter : IConverter
    {
        /// <summary>
        /// This method will convert to dictionary based on input types provided.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Dictionary of T1, T2</returns>
        public Dictionary<T1, T2> ConvertToDictionary<T1, T2>(T1[] first, T2[] second)
        {
            Dictionary<T1, T2> result = new();
            if (!first.Any() || !second.Any())
                return result;
            try
            {
                result = first.Zip(second, (key, value) => new { key, value }).ToDictionary(d => d.key, d => d.value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
