namespace HomeTask3.FantasyArmy
{
    public class Mage : Unit
    {
        private int Mana;

        public Mage(string name, int healthPoint, int attack, int coast, string race, int mana) 
            : base(name, healthPoint, attack, coast, race)
        {
            Mana = mana;
        }
    }
}