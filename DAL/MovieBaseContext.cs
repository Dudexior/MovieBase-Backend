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
        public DbSet<Movie> MovieImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Display>()
                .Property(p => p.SourceTypeId).HasConversion<int>();

            modelBuilder.Entity<SourceType>()
                .Property(p => p.SourceTypeId).HasConversion<int>();

            modelBuilder
           .Entity<SourceType>().HasData(
               Enum.GetValues(typeof(SourceTypeId))
                   .Cast<SourceTypeId>()
                   .Select(e => new SourceType()
                   {
                       SourceTypeId = e,
                       Name = e.ToString()
                   })
           );

        }

    }
}
