﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GM.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    internal class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GM.DAL.Entity.GameMode", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name")
                    .HasMaxLength(250);

                b.HasKey("Id");

                b.ToTable("GameMode");
            });

            modelBuilder.Entity("GM.DAL.Entity.Map", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name")
                    .HasMaxLength(250);

                b.HasKey("Id");

                b.ToTable("Map");
            });

            modelBuilder.Entity("GM.DAL.Entity.Matche", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("FragLimit");

                b.Property<long>("GameModeId");

                b.Property<long>("MapId");

                b.Property<long>("ServerId");

                b.Property<DateTime>("StartTimeStamp")
                    .HasColumnType("datetime2");

                b.Property<int>("TimeLimit");

                b.HasKey("Id");

                b.HasIndex("GameModeId");

                b.HasIndex("MapId");

                b.HasIndex("ServerId");

                b.ToTable("Matche");
            });

            modelBuilder.Entity("GM.DAL.Entity.Player", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name")
                    .HasMaxLength(50);

                b.HasKey("Id");

                b.ToTable("Player");
            });

            modelBuilder.Entity("GM.DAL.Entity.Scoreboard", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("Deaths");

                b.Property<int>("Frags");

                b.Property<int>("Kills");

                b.Property<long>("MatcheId");

                b.Property<long>("PlayerId");

                b.HasKey("Id");

                b.HasIndex("MatcheId");

                b.HasIndex("PlayerId");

                b.ToTable("Scoreboard");
            });

            modelBuilder.Entity("GM.DAL.Entity.Server", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Hostname")
                    .HasMaxLength(50);

                b.Property<string>("Name")
                    .HasMaxLength(250);

                b.Property<int>("Port");

                b.HasKey("Id");

                b.ToTable("Servers");
            });

            modelBuilder.Entity("GM.DAL.Entity.Matche", b =>
            {
                b.HasOne("GM.DAL.Entity.GameMode", "GameMode")
                    .WithMany("Matches")
                    .HasForeignKey("GameModeId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("GM.DAL.Entity.Map", "Map")
                    .WithMany("Matches")
                    .HasForeignKey("MapId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("GM.DAL.Entity.Server", "Server")
                    .WithMany("Matches")
                    .HasForeignKey("ServerId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("GM.DAL.Entity.Scoreboard", b =>
            {
                b.HasOne("GM.DAL.Entity.Matche", "Matche")
                    .WithMany("Scoreboards")
                    .HasForeignKey("MatcheId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("GM.DAL.Entity.Player", "Player")
                    .WithMany("Scoreboards")
                    .HasForeignKey("PlayerId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}