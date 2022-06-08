namespace HomeTask2.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintBaseMenu();
        }

        static void PrintBaseMenu()
        {
            var numberA = RandomNumberA();
            var numberB = RandomNumberB();

            Console.WriteLine($"Now program will generate two numbers from 1 " +
                $"to 10 for next math operations{Environment.NewLine}" +
                $"" +
                $"Number A = {numberA},   Number B = {numberB}{Environment.NewLine}" +
                $"");

            Console.WriteLine("Alexei, please, select number of math operation");
            Console.WriteLine($"1. A + B{Environment.NewLine}" +
                $"2. A - B {Environment.NewLine}" +
                $"3. A * B {Environment.NewLine}" +
                $"4. A / B {Environment.NewLine}" +
                $"5. A ^ B {Environment.NewLine}" +
                $"6. A! {Environment.NewLine}");

            ChekOperationSelection();

        }

        static void ChekOperationSelection()
        {
            var enterOperation = Console.ReadLine();
            int enterOperationNew = 0;
            if (!int.TryParse(enterOperation, out enterOperationNew))
            {
                Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation();
            }
            else
            {
                OperationSelection(enterOperationNew);
            }
        }

        static void OperationSelection(int enterOperationNew)
        {
            switch (enterOperationNew)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine($"Operation with such number is not found.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");
                    MenuContinuation();
                    break;
            }
        }

        static void MenuContinuation()
        {
            Console.WriteLine($"Select, do you wont to continue?{Environment.NewLine}" +
                $"1. Yes{Environment.NewLine}" +
                $"2. No{Environment.NewLine}");

            ChekContinuationSelection();

        }

        static void ChekContinuationSelection()
        {
            var enterOperation2 = Console.ReadLine();
            int enterOperationNew2 = 0;
            if (!int.TryParse(enterOperation2, out enterOperationNew2))
            {
                Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation();
            }
            else
            {
                ContinuationSelection(enterOperationNew2);
            }
        }

        static void ContinuationSelection(int enterOperationNew2)
        {
            switch (enterOperationNew2)
            {
                case 1:
                    PrintBaseMenu();
                    break;
                case 2:
                    Console.WriteLine("Program close. Goodby!");
                    break;
                default:
                    Console.WriteLine($"Operation with such number is not found.{Environment.NewLine}" +
                   $"Please, try again{Environment.NewLine}" +
                   $"");
                    MenuContinuation();
                    break;
            }
        }

        static int RandomNumberA()
        {
            Random random = new Random();
            int nA = random.Next(1, 10);
            return nA;
        }

        static int RandomNumberB()
        {
            Random random = new Random();
            int nB = random.Next(1, 10);
            return nB;
        }
        static void Addition()
        {

        }
    }
}