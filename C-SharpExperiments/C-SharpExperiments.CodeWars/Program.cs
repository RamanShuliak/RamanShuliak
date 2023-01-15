namespace C_SharpExperiments.CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Task:{Environment.NewLine}" +
                              $"Given a non-empty array of integers, " +
                              $"return the result of multiplying the values together in order.{Environment.NewLine}" +
                              $"Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24");

            Grow();
        }
        public static int Grow()
        {
            int[]x = new[] { 1, 2, 3, 4 };

            var number = 1;

            for (int i = 0; i < x.Length; i++)
            {
                number = number * x[i];
            }
            
            Console.WriteLine($"[1, 2, 3, 4] => 1 * 2 * 3 * 4 ={number}");

            return number;


        }
    }
}