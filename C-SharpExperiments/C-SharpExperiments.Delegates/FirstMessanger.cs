using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Delegates
{
    public class Messanger
    {
        public string PrintFirstMessange(int number)
        {
            Console.WriteLine($"Do you want to drink together {number} bottles???");
            return $"Do you want to drink together {number} bottles???";
        }

        public string PrintSecondMessage(int number)
        {
            Console.WriteLine($"Needed number = {number}.");
            return $"Needed number = {number}.";
        }
    }
}
