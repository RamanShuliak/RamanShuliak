using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.LINQ
{
    public class LINQMethods
    {
        public void SelectByFirstSymbolInName(List<Person> persons)
        {
            var names = persons
                .Where(p => p.Name.StartsWith("M"))
                .Select(p => p.Name)
                .ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("_________");
        }

        public void SelectByNameAndAge(List<Person> persons)
        {
            var filtratedPersons = persons
                .Where(p => p.Name.EndsWith("a") && p.Age > 20)
                .Select(p => p)
                .ToList();

            foreach (var person in filtratedPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("_________");
        }

        public void SelectAndWorkWithNumbers()
        {
            var intList = new List<int>() { 2, 3, 4, 5, 6 };

            var newNumbersList = intList
                .Select(i => $"{i}* 2.4 = {(i * 2.4):N1}")
                .ToList();

            foreach (var numbers in newNumbersList)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("_________");
        }

        public void SelectByClassType(List<Person> persons)
        {
            var employees = persons
                .OfType<Employee>().ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Company}");
            }

            Console.WriteLine("_________");
        }

        public void OrderByName(List<Person> persons)
        {
            var sortedByNameList = persons
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var person in sortedByNameList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("_________");         
        }
    }
}
