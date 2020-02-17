﻿using Microsoft.EntityFrameworkCore;
using MyFace.Models.Database;

namespace MyFace
{
    public class MyFaceDbContext : DbContext
    {
        public MyFaceDbContext(DbContextOptions<MyFaceDbContext> options) : base(options) {}
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Interaction> Interactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Interaction>().ToTable("Interaction");
        }
    }
}