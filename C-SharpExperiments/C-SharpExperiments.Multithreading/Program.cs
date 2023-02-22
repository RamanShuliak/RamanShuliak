using System.Diagnostics;

namespace C_SharpExperiments.Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var thread = new ThreadSample();

            //thread.CreateThread();

            //for (var i = 0; i<=10; i++)
            //{
            //    var client = new SemaphoreSample(i);
            //}

            var tasks = new TaskSample();

            //tasks.DoTasks();

            //tasks.DoInnerTask();

            //tasks.DoAllTasks();

            //tasks.DoGenericTask();

            //var random = new Random();

            var list = GenerateList();

            var timer = new Stopwatch();

            timer.Start();
            tasks.DoOperationSynchronously(list);
            timer.Stop();
            var time1 = timer.ElapsedMilliseconds;

            timer.Restart();
            tasks.DoOperationByTasksContinueWith(list);
            timer.Stop();
            var time2 = timer.ElapsedMilliseconds;

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Synchronic method work during {time1} milliseconds");
            Console.WriteLine($"Task method work during {time2} milliseconds");
        }

        static List<int> GenerateList()
        {
            var list = new List<int>();

            var random = new Random();

            for (var i = 1; i <= 1000; i++)
            {
                var number = random.Next();

                list.Add(number);
            }

            return list;
        }
    }
}