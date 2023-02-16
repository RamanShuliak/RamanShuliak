using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.OperationsWithNumbers
{
    public class TaskOfTania
    {
        public void CalculateAmongOfYears()
        {
            var sum = 100.0;

            var amongOfYears = 0;

            while(sum <= 200)
            {
                sum += sum * 0.02;
                amongOfYears++;
            }

            Console.WriteLine($"Among of years = {amongOfYears}");
        }
    }
}
