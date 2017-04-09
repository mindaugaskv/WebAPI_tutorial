namespace Backend.API.Migrations
{
    using Backend.API.Entities;
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

            if (!context.LegoToys.Any())
            {
                var toy = new LegoToy() {
                    ImageUrl = "https://www.bricklink.com/SL/6209-1.jpg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                    Name = "Laivas",
                    Price = 100,
                    Parts = context.LegoParts.ToList()                    
                };

                var toy1 = new LegoToy()
                {
                    ImageUrl = "https://www.bricklink.com/SL/20009-1.jpg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                    Name = "AT-TE Walker - Mini polybag",
                    Price = 100,
                    Parts = context.LegoParts.ToList()
                };

                context.LegoToys.Add(toy);
                context.LegoToys.Add(toy1);
            }

        }
    }
}
