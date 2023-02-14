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
            //Выберет персонов с именами на М

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
            //Выберет всех персонов с именами, заканчивающимися на а,
            //которые старше 20

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
            //Возьмёт каждый int из листа и выведет строку с ним
            //и результатом его умножения на 2.4

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
            //Выберет всех персонов из листа,
            //которые также и сотрудники (дочерний от персонов класс)

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
            //Отсортирует персонов по именам в отдельный лист

            foreach (var person in sortedByNameList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("_________");         
        }

        public void OrderByAge(List<Person> persons)
        {
            var sortedByAgeList = persons
                .OrderByDescending(p => p.Age)
                .ToList();
            //Отсортирует персонов по возрасту по убыванию в лист

            foreach (var person in sortedByAgeList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("_________");         
        }

        public void CollectionIntersectionLINQMethods()
        {
            var fruits = new List<string>() { "Apple", "Pineapple", "Cherry", "Banana" };

            var companies = new List<string>() { "Apple", "Samsung", "Google", "Microsoft" };

            var numbers = new List<int>() { 1,2,1,3,4,4,4,4,5,5,5,2,2,3,3,1,1,1,6,6,7,7,7,7,7};

            // Expect method
            var fruitsWithoutCompanies = fruits.Except(companies).ToList();
            //Возьмёт все fruits которые не совпали с companies по значению

            foreach(var fruit in fruitsWithoutCompanies)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("___");

            // Intersect method
            var fruitAndCompanyName = fruits.Intersect(companies).ToList();
            //Возьмёт все fruits которые совпали с companies по значению

            foreach (var fruit in fruitAndCompanyName)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("___");

            var newNumbers = numbers.Distinct().ToList();
            // Вынесет в другой лист все экземпляры без повторок

            foreach (var number in newNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.WriteLine("___");

            var fruitsAndCompanies = fruits.Concat(companies).ToList();
            //Объединит коллекции в одну без изменений

            var fruitsAndCompanies2 = fruits.Union(companies).ToList();
            //Объединит коллекции в одну, убрав повторки

            foreach (var name in fruitsAndCompanies)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine(Environment.NewLine);

            foreach (var name in fruitsAndCompanies2)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            Console.WriteLine("___");

        }

        public void AggregateMethods(List<Person> persons)
        {
            var numbers = new List<int>() { 1,5,3};

            var symbols = new List<string>() { "Ag", "Gtq", "Kar"};

            var numberOfNumbers = numbers.Count(n => n == 1);
            //Получит количество чисел в листе, чьё значение равно 1

            Console.WriteLine(numberOfNumbers);
            Console.WriteLine("___");

            var numbersAggregationResult = numbers.Aggregate((x, y) => x + y);
            //Получит [0] + [1], к результату прибавит [2] и т.д.
            var numbersAggregationResult2 = numbers.Aggregate((x, y) => x * y);
            // То же, только с перемножением

            Console.WriteLine(numbersAggregationResult);
            Console.WriteLine(numbersAggregationResult2);
            Console.WriteLine("___");

            var numbersSum = numbers.Sum();
            //Найдёт сумму всех чисел в листе

            Console.WriteLine(numbersSum);
            Console.WriteLine("___");

            var personMin = persons.Min(p => p.Age);
            //Найдёт самого младшего персона
            var personMax = persons.Max(p => p.Age);
            //Найдёт самого старшего персона
            var averagePersonsAge = persons.Average(p => p.Age);
            //Высчитает средний возраст всех персонов


            Console.WriteLine(personMin);
            Console.WriteLine(personMax);
            Console.WriteLine(averagePersonsAge);
            Console.WriteLine("___");
        }

        public void TakeMethods(List<Person> persons)
        {
            var firstThreePersons = persons.Take(3).ToList();
            //Берём первые три элемента

            var niddlePersons = persons.Skip(2).Take(2).ToList();
            // Пропускаем первые 2 элемента и берём 2 после них

            var lastTwoPersons = persons.TakeLast(2).ToList();
            // Берём последние 2 элемента

            var notMPersons = persons.TakeWhile(p => !p.Name.StartsWith("M")).ToList();
            // Берём до первого элемента с именем на М и стопимся

            foreach(var person in firstThreePersons)
            {
                Console.Write($"{person.Name} ");
            }
            Console.WriteLine();

            foreach (var person in niddlePersons)
            {
                Console.Write($"{person.Name} ");
            }
            Console.WriteLine();

            foreach (var person in lastTwoPersons)
            {
                Console.Write($"{person.Name} ");
            }
            Console.WriteLine();

            foreach (var person in notMPersons)
            {
                Console.Write($"{person.Name} ");
            }
            Console.WriteLine();
            Console.WriteLine("___");

        }

        public void GroupsMethod()
        {
            var employees = new List<Employee>() 
            {
                new Employee() {Name = "Yohiko", Age = 20, Company = "Samsung"},
                new Employee() {Name = "Mike", Age = 26, Company = "Microsoft"},
                new Employee() {Name = "Jon", Age = 43, Company = "Nike"},
                new Employee() {Name = "Nadia", Age = 31, Company = "Microsoft"},
                new Employee() {Name = "Evelin", Age = 27, Company = "Samsung"},
                new Employee() {Name = "Alex", Age = 54, Company = "Apple"},
                new Employee() {Name = "Roman", Age = 29, Company = "Honda"},
            };

            var employeesGroup = employees.GroupBy(e => e.Company);
            //Сгруппирует всех сотрудников по компаниям

            var companies = employeesGroup
                .ToDictionary(group => group.Key, group => group.ToList());
            //Создаст Dictionary с ключами-компаниями,
            //каждой из которой будут соответствовать листы с её сотрудниками
        }

        public void ChekIsContainMethods()
        {
            var employees = new List<Employee>()
            {
                new Employee() {Name = "Yohiko", Age = 20, Company = "Samsung"},
                new Employee() {Name = "Mike", Age = 26, Company = "Microsoft"},
                new Employee() {Name = "Jon", Age = 43, Company = "Nike"},
                new Employee() {Name = "Nadia", Age = 31, Company = "Microsoft"},
                new Employee() {Name = "Evelin", Age = 27, Company = "Samsung"},
                new Employee() {Name = "Alex", Age = 54, Company = "Apple"},
                new Employee() {Name = "Roman", Age = 29, Company = "Honda"},
            };

            var isAllEmployeesAreFromMicrosoft = employees.All(e => e.Company == "Microsoft");
            //Проверит, все ли сотрудники из Microsoft

            var isAnyEmployeesAreFromMicrosoft = employees.Any(e => e.Company == "Microsoft");
            //Проверит, есть ли хоть один сотрудник из Microsoft

            var firstEmploeeFromMicrosoft = employees.First(e => e.Company == "Microsoft");
            //Вернёт первого сотрудника в листе из Microsoft, если такого нет => exception

            var firstEmploeeFromMicrosoft2 = employees.FirstOrDefault(e => e.Company == "Peugeot");
            //То же самое, только в случае отсутствия вернёт значение по умолчанию или null

            //Аналогично с Lust/LustOrDefault.
            //Single/SingleOrDefault - будет брать любой подходящий элемент, а не по порядку

            var numbers = new List<int>() { 1,2,3,4,5,6,7,8,9 };

            var isElementInList = numbers.Contains(10);
            //Проверит есть ли элемент в со значением 10 в листе
            //Не работает с объектами классов
        }
    }
}
