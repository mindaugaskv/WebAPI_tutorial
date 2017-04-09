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
                    new LegoPart(){ Name = "Brick", Color = "Red", Size = "Big", Shape = "Square", ImageUrl = "https://www.bricklink.com/PL/11293pb001.jpg"},
                    new LegoPart(){ Name = "Double brick", Color = "Red", Size = "Big", Shape = "Square", ImageUrl = "https://www.bricklink.com/PL/87615pb05.jpg"},
                });
            }
        }
    }
}
