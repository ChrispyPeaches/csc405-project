﻿// <auto-generated />
using System;
using FocusCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FocusAPI.Migrations
{
    [DbContext(typeof(FocusContext))]
    [Migration("20240131201239_testDB")]
    partial class testDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FocusCore.Models.Badges", b =>
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

                    b.Property<Guid?>("UserBadgesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserBadgesId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("FocusCore.Models.Pets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserPetsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserPetsId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("FocusCore.Models.UserBadges", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("FocusCore.Models.UserFriends", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PrimaryUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserFriends");
                });

            modelBuilder.Entity("FocusCore.Models.UserPets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateAcquired")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserPets");
                });

            modelBuilder.Entity("FocusCore.Models.UserSessionHistory", b =>
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

                    b.ToTable("UserSessionHistory");
                });

            modelBuilder.Entity("FocusCore.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Pronouns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserFriendsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserFriendsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FocusCore.Models.Badges", b =>
                {
                    b.HasOne("FocusCore.Models.UserBadges", null)
                        .WithMany("Badges")
                        .HasForeignKey("UserBadgesId");
                });

            modelBuilder.Entity("FocusCore.Models.Pets", b =>
                {
                    b.HasOne("FocusCore.Models.UserPets", null)
                        .WithMany("Pets")
                        .HasForeignKey("UserPetsId");
                });

            modelBuilder.Entity("FocusCore.Models.Users", b =>
                {
                    b.HasOne("FocusCore.Models.UserFriends", null)
                        .WithMany("FriendIds")
                        .HasForeignKey("UserFriendsId");
                });

            modelBuilder.Entity("FocusCore.Models.UserBadges", b =>
                {
                    b.Navigation("Badges");
                });

            modelBuilder.Entity("FocusCore.Models.UserFriends", b =>
                {
                    b.Navigation("FriendIds");
                });

            modelBuilder.Entity("FocusCore.Models.UserPets", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
