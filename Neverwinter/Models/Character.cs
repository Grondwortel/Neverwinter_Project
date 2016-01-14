using System.ComponentModel;

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
        public string Profession { get; set; }

        //Attribute Info
        [DefaultValue(10)]
        public int Power { get; set; }
        [DefaultValue(10)]
        public int Toughness { get; set; }
        [DefaultValue(10)]
        public int Agility { get; set; }
        [DefaultValue(10)]
        public int Knowledge { get; set; }

        //Combat Info
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Damage { get; set; }

        //Extra Info
        [DefaultValue(1)]
        public int Level { get; set; }
        public int Experience { get; set; }
    }
}