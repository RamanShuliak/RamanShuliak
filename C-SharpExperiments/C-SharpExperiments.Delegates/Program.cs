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

            if (printMessange != null)
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

            Console.WriteLine(Environment.NewLine);

            DoSomthing("haha", 15, AddStrAndInt);

            Predicate<string> predicate = st => st.Equals("A");

            Console.WriteLine(predicate("B"));

            var result = DoSomthingWithFunc(5, Operation);
            Console.WriteLine(result);

            Action<int, int> action = Add;

            action += Add;


        }

        static void DoSomthing(string x, int y, Action<string, int> action) => action(x, y);

        static int DoSomthingWithFunc(int x, Func<int, int> func) => func(x);

        static int Operation(int x) => x*3;

        static void Add(int x, int y) => Console.WriteLine(x + y);

        static void AddStrAndInt(string x, int y) => Console.WriteLine(x + y);
    }
}