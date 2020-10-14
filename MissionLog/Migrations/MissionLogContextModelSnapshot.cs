﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MissionLog.Models;

namespace MissionLog.Migrations
{
    [DbContext(typeof(MissionLogContext))]
    partial class MissionLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MissionLog.Models.Manifest", b =>
                {
                    b.Property<int>("ManifestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ManifestLifeSupportSupply");

                    b.Property<string>("ManifestShipCargo");

                    b.Property<string>("ManifestTitle");

                    b.Property<string>("ManifestWeapon");

                    b.HasKey("ManifestId");

                    b.ToTable("Manifests");
                });

            modelBuilder.Entity("MissionLog.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MissionDescription");

                    b.Property<string>("MissionName");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("MissionLog.Models.MissionManifest", b =>
                {
                    b.Property<int>("MissionManifestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ManifestId");

                    b.Property<int>("MissionId");

                    b.HasKey("MissionManifestId");

                    b.HasIndex("ManifestId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionManifest");
                });

            modelBuilder.Entity("MissionLog.Models.Ship", b =>
                {
                    b.Property<int>("ShipId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShipCaptain");

                    b.Property<string>("ShipClass");

                    b.Property<string>("ShipName");

                    b.Property<string>("ShipSpecies");

                    b.Property<string>("ShipType");

                    b.HasKey("ShipId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("MissionLog.Models.ShipManifest", b =>
                {
                    b.Property<int>("ShipManifestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ManifestId");

                    b.Property<int>("ShipId");

                    b.HasKey("ShipManifestId");

                    b.HasIndex("ManifestId");

                    b.HasIndex("ShipId");

                    b.ToTable("ShipManifest");
                });

            modelBuilder.Entity("MissionLog.Models.ShipMission", b =>
                {
                    b.Property<int>("ShipMissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MissionId");

                    b.Property<int>("ShipId");

                    b.HasKey("ShipMissionId");

                    b.HasIndex("MissionId");

                    b.HasIndex("ShipId");

                    b.ToTable("ShipMission");
                });

            modelBuilder.Entity("MissionLog.Models.MissionManifest", b =>
                {
                    b.HasOne("MissionLog.Models.Manifest", "Manifest")
                        .WithMany("Missions")
                        .HasForeignKey("ManifestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MissionLog.Models.Mission", "Mission")
                        .WithMany("Manifests")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MissionLog.Models.ShipManifest", b =>
                {
                    b.HasOne("MissionLog.Models.Manifest", "Manifest")
                        .WithMany("Ships")
                        .HasForeignKey("ManifestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MissionLog.Models.Ship", "Ship")
                        .WithMany("Manifests")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MissionLog.Models.ShipMission", b =>
                {
                    b.HasOne("MissionLog.Models.Mission", "Mission")
                        .WithMany("Ships")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MissionLog.Models.Ship", "Ship")
                        .WithMany("Missions")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
