using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.ATS
{
    internal class ATS
    {
        public static int CreateNumber()
        {
            var createdNumber = new Random().Next(10000, 99999);

            return createdNumber;
        }

        public static int CreateRateID()
        {
            var createdRateID = new Random().Next(0, 3);

            return createdRateID;
        }

        public void GiveNumberToUsers(List<User> users, List<Terminal> terminals)
        {
            for (int i = 0; i < users.Count; i++)
            {
                users[i].Number = CreateNumber();

                terminals.Add(new Terminal(users[i].Number, true, 0) { Number = users[i].Number });
            }
        }

        public void GiveFirstRateToUsers(List<User> users, List<Rate> rates)
        {
            var rateID = CreateRateID();

            for (int i = 0; i < users.Count; i++)
            {
                users[i].Rate = rates[rateID].Name;

                rateID = CreateRateID();
            }
        }

        public void PayMonthly(List<User> users, List<Terminal> terminals)
        {
            var DateNow = DateTime.Now.Day;

            for (int i = 0; i < users.Count; i++)
            {
                var userDate = users[i].UserDateForMonthPaying.Day;
                
                if((DateNow - userDate) >= 30)
                {
                    for (int j = 0; j < terminals.Count; j++)
                    {
                        if(terminals[j].Number == users[i].Number)
                        {
                            terminals[j].MonthPay = 0;

                            Console.WriteLine($"User {users[i].Name} payd his monthly cost");

                        }
                    }
                }
            }
        }

        public void PrintBaseMenu(List<User> users, List<Terminal> terminals)
        {
            Console.WriteLine("Alexei, hello) Please, select number of next operations (enter 1 - 6)");
            Console.WriteLine($"1.Print information about subscribers{Environment.NewLine}" +
                $"2. Print information about subscribers's ports {Environment.NewLine}");

            ChekOperationSelection(users, terminals);

        }

        public void ChekOperationSelection(List<User> users, List<Terminal> terminals)
        {
            var enterOperation = Console.ReadLine();
            int enterOperationNew = 0;
            if (!int.TryParse(enterOperation, out enterOperationNew))
            {
                Console.WriteLine($"{Environment.NewLine}" +
                    $"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation(users, terminals);
            }
            else
            {
                OperationSelection(enterOperationNew, users, terminals);
            }
        }

        public void OperationSelection(int enterOperationNew, List<User> users, List<Terminal> terminals)
        {
            switch (enterOperationNew)
            {
                case 1:
                    PrintUsersInfo(users);
                    break;
                case 2:
                    PrintInfoAboutPorts(users, terminals);
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}" +
                    $"Operation with such number is not found.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");
                    MenuContinuation(users, terminals);
                    break;
            }
        }

        public void MenuContinuation(List<User> users, List<Terminal> terminals)
        {
            Console.WriteLine($"{Environment.NewLine}" +
                $"Select, do you wont to continue (enter 1 or 2)?{Environment.NewLine}" +
                $"1. Yes{Environment.NewLine}" +
                $"2. No{Environment.NewLine}");

            ChekContinuationSelection(users, terminals);

        }

        public void ChekContinuationSelection(List<User> users, List<Terminal> terminals)
        {
            var enterOperation2 = Console.ReadLine();
            int enterOperationNew2 = 0;
            if (!int.TryParse(enterOperation2, out enterOperationNew2))
            {
                Console.WriteLine("");
                Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                    $"Please, try again{Environment.NewLine}" +
                    $"");

                MenuContinuation(users, terminals);
            }
            else
            {
                ContinuationSelection(enterOperationNew2, users, terminals);
            }
        }

        public void ContinuationSelection(int enterOperationNew2, List<User> users, List<Terminal> terminals)
        {
            switch (enterOperationNew2)
            {
                case 1:
                    PrintBaseMenu(users, terminals);
                    break;
                case 2:
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Program close. Goodby!");
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Operation with such number is not found.{Environment.NewLine}" +
                   $"Please, try again{Environment.NewLine}" +
                   $"");
                    MenuContinuation(users, terminals);
                    break;
            }
        }

        public void PrintUsersInfo(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"User's name {users[i].Name}  |  Rate {users[i].Rate}  |  Telepgone number {users[i].Number}");

            }
        }

        public void PrintInfoAboutPorts(List<User> users, List<Terminal> terminals)
        {
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < terminals.Count; j++)
                {
                    if (terminals[j].Number == users[i].Number)
                    {
                        if (terminals[j].OpenPort == true)
                        {
                            Console.WriteLine($"User {users[i].Name}  -  port is open/working now");
                        }
                        else
                        {
                            Console.WriteLine($"User {users[i].Name}  -  port is close now");
                        }
                    }
                }
            }
        }

    }
}
