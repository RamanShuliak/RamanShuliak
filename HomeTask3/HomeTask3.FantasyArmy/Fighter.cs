namespace HomeTask3.FantasyArmy
{
    public class Fighter : Unit
    {
        public int CriticalDamage;
        public Fighter(string name, int healthPoint, int attack, int coast, string race, int criticalDamage) 
            : base(name, healthPoint, attack, coast, race)
        {
            CriticalDamage = criticalDamage;
        }

        public void PrintSpecialFighterInfo()
        {
            Console.WriteLine($"Unit - {Name}  |   Additional critical damage -  + {CriticalDamage} %");
        }
    }
}
