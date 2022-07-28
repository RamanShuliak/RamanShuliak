namespace HomeWork5.ATS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__________ Inicialisation of Users __________

            var roman = new User("Roman", "NoRate", 0, DateTime.Now, DateTime.Now);

            var bogdan = new User("Bogdan", "NoRate", 0, DateTime.Now, DateTime.Now);

            var max = new User("Max", "NoRate", 0, DateTime.Now, DateTime.Now);

            var users = new List<User> {roman, bogdan, max};

            //__________ Inicialisation of Rates __________

            var noLimits = new Rate("NoLimits", 35);

            var family = new Rate("Family", 20);

            var forLosers = new Rate("ForLosers", 8);

            var rates = new List<Rate> { noLimits, family, forLosers };

            //__________ Inicialisation of Terminals __________

            var terminals = new List<Terminal>
            {

            };


            //__________ Base work of ATS __________

            var ats = new ATS();

            ats.GiveNumberToUsers(users, terminals);           

            ats.GiveFirstRateToUsers(users, rates);

            var startTime = DateTime.Now;

            bogdan.Call(users, terminals, rates);

            max.ChangeConditionOfPort(terminals);

            roman.Call(users, terminals, rates);

            max.ChangeConditionOfPort(terminals);

            roman.GetHistoryOfCalling();

            ats.PrintBaseMenu(users, terminals);

        }

        //__________ METHODS __________

       
    }
}