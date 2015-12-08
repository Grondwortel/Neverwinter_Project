using System.Data.Entity;

namespace Neverwinter.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string Tussenvoegsel { get; set; }
        public string SirName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Username { get; set; }
    }
}