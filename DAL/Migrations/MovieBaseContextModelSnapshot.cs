﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(MovieBaseContext))]
    partial class MovieBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Display", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DisplayDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.Property<int>("SourceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SourceTypeId");

                    b.ToTable("Displays");
                });

            modelBuilder.Entity("DAL.Models.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Active = false,
                            Description = "A police officer joins a secret organization that polices and monitors extraterrestrial interactions on Earth.",
                            Duration = 98,
                            Title = "Men in Black"
                        },
                        new
                        {
                            Id = 2L,
                            Active = false,
                            Description = "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.",
                            Duration = 120,
                            Title = "Spider-Man"
                        },
                        new
                        {
                            Id = 3L,
                            Active = false,
                            Description = "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.",
                            Duration = 145,
                            Title = "Independence Day"
                        },
                        new
                        {
                            Id = 4L,
                            Active = false,
                            Description = "A chaotic battle ensues between Jerry Mouse, who has taken refuge in the Royal Gate Hotel, and Tom Cat, who is hired to drive him away before the day of a big wedding arrives.",
                            Duration = 101,
                            Title = "Tom and Jerry"
                        },
                        new
                        {
                            Id = 5L,
                            Active = false,
                            Description = "The epic next chapter in the cinematic Monsterverse pits two of the greatest icons in motion picture history against one another - the fearsome Godzilla and the mighty Kong - with humanity caught in the balance.",
                            Duration = 120,
                            Title = "Godzilla vs. Kong"
                        },
                        new
                        {
                            Id = 6L,
                            Active = false,
                            Description = "A quiet drifter is tricked into a janitorial job at the now condemned Willy's Wonderland. The mundane tasks suddenly become an all-out fight for survival against wave after wave of demonic animatronics. Fists fly, kicks land, titans clash -- and only one side will make it out alive.",
                            Duration = 82,
                            Title = "Willy's Wonderland "
                        },
                        new
                        {
                            Id = 7L,
                            Active = false,
                            Description = "NBA superstar LeBron James teams up with Bugs Bunny and the rest of the Looney Tunes for this long-awaited sequel.",
                            Duration = 123,
                            Title = "Space Jam: A New Legacy"
                        },
                        new
                        {
                            Id = 8L,
                            Active = false,
                            Description = "A couple travels to Scandinavia to visit a rural hometown's fabled Swedish mid-summer festival. What begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult.",
                            Duration = 148,
                            Title = "Midsommar"
                        },
                        new
                        {
                            Id = 9L,
                            Active = false,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Duration = 154,
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 10L,
                            Active = false,
                            Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
                            Duration = 139,
                            Title = "Fight Club"
                        });
                });

            modelBuilder.Entity("DAL.Models.MovieImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieImages");
                });

            modelBuilder.Entity("DAL.Models.SourceType", b =>
                {
                    b.Property<int>("SourceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SourceTypeId");

                    b.ToTable("SourceTypes");

                    b.HasData(
                        new
                        {
                            SourceTypeId = 0,
                            Name = "Api"
                        },
                        new
                        {
                            SourceTypeId = 1,
                            Name = "UI"
                        });
                });

            modelBuilder.Entity("DAL.Models.Display", b =>
                {
                    b.HasOne("DAL.Models.Movie", "Movie")
                        .WithMany("Displays")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.SourceType", "SourceType")
                        .WithMany("Displays")
                        .HasForeignKey("SourceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("SourceType");
                });

            modelBuilder.Entity("DAL.Models.MovieImage", b =>
                {
                    b.HasOne("DAL.Models.Movie", null)
                        .WithOne("Image")
                        .HasForeignKey("DAL.Models.MovieImage", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.Movie", b =>
                {
                    b.Navigation("Displays");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("DAL.Models.SourceType", b =>
                {
                    b.Navigation("Displays");
                });
#pragma warning restore 612, 618
        }
    }
}
