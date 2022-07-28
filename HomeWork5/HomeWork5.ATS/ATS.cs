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

    }
}
