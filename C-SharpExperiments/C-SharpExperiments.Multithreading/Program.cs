namespace C_SharpExperiments.Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            var thread = new ThreadSample();

                        thread.CreateThread();*/

            for (var i = 0; i<=10; i++)
            {
                var client = new SemaphoreSample(i);
            }
        }
    }
}