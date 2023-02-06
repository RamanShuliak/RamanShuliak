namespace C_SharpExperiments.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = (x, y) => x + y;

            calculator(5, 6);

            Calculator calculator1 =
                (x, y) =>
                {
                    Console.WriteLine($"Summa of two numbers = {x + y} ");
                    return x + y;
                };
        }
    }
}