namespace HomeTask3.FantasyArmy
{
    internal class Creature : Unit
    {
        public string Element;
        public Creature(string name, int healthPoint, int attack, int coast, string race, string element)
            : base(name, healthPoint, attack, coast, race)
        {
            Element = element;
        }
    }
}
