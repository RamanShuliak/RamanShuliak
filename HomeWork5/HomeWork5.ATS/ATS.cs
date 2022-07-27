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

        public void GiveNumberToUsers(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                users[i].Number = CreateNumber();
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

    }
}
