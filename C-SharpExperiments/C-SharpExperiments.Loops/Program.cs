namespace C_SharpExperiments.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Here start the Loops");

            PrintBandData("Dream Theatre", 18, "InsideOutMusic");

            PrintBandData("Powerwolf", 8);

/*            var number = 1;

            while (number > 0)
            {
                number++;
                Console.WriteLine(number);
                if (number == 153)
                {
                    break;
                }
            }*/
            

        }
        static void PrintBandData(string bandName, int numberOfAlbums, string labelName = "NapalmRecords")
        {
            Console.WriteLine($"Band - {bandName}{Environment.NewLine}" +
                              $"Albums - {numberOfAlbums}{Environment.NewLine}" +
                              $"Label - {labelName}{Environment.NewLine}");
        }
    }
}