namespace C_SharpExperiments.OperationsWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Type conversion
            var firstNumber = 15;
            Console.WriteLine($"First number = {firstNumber}. Enter the second number:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            var resultNumber = (double)firstNumber + secondNumber;
            Console.WriteLine(resultNumber);

            var x = 0.0;
            var y = 6;

            Console.WriteLine("Enter yore number: ");
            var enteredNumber = Console.ReadLine();
            var parseNumber = double.TryParse(enteredNumber, out x);

            if (parseNumber == true)
            {
                var z = x * y;
                Console.WriteLine($"x * y = {z}");
            }
            else
            {
                Console.WriteLine("Entered data are wrong");
            }

            var isEquals = x.CompareTo(y);

            var isEquals2 = x.Equals(y);

            Console.WriteLine(isEquals);

            Console.WriteLine(isEquals2);

            // Ternar operations

            var ternarNumber = isEquals2
                ? "joppa"
                : "harakiri";
            Console.WriteLine($"ternarNumber = {ternarNumber} {Environment.NewLine}");

            // Operations with methods

            var number = 15;

            var number1 = 5;

            WorkWithNumbers(number, number1);

            Console.WriteLine($"{number}_________{number1}");
        }

        static void WorkWithNumbers(int x, int y)
        {
            x += 1;

            y = 7;*/

/*            var array = new int[5];

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter the element {i}:");

                array[i] = Convert.ToInt32(Console.ReadLine());
            }*/

            var task = new TaskOfTania();

            task.CalculateAmongOfYears();
        }
    }
}