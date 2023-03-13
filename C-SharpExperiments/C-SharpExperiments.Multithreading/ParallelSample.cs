using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class ParallelSample
    {
        public void DoInvokeMethod()
        {
            Parallel.Invoke(
                () => Multiply(5, 6),
                () => WriteOneLine(),
                () => Multiply(34, 15));
        }

        public void DoForMethod()
        {
            Parallel.For(1, 20, PowTwo);
        }

        public void DoForEachMethod(List<int> numbersList)
        {
            var result = Parallel.ForEach(numbersList, number => DoOperationByTasksContinueWith(number));

            while(!result.IsCompleted)
            // Гарантировано дожидаемся выполнения всего ForEach-а
            {
            }
        }

        public void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x*y}");

        public void PowTwo(int x) => Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}");

        public void WriteOneLine() => Console.WriteLine("This is the line.");

        public void ChekNumberIsExist(int x) => Console.WriteLine($"Number {x} is exist");

        public void MultiplyAndCreateList(int x, List<int> numbersList)
        {
            numbersList.Add((int)Math.Pow(x, 2));
        }

        public void DoOperationByTasksContinueWith(int number)
        {

            var newNumbersList = new List<int>();

            var task = new Task(() => ChekNumberIsExist(number));
            var task1 = task.ContinueWith(t => MultiplyAndCreateList(number, newNumbersList));
            task.Start();
            task.Wait();
        }
    }
}
