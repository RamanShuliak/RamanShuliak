namespace HomeTask3.FantasyArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var necromancer = new Mage("Necromancer", 4480, 12763, 500, 14367);

            var withard = new Mage("Withard", 3765, 13437, 430, 13200);

            var druid = new Mage("Druid", 6400, 4300, 300, 8450);

            var warlock = new Mage("Warlock", 1200, 20567, 400, 10000);

            var battleMage = new Mage("BattleMage", 7000, 16850, 680, 12000);

            var swordman = new Fighter("Swordman", 10400, 3650, 75, 10);

            var pikeman = new Fighter("Pikeman", 8296, 4500, 75, 32);

            var archer = new Fighter("Archer", 6560, 4000, 80, 64);

            var barbarian = new Fighter("Barbarian", 12000, 6380, 100, 120);

            var horseman = new Fighter("Horseman", 15830, 8270, 190, 85);

            var griffin = new Creature("Griffin", 20000, 16000, 300, "Wind");

            var golem = new Creature("Golem", 23420, 13407, 280, "Earth");

            var dragon = new Creature("Dragon", 50280, 32480, 1000, "Fire");

            var leviathan = new Creature("Leviathan", 45000, 40200, 1150, "Water");

            var ghost = new Creature("Ghost", 200, 2000, 100, "Spirit");

            var army = new Unit[] { withard, dragon, druid, warlock, 
                battleMage, golem, swordman, pikeman, necromancer, archer, barbarian, 
                horseman, griffin, leviathan};


            static int EnterLimits()
            {
                Console.WriteLine($"Lord Alexei, please, enter the maximum and minimum limits of health{Environment.NewLine}" +
                    "of the unit you need: ");

                var maxLimit = 
            }

            static void FindUnit(Unit[] army)
            {
                Console.WriteLine("Composition of the Fantasy Army: ");
                for (int i = 0; i < army.Length; i++)
                {
                    if (army[i].HealthPoint < maxLimit && (army[i].HealthPoint > minLimit)
                    {
                        Console.WriteLine("Units with suitable number of Healthpoints are: ");
                        army[i].PrintHealthInfo();
                    }
                }
            }

            static void GetArmyComposition(Unit[] army)
            {
                Console.WriteLine("Composition of the Fantasy Army: ");
                for (int i = 0; i < army.Length; i++)
                {
                    army[i].PrintFullInfo();
                }
            }

            static void GetDamageHierarchy(Unit[] army)
            {
                for (int i = 0; i < army.Length - 1; i++)
                {
                    for (int j = i + 1; j < army.Length; j++)
                    {
                        if (army[i].Attack > army[j].Attack)
                        {
                            var temp = army[i];
                            army[i] = army[j];
                            army[j] = temp;
                        }
                    }
                }

                // вывод
                Console.WriteLine($"This is sorting army from unit with minimal attack, to unit with maximum{Environment.NewLine}" +
                    $"");
                for (int i = 0; i < army.Length; i++)
                {
                    army[i].PrintAttackInfo();
                }
            }

            static void GetArmyCoast(Unit[] army)
            {
                var armyCoast = 0;
                for (int i = 0; i < army.Length; i++)
                {
                    armyCoast = armyCoast + army[i].Coast;
                }
                Console.WriteLine($"Summary mounthly coast of all units in Fantasy Army = {armyCoast} septims");

            }



        }

    }
}