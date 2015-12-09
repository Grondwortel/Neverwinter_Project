﻿using System.Data.Entity;

namespace Neverwinter.Models
{
    public class User
    {
        //System Info
        public int Id { get; set; }

        //Basic Info
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Avatar { get; set; }

        //Account Info
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}