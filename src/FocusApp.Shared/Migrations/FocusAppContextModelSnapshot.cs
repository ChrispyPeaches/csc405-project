﻿// <auto-generated />
using System;
using FocusApp.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FocusApp.Shared.Migrations
{
    [DbContext(typeof(FocusAppContext))]
    partial class FocusAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("FocusApp.Shared.Models.Badge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.Friendship", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FriendId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "FriendId", "Status");

                    b.HasIndex("FriendId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.Furniture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("HeightRequest")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Furniture");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.Island", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Islands");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.MindfulnessTip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionRatingLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MindfulnessTips");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("HeightRequest")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Auth0Id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("BLOB");

                    b.Property<string>("Pronouns")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SelectedBadgeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SelectedFurnitureId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SelectedIslandId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SelectedPetId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SelectedBadgeId");

                    b.HasIndex("SelectedFurnitureId");

                    b.HasIndex("SelectedIslandId");

                    b.HasIndex("SelectedPetId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserBadge", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BadgeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "BadgeId");

                    b.HasIndex("BadgeId");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserFurniture", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FurnitureId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "FurnitureId");

                    b.HasIndex("FurnitureId");

                    b.ToTable("UserFurniture");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserIsland", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IslandId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "IslandId");

                    b.HasIndex("IslandId");

                    b.ToTable("UserIslands");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserPet", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PetId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "PetId");

                    b.HasIndex("PetId");

                    b.ToTable("UserPets");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrencyEarned")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SessionEndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SessionStartTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSessionHistory");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.Friendship", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.User", "Friend")
                        .WithMany("Invitees")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("Inviters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Friend");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.User", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.Badge", "SelectedBadge")
                        .WithMany()
                        .HasForeignKey("SelectedBadgeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusApp.Shared.Models.Furniture", "SelectedFurniture")
                        .WithMany()
                        .HasForeignKey("SelectedFurnitureId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusApp.Shared.Models.Island", "SelectedIsland")
                        .WithMany()
                        .HasForeignKey("SelectedIslandId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FocusApp.Shared.Models.Pet", "SelectedPet")
                        .WithMany()
                        .HasForeignKey("SelectedPetId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("SelectedBadge");

                    b.Navigation("SelectedFurniture");

                    b.Navigation("SelectedIsland");

                    b.Navigation("SelectedPet");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserBadge", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.Badge", "Badge")
                        .WithMany()
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("Badges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Badge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserFurniture", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.Furniture", "Furniture")
                        .WithMany()
                        .HasForeignKey("FurnitureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("Furniture")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Furniture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserIsland", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.Island", "Island")
                        .WithMany()
                        .HasForeignKey("IslandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("Islands")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Island");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserPet", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.UserSession", b =>
                {
                    b.HasOne("FocusApp.Shared.Models.User", "User")
                        .WithMany("UserSessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FocusApp.Shared.Models.User", b =>
                {
                    b.Navigation("Badges");

                    b.Navigation("Furniture");

                    b.Navigation("Invitees");

                    b.Navigation("Inviters");

                    b.Navigation("Islands");

                    b.Navigation("Pets");

                    b.Navigation("UserSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
