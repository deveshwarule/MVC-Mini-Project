﻿using Microsoft.EntityFrameworkCore;
using MVC_Mini_Project.Models;

namespace MVC_Mini_Project.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Action",DisplayOrder=1},
                new Category { Id=2,Name="History",DisplayOrder=2},
                new Category { Id=3,Name="Drama",DisplayOrder=3}
                
                );
        }

    }
}
