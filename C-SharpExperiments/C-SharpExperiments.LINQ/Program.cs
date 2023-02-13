namespace C_SharpExperiments.LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person(){Name = "Angela", Age = 35},
                new Employee(){Name = "Yohiko", Age = 20, Company = "Samsung"},
                new Person(){Name = "Mikel", Age = 26},
                new Person(){Name = "Marina", Age = 15},
                new Employee(){Name = "Victor", Age = 48, Company = "Microsoft"},
            };

            var methods = new LINQMethods();

            methods.SelectByFirstSymbolInName(persons);

            methods.SelectByNameAndAge(persons);

            methods.SelectAndWorkWithNumbers();

            methods.SelectByClassType(persons);



            var sortedByAgeList = persons
                .OrderByDescending(p => p.Age)
                .ToList();

            foreach (var person in sortedByAgeList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}