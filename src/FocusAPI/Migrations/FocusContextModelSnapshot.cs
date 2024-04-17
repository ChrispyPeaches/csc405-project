﻿// <auto-generated />
using System;
using FocusAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FocusAPI.Migrations
{
    [DbContext(typeof(FocusContext))]
    partial class FocusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FocusAPI.Models.Badge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("FocusAPI.Models.Friendship", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FriendId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FriendId");

                    b.HasIndex("FriendId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("FocusAPI.Models.Furniture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HeightRequest")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Furniture");
                });

            modelBuilder.Entity("FocusAPI.Models.Island", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Islands");
                });

            modelBuilder.Entity("FocusAPI.Models.MindfulnessTip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionRatingLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MindfulnessTips");
                });

            modelBuilder.Entity("FocusAPI.Models.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HeightRequest")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("FocusAPI.Models.Sound", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sounds");
                });

            modelBuilder.Entity("FocusAPI.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Auth0Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Pronouns")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("SelectedBadgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SelectedFurnitureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SelectedIslandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SelectedPetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SelectedBadgeId");

                    b.HasIndex("SelectedFurnitureId");

                    b.HasIndex("SelectedIslandId");

                    b.HasIndex("SelectedPetId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FocusAPI.Models.UserBadge", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BadgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "BadgeId");

                    b.HasIndex("BadgeId");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("FocusAPI.Models.UserFurniture", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FurnitureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "FurnitureId");

                    b.HasIndex("FurnitureId");

                    b.ToTable("UserFurniture");
                });

            modelBuilder.Entity("FocusAPI.Models.UserIsland", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IslandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "IslandId");

                    b.HasIndex("IslandId");

                    b.ToTable("UserIslands");
                });

            modelBuilder.Entity("FocusAPI.Models.UserPet", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "PetId");

                    b.HasIndex("PetId");

                    b.ToTable("UserPets");
                });

            modelBuilder.Entity("FocusAPI.Models.UserSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrencyEarned")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("SessionEndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("SessionStartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSessionHistory");
                });

            modelBuilder.Entity("FocusAPI.Models.UserSound", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "SoundId");

                    b.HasIndex("SoundId");

                    b.ToTable("UserSounds");
                });

            modelBuilder.Entity("FocusAPI.Models.Friendship", b =>
                {
                    b.HasOne("FocusAPI.Models.User", "Friend")
                        .WithMany("Invitees")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Inviters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Friend");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.User", b =>
                {
                    b.HasOne("FocusAPI.Models.Badge", "SelectedBadge")
                        .WithMany()
                        .HasForeignKey("SelectedBadgeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusAPI.Models.Furniture", "SelectedFurniture")
                        .WithMany()
                        .HasForeignKey("SelectedFurnitureId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusAPI.Models.Island", "SelectedIsland")
                        .WithMany()
                        .HasForeignKey("SelectedIslandId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusAPI.Models.Pet", "SelectedPet")
                        .WithMany()
                        .HasForeignKey("SelectedPetId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("SelectedBadge");

                    b.Navigation("SelectedFurniture");

                    b.Navigation("SelectedIsland");

                    b.Navigation("SelectedPet");
                });

            modelBuilder.Entity("FocusAPI.Models.UserBadge", b =>
                {
                    b.HasOne("FocusAPI.Models.Badge", "Badge")
                        .WithMany()
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Badges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.UserFurniture", b =>
                {
                    b.HasOne("FocusAPI.Models.Furniture", "Furniture")
                        .WithMany()
                        .HasForeignKey("FurnitureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Furniture")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Furniture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.UserIsland", b =>
                {
                    b.HasOne("FocusAPI.Models.Island", "Island")
                        .WithMany()
                        .HasForeignKey("IslandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Islands")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Island");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.UserPet", b =>
                {
                    b.HasOne("FocusAPI.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.UserSession", b =>
                {
                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("UserSessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.UserSound", b =>
                {
                    b.HasOne("FocusAPI.Models.Sound", "Sound")
                        .WithMany()
                        .HasForeignKey("SoundId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusAPI.Models.User", "User")
                        .WithMany("Sounds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sound");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusAPI.Models.User", b =>
                {
                    b.Navigation("Badges");

                    b.Navigation("Furniture");

                    b.Navigation("Invitees");

                    b.Navigation("Inviters");

                    b.Navigation("Islands");

                    b.Navigation("Pets");

                    b.Navigation("Sounds");

                    b.Navigation("UserSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
