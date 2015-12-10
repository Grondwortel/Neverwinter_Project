using System.ComponentModel;

namespace Neverwinter.Models
{
    public class Character
    {
        //System Info
        public int Id { get; set; }
        public int Account { get; set; }

        //Basic Info
        [DefaultValue("ENTER NAME HERE")]
        public string Name { get; set; }
        [DefaultValue("Male")]
        public string Gender { get; set; }
        [DefaultValue("Human")]
        public string Race { get; set; }
        [DefaultValue("Knight")]
        public string Class { get; set; }

        //Attribute Info
        [DefaultValue(0)]
        public int Power { get; set; }
        [DefaultValue(0)]
        public int Toughness { get; set; }
        [DefaultValue(0)]
        public int Agility { get; set; }
        [DefaultValue(0)]
        public int Knowledge { get; set; }

        //Combat Info
        [DefaultValue(0)]
        public int Health { get; set; }
        [DefaultValue(0)]
        public int Defense { get; set; }
        [DefaultValue(0)]
        public int Attack { get; set; }
        [DefaultValue(0)]
        public int Damage { get; set; }

        //Extra Info
        [DefaultValue(1)]
        public int Level { get; set; }
        [DefaultValue(0)]
        public int Experience { get; set; }
    }
}