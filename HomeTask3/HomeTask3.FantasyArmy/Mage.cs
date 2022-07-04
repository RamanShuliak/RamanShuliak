namespace HomeTask3.FantasyArmy
{
    public class Mage : Unit
    {
        private int Mana;

        public Mage(string name, int healthPoint, int attack, int coast, int mana) 
            : base(name, healthPoint, attack, coast)
        {
            Mana = mana;
        }
    }
}