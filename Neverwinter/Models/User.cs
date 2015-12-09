using System.Data.Entity;

namespace Neverwinter.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string SurName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}