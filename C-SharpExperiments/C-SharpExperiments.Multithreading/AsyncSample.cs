using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class AsyncSample
    {
        public void ChekNumberIsExist(int x) => Console.WriteLine($"Number {x} is exist");

        public void MultiplyAndCreateList(int x, List<int> numbersList)
        {
            numbersList.Add((int)Math.Pow(x, 2));
        }

        public async Task DoOperationByTasksContinueWithAsync(List<int> list)
        {
            var newNumbersList = new List<int>();

            foreach (var number in list)
            {
                var task = Task.Run(() => ChekNumberIsExist(number));
                var task1 = task.ContinueWith(t => MultiplyAndCreateList(number, newNumbersList));
                await task1;
            }
        }
    }
}
