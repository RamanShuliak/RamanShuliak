namespace HomeTask3.FantasyArmy
{
    internal class Creature : Unit
    {
        private string Element;
        public Creature(string name, int healthPoint, int attack, int coast, string element)
            : base(name, healthPoint, attack, coast)
        {
            Element = element;
        }
    }
}
