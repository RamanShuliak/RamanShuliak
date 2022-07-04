namespace Experiments.Classes
{
    internal class Unit
    {
        public string Name;
        public int Price;
        public int Health;

        public Unit (string name, int price, int health)
        {
            Name = name;
            Price = price;
            Health = health;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} - {Price} septims - {Health} points");
        }
    }
}
