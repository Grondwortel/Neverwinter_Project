using System.Data.Entity;

namespace Neverwinter.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
    }
}