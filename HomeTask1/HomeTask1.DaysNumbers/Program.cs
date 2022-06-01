namespace HomeTask1.DaysNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas, enter the number from 1 to 7 to select a day of week");
            var DayNumber = Console.ReadLine();
            int DayNumberNew = 0;
            if (!int.TryParse(DayNumber, out DayNumberNew))
            {
                Console.WriteLine("Entered data is wrong because include symbols");
            }
            else
            {
                SelectDay(DayNumberNew);
            }
     
        }
        static void SelectDay(int DayNumberNew)
        {
            switch (DayNumberNew)
            {
                case 1:
                    Console.WriteLine("You select Monday");
                    break;
                case 2:
                    Console.WriteLine("You select Tuesday");
                    break;
                case 3:
                    Console.WriteLine("You select Wednesday");
                    break;
                case 4:
                    Console.WriteLine("You select Thursday");
                    break;
                case 5:
                    Console.WriteLine("You select Friday");
                    break;
                case 6:
                    Console.WriteLine("You select Saturday");
                    break;
                case 7:
                    Console.WriteLine("You select Sunday");
                    break;
                default:
                    Console.WriteLine("The are no days with such number");
                    break;
            }
        }
    }
}