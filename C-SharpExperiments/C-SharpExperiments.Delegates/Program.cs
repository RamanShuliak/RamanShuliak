namespace C_SharpExperiments.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstMessanger = new Messanger();

            PrintMessange printMessange;

            printMessange = firstMessanger.PrintFirstMessange;
            printMessange += firstMessanger.PrintSecondMessage;

            printMessange(10);

            if(printMessange != null)
            {
                printMessange(10);
            }

            var result2 = printMessange?.Invoke(10);

            PrintMessange messanger = delegate (int number)
            {
                var messange = $"You owe {number}$ to the bank.";

                Console.WriteLine(messange);

                return messange;
            };
        }
    }
}