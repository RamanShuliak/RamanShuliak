namespace HomeTask3.FantasyArmy
{
    public class Unit
    {
        public string Name { get; set;  }
        public int HealthPoint { get; set; }
        public int Attack { get; set; }
        public int Coast { get; set; }

        private string _Race;

        public Unit (string name, int healthPoint, int attack, int coast, string race)
        {
            Name = name;
            HealthPoint = healthPoint;
            Attack = attack;
            Coast = coast;
            _Race = race;
        }

        public void PrintFullInfo()
        {
            Console.WriteLine($"Unit - {Name}  |  Health - {HealthPoint} HP  |   Damage - {Attack} HP/sec  |   Coast/month - {Coast} septims  |   Race - {_Race}");
        }
        public void PrintAttackInfo()
        {
            Console.WriteLine($"Unit - {Name}  |  Damage - {Attack} HP/sec");
        }

        public void PrintHealthInfo()
        {
            Console.WriteLine($"Unit - {Name}  |  Health - {HealthPoint} HP");
        }
    }
}
