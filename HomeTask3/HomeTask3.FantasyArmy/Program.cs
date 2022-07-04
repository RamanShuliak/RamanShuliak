namespace HomeTask3.FantasyArmy
{
    internal class Program
    {
        //________OBJECTS__________


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



            //________METODS__________


            GetArmyComposition(army);

            GetDamageHierarchy(army);

            GetArmyCoast(army);

            BaseMenu(army);

            static void AssingLimitsFindUnits(Unit[]army)
            {
                int maxLimit2 = EnterMaxLimit();
                int minLimit2 = EnterMinLimit();

                FindUnit(army, maxLimit2, minLimit2);
            }
            
            static void BaseMenu(Unit[] army)
            {
                Console.WriteLine($"Lord Alexei, please, enter the number" +
                 $"of operation from 1 to 3 {Environment.NewLine}" +
                 $"{Environment.NewLine}" +
                 $"1. Select limits of health and find the units," +
                    $"which are in the range{Environment.NewLine}" +
                $"2. Select the special characteristics and find" +
                $"the units,  which have them{Environment.NewLine}" +
                $"3. Close the program{Environment.NewLine}");

                ChekOperationSelection(army);
            }

            static void ChekOperationSelection(Unit[] army)
            {
                var enterOperation = Console.ReadLine();
                int enterOperationNew = 0;
                if (!int.TryParse(enterOperation, out enterOperationNew))
                {
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                        $"Please, try again{Environment.NewLine}" +
                        $"");

                    MenuContinuation(army);
                }
                else
                {
                    OperationSelection(enterOperationNew, army);
                }
            }

            static void OperationSelection(int enterOperationNew, Unit[] army)
            {
                switch (enterOperationNew)
                {
                    case 1:
                        AssingLimitsFindUnits(army);
                        break;
                    case 3:
                        Console.WriteLine($"{Environment.NewLine}" +
                        $"Program is close. Goodby!");
                        break;
                    default:
                        Console.WriteLine($"{Environment.NewLine}" +
                        $"Operation with such number is not found.{Environment.NewLine}" +
                        $"Please, try again{Environment.NewLine}" +
                        $"");
                        MenuContinuation(army);
                        break;
                }
            }

            static void MenuContinuation(Unit[] army)
            {
                Console.WriteLine($"{Environment.NewLine}" +
                    $"Select, do you wont to continue (enter 1 or 2)?{Environment.NewLine}" +
                    $"1. Yes{Environment.NewLine}" +
                    $"2. No{Environment.NewLine}");

                ChekContinuationSelection(army);

            }

            static void ChekContinuationSelection(Unit[] army)
            {
                var enterOperation2 = Console.ReadLine();
                int enterOperationNew2 = 0;
                if (!int.TryParse(enterOperation2, out enterOperationNew2))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                        $"Please, try again{Environment.NewLine}" +
                        $"");

                    MenuContinuation(army);
                }
                else
                {
                    ContinuationSelection(enterOperationNew2, army);
                }
            }

            static void ContinuationSelection(int enterOperationNew2, Unit[]army)
            {
                switch (enterOperationNew2)
                {
                    case 1:
                        BaseMenu(army);
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
                        MenuContinuation(army);
                        break;
                }
            }

            static int EnterMaxLimit()
            {
                Console.WriteLine($"Lord Alexei, please, enter the maximum limit of health{Environment.NewLine}" +
                    "of the unit you need: ");

                var maxLimit = Convert.ToInt32(Console.ReadLine());
                return maxLimit;
            }

            static int EnterMinLimit()
            {
                Console.WriteLine($"Lord Alexei, please, enter the minimum limit of health{Environment.NewLine}" +
                    "of the unit you need: ");

                var minLimit = Convert.ToInt32(Console.ReadLine());
                return minLimit;
            }

            static void FindUnit(Unit[] army, int maxLimit2, int minLimit2)
            {
                Console.WriteLine("Units with suitable number of Healthpoints are: ");
                for (int i = 0; i < army.Length; i++)
                {
                    if (army[i].HealthPoint < maxLimit2 && army[i].HealthPoint > minLimit2)
                    {
                        army[i].PrintHealthInfo();
                    }
                }
            }

            static void GetArmyComposition(Unit[] army)
            {
                Console.WriteLine($"Lord Alexei, this is " +
                    $"the composition of the Fantasy Army, roled by you: {Environment.NewLine}");
                for (int i = 0; i < army.Length; i++)
                {
                    army[i].PrintFullInfo();
                }
                Console.WriteLine("");
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

                Console.WriteLine($"Lord Alexei, now you can see the sorting army from unit with minimal attack, to unit with maximum{Environment.NewLine}" +
                    $"");
                for (int i = 0; i < army.Length; i++)
                {
                    army[i].PrintAttackInfo();
                }

                Console.WriteLine("");
            }

            static void GetArmyCoast(Unit[] army)
            {
                var armyCoast = 0;
                for (int i = 0; i < army.Length; i++)
                {
                    armyCoast = armyCoast + army[i].Coast;
                }
                Console.WriteLine($"Lord Alexei, now you can see " +
                    $"the summary mounthly coast of all units in Fantasy Army{Environment.NewLine}");

                Console.WriteLine($"Summary mounthly coast = {armyCoast} septims");

                Console.WriteLine("");

            }



        }

    }
}