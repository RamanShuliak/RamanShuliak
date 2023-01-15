namespace C_SharpExperiments.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 346;

            Swap<int>(ref x, ref y);

            var str = "Microsoft";
            var str2 = "RockStar";

            Swap<string>(ref str, ref str2);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}