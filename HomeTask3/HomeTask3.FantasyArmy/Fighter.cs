namespace HomeTask3.FantasyArmy
{
    public class Fighter : Unit
    {
        private int CriticalDamage;
        public Fighter(string name, int healthPoint, int attack, int coast, string race, int armor) 
            : base(name, healthPoint, attack, coast, race)
        {
            CriticalDamage = armor;
        }
    }
}
