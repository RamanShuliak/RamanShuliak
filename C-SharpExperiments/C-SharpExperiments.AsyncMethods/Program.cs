namespace C_SharpExperiments.AsyncMethods
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var asyncSample = new AsyncMethodSample();

            var result = await asyncSample.CalculateSumAsync(34, 81);

            Console.WriteLine($"Result of addition = {result}");
        }
    }
}