namespace HomeTask3.FantasyArmy
{
    public class Mage : Unit
    {
        public int Mana;

        public Mage(string name, int healthPoint, int attack, int coast, string race, int mana) 
            : base(name, healthPoint, attack, coast, race)
        {
            Mana = mana;
        }

        public void PrintSpecialMageInfo()
        {
            Console.WriteLine($"Unit - {Name}  |  Volume of Mana - {Mana} barrels");
        }
    }
}