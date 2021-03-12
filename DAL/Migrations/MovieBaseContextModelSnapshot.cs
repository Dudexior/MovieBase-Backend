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

                    b.Property<long?>("MovieId")
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<long?>("ImageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DAL.Models.MovieImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

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
                        .HasForeignKey("MovieId");

                    b.HasOne("DAL.Models.SourceType", "SourceType")
                        .WithMany("Displays")
                        .HasForeignKey("SourceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("SourceType");
                });

            modelBuilder.Entity("DAL.Models.Movie", b =>
                {
                    b.HasOne("DAL.Models.MovieImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("DAL.Models.Movie", b =>
                {
                    b.Navigation("Displays");
                });

            modelBuilder.Entity("DAL.Models.SourceType", b =>
                {
                    b.Navigation("Displays");
                });
#pragma warning restore 612, 618
        }
    }
}
