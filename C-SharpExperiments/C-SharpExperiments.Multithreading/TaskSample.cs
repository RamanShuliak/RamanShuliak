using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class TaskSample
    {
        public void DoTasks()
        {
            var task = new Task(() => Console.WriteLine("Task start"));
            task.Start();

            var task0 = new Task(() => Console.WriteLine("Task start0"));
            task0.RunSynchronously();

            // Only one task need to start. Others tasks will be started automatically.

            var task1 = Task.Factory.StartNew(() => Console.WriteLine("Task1 start"));

            var task2 = Task.Run(() => Console.WriteLine("Task2 start"));

            task.Wait();
            task1.Wait();
            task2.Wait();
            // Without method .Wait() task will't start and work.
            // All the tasks needs method .Wait().
        }

        public void DoInnerTask()
        {
            var outerTask = new Task(() =>
            {
                Console.WriteLine("OuterTask started");

                var innerTask = new Task(() =>
                {
                    // Some logic here
                }, TaskCreationOptions.AttachedToParent);

                innerTask.Start();
                Console.WriteLine("OuterTask ended");
            });
            outerTask.Start();
            outerTask.Wait();

            Console.WriteLine("Method DoInnerTask ended");

            Console.WriteLine("InnerTask started");
            Thread.Sleep(1000);
            Console.WriteLine("InnerTask ended");
        }

        public void DoAllTasks()
        {
            var tasks = new List<Task>()
            {
                new Task(() =>
                {
                    Console.WriteLine("First task");
                    Thread.Sleep(1000);
                }),

                new Task(() =>
                {
                    Console.WriteLine("Second task");
                    Thread.Sleep(1000);
                }),

                new Task(() =>
                {
                    Console.WriteLine("Third task");
                    Thread.Sleep(1000);
                }),
            };

            foreach (var task in tasks)
            {
                task.Start();
            }

            foreach (var task in tasks)
            {
                task.Wait();
            }

            Console.WriteLine("Method ended");
        }

        public void DoGenericTask()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var resultList = new List<int>();

            foreach (var number in list)
            {
                foreach (var number1 in list)
                {
                    var multiplyTask = Task<int>.Run(() => Multiply(number, number1));
                    // Создаём кучу generic-тасков, запускающих параллельно метод умножения

                    resultList.Add(multiplyTask.Result);
                    // Загоняем результат тасков в лист
                }
            }
        }

        public void DoOperationByTasksContinueWith(List<int> numbersList)
        {
            var newNumbersList = new List<int>();
         
            foreach(var number in numbersList)
            {
                var task = new Task(() => ChekNumberIsExist(number));
                var task1 = task.ContinueWith(t => MultiplyAndCreateList(number, newNumbersList));
                task.Start();
                task.Wait();
            }

        }

        public void DoOperationSynchronously(List<int> numbersList)
        {
            var newNumbersList = new List<int>();

            foreach (var number in numbersList)
            {
                ChekNumberIsExist(number);
                // Проверяем наличие числа в листе
                MultiplyAndCreateList(number, newNumbersList);
                //Производим возведение этого числа в степень
                // и выводим результат в другой лист

            }
        }

        public int Multiply(int x, int y) => x * y;

        public void ChekNumberIsExist(int x) => Console.WriteLine($"Number {x} is exist");

        public void MultiplyAndCreateList(int x, List<int> numbersList)
        {
            numbersList.Add((int)Math.Pow(x, 2));
            numbersList.OrderBy(n => n);
        }
    }
}
