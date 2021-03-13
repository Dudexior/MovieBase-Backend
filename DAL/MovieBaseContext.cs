using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MovieBaseContext : DbContext
    {
        public MovieBaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }
        public DbSet<MovieImage> MovieImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var MoviesEntity = modelBuilder.Entity<Movie>();
            var DisplaysEntity = modelBuilder.Entity<Display>();
            var SourceTypesEntity = modelBuilder.Entity<SourceType>();

            DisplaysEntity
                .Property(p => p.SourceTypeId).HasConversion<int>();

            SourceTypesEntity
                .Property(p => p.SourceTypeId).HasConversion<int>();

            //Enum handling
            SourceTypesEntity
                .HasData(
                    Enum.GetValues(typeof(SourceTypeId))
                       .Cast<SourceTypeId>()
                       .Select(e => new SourceType()
                       {
                           SourceTypeId = e,
                           Name = e.ToString()
                       })
                );

            #region Seed
            MoviesEntity.HasData(new Movie
            {
                Id = 1,
                Title = "Men in Black",
                Description = "A police officer joins a secret organization that polices and monitors extraterrestrial interactions on Earth.",
                Duration = 98
            }, new Movie
            {
                Id = 2,
                Title = "Spider-Man",
                Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                Duration = 120
            }, new Movie
            {
                Id = 3,
                Title = "Independence Day",
                Description = "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.",
                Duration = 145
            }, new Movie
            {
                Id = 4,
                Title = "Tom and Jerry",
                Description = "A chaotic battle ensues between Jerry Mouse, who has taken refuge in the Royal Gate Hotel, and Tom Cat, who is hired to drive him away before the day of a big wedding arrives.",
                Duration = 101
            }, new Movie
            {
                Id = 5,
                Title = "Godzilla vs. Kong",
                Description = "The epic next chapter in the cinematic Monsterverse pits two of the greatest icons in motion picture history against one another - the fearsome Godzilla and the mighty Kong - with humanity caught in the balance.",
                Duration = 120
            }, new Movie
            {
                Id = 6,
                Title = "Willy's Wonderland ",
                Description = "A quiet drifter is tricked into a janitorial job at the now condemned Willy's Wonderland. The mundane tasks suddenly become an all-out fight for survival against wave after wave of demonic animatronics. Fists fly, kicks land, titans clash -- and only one side will make it out alive.",
                Duration = 82
            }, new Movie
            {
                Id = 7,
                Title = "Space Jam: A New Legacy",
                Description = "NBA superstar LeBron James teams up with Bugs Bunny and the rest of the Looney Tunes for this long-awaited sequel.",
                Duration = 123
            }, new Movie
            {
                Id = 8,
                Title = "Midsommar",
                Description = "A couple travels to Scandinavia to visit a rural hometown's fabled Swedish mid-summer festival. What begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult.",
                Duration = 148
            }, new Movie
            {
                Id = 9,
                Title = "Pulp Fiction",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Duration = 154
            }, new Movie
            {
                Id = 10,
                Title = "Fight Club",
                Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
                Duration = 139
            }
            );
            #endregion
        }

    }
}
