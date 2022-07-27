using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.ATS
{
    internal class User
    {
        delegate void UserHandler(string message);

        event UserHandler NotifyUser;
        public string Name { get; set; }

        public string Rate { get; set; }

        public int Number { get; set; }

        public DateTime UserDate { get; set; }

        public User(string name, string rate, int number, DateTime userDate)
        {
            Name = name;
            Rate = rate;
            Number = number;
            UserDate = userDate;
        }

        public int CreateUserID()
        {
            var createdUserID = new Random().Next(0, 2);

            return createdUserID;
        }
        

        // Ta fajna metoda, ten piękny cod, są dedykowany nauczycielu Aleksieju
        public void ChoseRate(List<Rate> rates, DateTime startTime)
        {
            var prescriptionChoicingRate = DateTime.Now - UserDate;

            var prescriptionChoicingRateInt = prescriptionChoicingRate.Days;

            var x = 0;

            for (int i = 0; i < rates.Count; i++)
            {
                if (prescriptionChoicingRateInt >= 30 && Rate != rates[i].Name)
                {
                    Rate = rates[i].Name;

                    UserDate = DateTime.Now;

                    NotifyUser?.Invoke($"User {Name}, you changed your rate for {Rate}");

                    Console.WriteLine($"User {Name} changed his rate for {Rate}");
                    
                    break;

                }
                else
                {
                    x++;
                }
            }

            if (x >= rates.Count)
            {
                NotifyUser?.Invoke($"User {Name}, you can't change your rate" +
                    $"because you have already changed it in this month " +
                    $"or you already use this rate");

                Console.WriteLine($"User {Name} can't change your rate " +
                    $"because you have already changed it in this month " +
                    $"or you already use this rate");
            }
        }

        public void ChangeConditionOfPort(List<Terminal> terminals)
        {
            for (int i = 0; i < terminals.Count; i++)
            {
                if (terminals[i].Number == Number )
                {
                    if (terminals[i].OpenPort == true)
                    {
                        terminals[i].OpenPort = false;

                        NotifyUser?.Invoke($"User {Name}, your port had been cloused");

                        Console.WriteLine($"User's {Name} port had been cloused");
                    }
                    else
                    {
                        terminals[i].OpenPort = true;

                        NotifyUser?.Invoke($"User {Name}, your port had been opened");

                        Console.WriteLine($"User's {Name} port had been opened");
                    }
                }
            }
        }
    }
}
