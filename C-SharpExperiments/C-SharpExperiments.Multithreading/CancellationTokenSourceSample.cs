using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class CancellationTokenSourceSample
    {
        public void DoPow()
        {
            using(var cts = new CancellationTokenSource())
            // Создаём объект источника токенов
            {
                var token = cts.Token;
                // Создаём токен

                var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                var task = new Task(() =>
                {
                    foreach(var i in intList)
                    {
                        if (Math.Pow(i, 2) > 50)
                        {
                            cts.Cancel();
                            // Передаём команду остановки через токен
                        }

                        if (token.IsCancellationRequested)
                        // token.IsCancellationRequested = true,
                        // если получена команда остановки
                        {
                            Console.WriteLine("Execution has been canceled");
                            return;
                        }

                        Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
                        Thread.Sleep(200);
                    }
                }, token);// Присоединяем токен к таску

                task.Start();

                while (!task.IsCompleted)
                {
                }

                Console.WriteLine(task.Status);

            }
        }
    }
}
