namespace HomeTask1.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas, enter the number");
            var userNumber = Console.ReadLine();
            int userNumberNew = 0;
            if (!int.TryParse(userNumber, out userNumberNew))
            {
                Console.WriteLine("Entered data is wrong because include symbols");
            }
            else
            {
                Table(userNumberNew);
            }
            
        }
        static void Table(int userNumberNew)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{userNumberNew} * {i} = {userNumberNew * i}");
        }
    }
}