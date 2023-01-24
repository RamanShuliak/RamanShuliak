namespace C_SharpExperiments.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var roman = new User()
            {
                Name = "Roman",
                Age = 25
            };

            var roman2 = new User()
            {
                Name = "Roman",
                Age = 25
            };

            Console.WriteLine(roman == roman2);
        }
    }
}