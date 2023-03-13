using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.AsyncMethods
{
    public class AsyncMethodSample
    {
        public async Task<int> CalculateSumAsync(int x, int y)
        {
            Console.WriteLine("Method CalculateSum() is working...");

            Console.WriteLine($"{x} + {y} = {x+y}");

            await PrintDataAsync();

            return x + y;
        }
        private async Task PrintDataAsync()
        {
            var task = Task.Run(() => Console.WriteLine("Method PrintData() is working..."));
            await task;
        }
    }
}
