namespace HomeTask1.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas, enter the number");
            var UserNumber = Console.ReadLine();

            if (!int.TryParse(UserNumber, out int UserNumberNew))
            {
                Console.WriteLine("Entered data is wrong because include symbols");
            }
            else
            {
                Table(UserNumberNew);
            }
            
        }
        static void Table(int UserNumberNew)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{UserNumberNew} * {i} = {UserNumberNew * i}");
        }
    }
}