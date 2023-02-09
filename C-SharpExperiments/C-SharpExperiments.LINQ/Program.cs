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

            var names = persons
                .Where(p => p.Name.StartsWith("M"))
                .Select(p => p.Name)
                .ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("_________");

            var filtratedPersons = persons
                .Where(p => p.Name.EndsWith("a") && p.Age > 20)
                .Select(p => p)
                .ToList();

            foreach(var person in filtratedPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("_________");

            var intList = new List<int>() { 2, 3, 4, 5, 6};

            var newNumbersList = intList
                .Select(i => $"{i}* 2.4 = {(i * 2.4):N1}")
                .ToList();

            foreach(var numbers in newNumbersList)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("_________");

            var employees = persons
                .OfType<Employee>().ToList();

            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Company}");
            }
        }
    }
}