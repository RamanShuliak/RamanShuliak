namespace HomeTask3.FantasyArmy
{
    internal class Program
    {
        //________OBJECTS__________


        static void Main(string[] args)
        {

            var necromancer = new Mage("Necromancer", 4480, 12763, 500, "Orc", 14367);

            var withard = new Mage("Withard", 3765, 13437, 430, "Elf", 13200);

            var druid = new Mage("Druid", 6400, 4300, 300, "Human", 8450);

            var warlock = new Mage("Warlock", 1200, 20567, 400, "Dark Elf", 10000);

            var battleMage = new Mage("BattleMage", 7000, 16850, 680, "Human", 12000);

            var swordman = new Fighter("Swordman", 10400, 3650, 75, "Dwarf", 10);

            var pikeman = new Fighter("Pikeman", 8296, 4500, 75, "Human", 32);

            var archer = new Fighter("Archer", 6560, 4000, 80, "Elf", 64);

            var barbarian = new Fighter("Barbarian", 12000, 6380, 100, "Orc", 120);

            var horseman = new Fighter("Horseman", 15830, 8270, 190, "Centaur", 85);

            var griffin = new Creature("Griffin", 20000, 16000, 300, "Relict", "Wind");

            var golem = new Creature("Golem", 23420, 13407, 280, "Elemental", "Earth");

            var dragon = new Creature("Dragon", 50280, 32480, 1000, "Damed snake", "Fire");

            var leviathan = new Creature("Leviathan", 45000, 40200, 1150, "Megalodon", "Water");

            var ghost = new Creature("Ghost", 200, 2000, 100, "Undead", "Spirit");


            var army = new Unit[] { withard, dragon, druid, warlock,
                battleMage, golem, swordman, pikeman, necromancer, archer, barbarian,
                horseman, griffin, leviathan};


            var mages = new Mage[] { withard, druid, warlock, battleMage, necromancer };

            var fighters = new Fighter[] { swordman, pikeman, archer, barbarian, horseman };

            var creatures = new Creature[] { golem, griffin, leviathan, ghost };





            //________METODS__________


            GetArmyComposition(army);

            GetDamageHierarchy(army);

            GetArmyCoast(army);

            //________MENU AND CHEK__________

            BaseMenu(army, mages, fighters, creatures);

            static void AssingLimitsFindUnits(Unit[] army)
            {
                int maxLimit2 = EnterMaxLimit();
                int minLimit2 = EnterMinLimit();

                FindUnit(army, maxLimit2, minLimit2);
            }

            static void BaseMenu(Unit[] army, Mage[] mages, Fighter[] fighters, Creature[] creatures)
            {
                Console.WriteLine($"Lord Alexei, please, enter the number" +
                 $"of operation from 1 to 3 {Environment.NewLine}" +
                 $"{Environment.NewLine}" +
                 $"1. Select limits of health and find the units," +
                    $"which are in the range{Environment.NewLine}" +
                $"2. To define in groups with different special characteristics units" +
                $"with the most strong index of this characteristics{Environment.NewLine}" +
                $"3. Close the program{Environment.NewLine}");

                ChekOperationSelection(army, mages, fighters, creatures);
            }

            static void ChekOperationSelection(Unit[] army, Mage[] mages, Fighter[] fighters, Creature[] creatures)
            {
                var enterOperation = Console.ReadLine();
                int enterOperationNew = 0;
                if (!int.TryParse(enterOperation, out enterOperationNew))
                {
                    Console.WriteLine($"{Environment.NewLine}" +
                        $"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                        $"Please, try again{Environment.NewLine}" +
                        $"");

                    MenuContinuation(army, mages, fighters, creatures);
                }
                else
                {
                    OperationSelection(enterOperationNew, army, mages, fighters, creatures);
                }
            }

            static void OperationSelection(int enterOperationNew, Unit[] army, 
                Mage[]mages, Fighter[]fighters, Creature[]creatures)
            {
                switch (enterOperationNew)
                {
                    case 1:
                        AssingLimitsFindUnits(army);
                        MenuContinuation(army, mages, fighters, creatures);
                        break;
                    case 2:
                        GetMagesManaHierarchy(mages);

                        GetFightersCritHierarchy(fighters);

                        GetCreatureElementHierarchy(creatures);

                        MenuContinuation(army, mages, fighters, creatures);

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
                        MenuContinuation(army, mages, fighters, creatures);
                        break;
                }
            }

            static void MenuContinuation(Unit[] army, Mage[] mages, Fighter[] fighters, Creature[] creatures)
            {
                Console.WriteLine($"{Environment.NewLine}" +
                    $"Select, do you wont to continue (enter 1 or 2)?{Environment.NewLine}" +
                    $"1. Yes{Environment.NewLine}" +
                    $"2. No{Environment.NewLine}");

                ChekContinuationSelection(army, mages, fighters, creatures);

            }

            static void ChekContinuationSelection(Unit[] army, Mage[] mages, Fighter[] fighters, Creature[] creatures)
            {
                var enterOperation2 = Console.ReadLine();
                int enterOperationNew2 = 0;
                if (!int.TryParse(enterOperation2, out enterOperationNew2))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Entered data is wrong, because include symbols.{Environment.NewLine}" +
                        $"Please, try again{Environment.NewLine}" +
                        $"");

                    MenuContinuation(army, mages, fighters, creatures);
                }
                else
                {
                    ContinuationSelection(enterOperationNew2, army, mages, fighters, creatures);
                }
            }

            static void ContinuationSelection(int enterOperationNew2, Unit[] army, 
                Mage[] mages, Fighter[] fighters, Creature[] creatures)
            {
                switch (enterOperationNew2)
                {
                    case 1:
                        BaseMenu(army, mages, fighters, creatures);
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
                        MenuContinuation(army, mages, fighters, creatures);
                        break;
                }
            }


            //________LIMITS__________

            static int EnterMaxLimit()
            {
                Console.WriteLine($"Lord Alexei, please, enter the maximum limit of health{Environment.NewLine}" +
                    $"of the unit you need: {Environment.NewLine}");

                var maxLimit = Convert.ToInt32(Console.ReadLine());
                return maxLimit;
            }

            static int EnterMinLimit()
            {
                Console.WriteLine($"Lord Alexei, please, enter the minimum limit of health{Environment.NewLine}" +
                    $"of the unit you need: {Environment.NewLine}");

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

            //________ARRAYS METHODS__________

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

                Console.WriteLine($"Lord Alexei, now you can see the sorting army from unit with minimal attack, to unit with maximum:{Environment.NewLine}" +
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
                    $"the summary mounthly coast of all units in Fantasy Army:");

                Console.WriteLine($"Summary mounthly coast = {armyCoast} septims");

                Console.WriteLine("");

            }

            //________SPECIALS CHARACTERISTICS__________

            static void SelectSpecialCharacteristics(Unit[] army)
            {
                Console.WriteLine($"Lord Alexei, please, enter number from 1 to 3" +
                    $"to select special characteristic {Environment.NewLine}" +
                    $"1. Mana{Environment.NewLine}" +
                    $"2. Armor{Environment.NewLine}" +
                    $"3. ");
            }

            static void GetMagesManaHierarchy(Mage[]mages)
            {
                var maxMage = 1;
                var maxIndex = 1;
                for (int i = 0; i < mages.Length; i++)
                {
                    if (mages[i].Mana > maxMage)
                    {
                        maxMage = mages[i].Mana;
                        maxIndex = i;
                    }
                    
                }
                Console.WriteLine($"Mage with the largest mana volume is:");
                mages[maxIndex].PrintSpecialMageInfo();

                Console.WriteLine("");
            }

            static void GetFightersCritHierarchy(Fighter[]fighters)
            {
                var maxCrit = 1;
                var maxIndex = 1;
                for (int i = 0; i < fighters.Length; i++)
                {
                    if (fighters[i].CriticalDamage > maxCrit)
                    {
                        maxCrit = fighters[i].CriticalDamage;
                        maxIndex = i;
                    }

                }
                Console.WriteLine($"Fighter with the largest bonus of critical damage is:");
                fighters[maxIndex].PrintSpecialFighterInfo();

                Console.WriteLine("");
            }

            static void GetCreatureElementHierarchy(Creature[] creatures)
            {
                Console.WriteLine($"All natural elements exist in garmony. " +
                    $"The are no strongest or weakest among them.{Environment.NewLine}" +
                    $"Strengh of the creatures depend only from their Attack and Health");
            }

        }

    }

}
