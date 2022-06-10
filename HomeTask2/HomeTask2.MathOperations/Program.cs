namespace HomeTask2.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseMenuWithRandom();
        }

        static void BaseMenuWithRandom()
        {
            var numberA = RandomNumberA();
            var numberB = RandomNumberB();
            PrintBaseMenu(numberA, numberB);
        }
        static void PrintBaseMenu(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}" +
                $"Now program will generate two numbers from 1 " +
                $"to 10 for next math operations{Environment.NewLine}" +
                $"");
            Console.WriteLine($"Number A = {numberA},   Number B = {numberB}{Environment.NewLine}");
            Console.WriteLine("");

            Console.WriteLine("Alexei, please, select number of math operation (enter 1 - 6)");
            Console.WriteLine($"1. A + B{Environment.NewLine}" +
                $"2. A - B {Environment.NewLine}" +
                $"3. A * B {Environment.NewLine}" +
                $"4. A / B {Environment.NewLine}" +
                $"5. A ^ B {Environment.NewLine}" +
                $"6. A!, B! {Environment.NewLine}");

            ChekOperationSelection(numberA, numberB);

        }

        static void ChekOperationSelection(int numberA, int numberB)
        {
            var enterOperation = Console.ReadLine();
            int enterOperationNew = 0;
            if (!int.TryParse(enterOperation, out enterOperationNew))
            {
                Console.WriteLine($"{Environment.NewLine}" +
                    $"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation(numberA, numberB);
            }
            else
            {
                OperationSelection(enterOperationNew, numberA, numberB);
            }
        }

        static void OperationSelection(int enterOperationNew, int numberA, int numberB)
        {
            switch (enterOperationNew)
            {
                case 1:
                    Addition(numberA, numberB);
                    break;
                case 2:
                    Subtraction(numberA, numberB);
                    break;
                case 3:
                    Multiplication(numberA, numberB);
                    break;
                case 4:
                    Dividing(numberA, numberB);
                    break;
                case 5:
                    Rising(numberA, numberB);
                    break;
                case 6:
                    Factorial(numberA, numberB);
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}" +
                    $"Operation with such number is not found.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");
                    MenuContinuation(numberA, numberB);
                    break;
            }
        }

        static void MenuContinuation(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}" +
                $"Select, do you wont to continue (enter 1 or 2)?{Environment.NewLine}" +
                $"1. Yes{Environment.NewLine}" +
                $"2. No{Environment.NewLine}");

            ChekContinuationSelection(numberA, numberB);

        }

        static void ChekContinuationSelection(int numberA, int numberB)
        {
            var enterOperation2 = Console.ReadLine();
            int enterOperationNew2 = 0;
            if (!int.TryParse(enterOperation2, out enterOperationNew2))
            {
                Console.WriteLine("");
                Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation(numberA, numberB);
            }
            else
            {
                ContinuationSelection(enterOperationNew2, numberA, numberB);
            }
        }

        static void ContinuationSelection(int enterOperationNew2, int numberA, int numberB)
        {
            switch (enterOperationNew2)
            {
                case 1:
                    BaseMenuWithRandom();
                    break;
                case 2:
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Program close. Goodby!");
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Operation with such number is not found.{Environment.NewLine}" +
                   $"Please, try again{Environment.NewLine}" +
                   $"");
                    MenuContinuation(numberA, numberB);
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
        static void Addition(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"A + B = {numberA + numberB}");
            MenuContinuation(numberA, numberB);
        }

        static void Subtraction(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"A - B = {numberA - numberB}");
            Console.WriteLine("");
            MenuContinuation(numberA, numberB);
        }

        static void Multiplication(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"A * B = {numberA * numberB}");
            Console.WriteLine("");
            MenuContinuation(numberA, numberB);
        }

        static void Dividing(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"A / B = {(double)numberA / numberB}");
            Console.WriteLine("");
            MenuContinuation(numberA, numberB);
        }

        static void Rising(int numberA, int numberB)
        {
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"A ^ B = {Math.Pow(numberA, numberB)}");
            Console.WriteLine("");
            MenuContinuation(numberA, numberB);
        }

        static void Factorial(int numberA, int numberB)
        {
            int factorialA = 1;
            for (int i = 1; i <= numberA; i++)
            {
                factorialA *= i;
            }

            int factorialB = 1;
            for (int x = 1; x <= numberB; x++)
            {
                factorialB *= x;
            }

            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine($"Factorial A = {factorialA}{Environment.NewLine}" +
                $"" +
                $"Factorial B = {factorialB}{Environment.NewLine}" +
                $"");
            MenuContinuation(numberA, numberB);

        }
    }
}