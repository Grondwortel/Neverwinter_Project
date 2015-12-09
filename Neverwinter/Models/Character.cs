namespace Neverwinter.Models
{
    public class Character
    {
        //System Info
        public int Id { get; set; }
        public int Account { get; set; }

        //Basic Info
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }

        //Attribute Info
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Combat Info
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Damage { get; set; }

        //Extra Info
        public int Level { get; set; }
        public int Experience { get; set; }
    }
}