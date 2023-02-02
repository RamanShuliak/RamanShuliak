namespace C_SharpExperiments.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstMessanger = new FirstMessanger();

            PrintMessange printMessange;

            printMessange = firstMessanger.PrintFirstMessange;

            printMessange();
        }
    }
}