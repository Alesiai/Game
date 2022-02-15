﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220215225705_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("API.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("mdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("stadium")
                        .HasColumnType("TEXT");

                    b.Property<string>("team1")
                        .HasColumnType("TEXT");

                    b.Property<string>("team2")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("API.Entities.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("gtime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("matchid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("player")
                        .HasColumnType("TEXT");

                    b.Property<string>("teamid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("API.Entities.GoalsInStadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("stadium")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GoalsInStadiums");
                });
#pragma warning restore 612, 618
        }
    }
}
