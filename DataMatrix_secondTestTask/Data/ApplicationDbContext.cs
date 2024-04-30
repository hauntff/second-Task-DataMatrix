using DataMatrix_secondTestTask.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataMatrix_secondTestTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // public ApplicationDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host = localhost; Port=5432;Database=DataMatrix_Farabi_TestDB;Username=postgres;Password=gangoptimus");

    }
}
