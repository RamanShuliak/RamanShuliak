namespace C_SharpExperiments.Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread = new ThreadSample();

            thread.CreateThread();
        }
    }
}