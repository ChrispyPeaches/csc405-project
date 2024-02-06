﻿using FocusApp.Models;
using FocusApp.Resources;
using Microsoft.EntityFrameworkCore;

namespace FocusApp.Data;

public class FocusContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<UserBadge> UserBadges { get; set; }
    public DbSet<UserPet> UserPets { get; set; }
    public DbSet<UserSession> UserSessionHistory { get; set; }
    public DbSet<Friendship> Friends { get; set; }

    public FocusContext(DbContextOptions<FocusContext> options)
        : base(options)
    {
        SQLitePCL.Batteries_V2.Init();

        Database.EnsureCreated();
    }
}
