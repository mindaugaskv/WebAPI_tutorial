namespace Backend.API.Migrations
{
    using Backend.API.Enties;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Backend.API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Backend.API.Models.ApplicationDbContext context)
        {
            if (!context.LegoParts.Any())
            {
                context.LegoParts.AddRange(new List<LegoPart>() {
                    new LegoPart(){ Name = "Part 1", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 2", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 3", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 4", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 5", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 6", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 7", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 8", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 10", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 9", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 11", Color = "Red", Size = "Big", Shape = "Square"},
                    new LegoPart(){ Name = "Part 12", Color = "Red", Size = "Big", Shape = "Square"},
                });
            }

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
        }
    }
}
