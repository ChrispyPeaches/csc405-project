﻿using FocusAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FocusAPI.Data;

public class FocusContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<UserBadge> UserBadges { get; set; }
    public DbSet<UserPet> UserPets { get; set; }
    public DbSet<UserSession> UserSessionHistory { get; set; }
    public DbSet<Friendship> Friends { get; set; }
    public DbSet<Furniture> Furniture { get; set; }
    public DbSet<Sound> Sounds { get; set; }
    public DbSet<UserFurniture> UserFurniture { get; set; }
    public DbSet<UserSound> UserSounds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // No SQL server conneciton yet
        // Better alternative for SQL Server connection https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FocusFriendsDevTest;Integrated Security=True;");
    }
}
