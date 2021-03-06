﻿using System.Data.Entity;

namespace Neverwinter.Models
{
    public class NeverwinterContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NeverwinterContext() : base("name=NeverwinterContext")
        {
        }

        public System.Data.Entity.DbSet<Neverwinter.Models.Character> Characters { get; set; }
        public System.Data.Entity.DbSet<Neverwinter.Models.Gender> Genders { get; set; }
        public System.Data.Entity.DbSet<Neverwinter.Models.Profession> Professions { get; set; }
        public System.Data.Entity.DbSet<Neverwinter.Models.Race> Races { get; set; }
        public System.Data.Entity.DbSet<Neverwinter.Models.User> Users { get; set; }
    }
}