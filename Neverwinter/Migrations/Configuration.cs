namespace Neverwinter.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Neverwinter.Models.NeverwinterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Neverwinter.Models.NeverwinterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Genders.AddOrUpdate(x => x.Id,
                new Models.Gender() { Id = 1, Name = "Male", Bonus = 5 },
                new Models.Gender() { Id = 2, Name = "Female", Bonus = 10 }
            );

            context.Professions.AddOrUpdate(x => x.Id,
                new Models.Profession() { Id = 1, Name = "Barbarian", Bonus = 5 },
                new Models.Profession() { Id = 2, Name = "Knight", Bonus = 10 },
                new Models.Profession() { Id = 3, Name = "Paladin", Bonus = 15 },
                new Models.Profession() { Id = 4, Name = "Rogue", Bonus = 20 }
            );

            context.Races.AddOrUpdate(x => x.Id,
                new Models.Race() { Id = 1, Name = "Dwarf", Bonus = 5 },
                new Models.Race() { Id = 2, Name = "Elf", Bonus = 10 },
                new Models.Race() { Id = 3, Name = "Human", Bonus = 15 },
                new Models.Race() { Id = 4, Name = "Orc", Bonus = 20 }
            );
        }
    }
}