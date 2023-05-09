﻿using Microsoft.EntityFrameworkCore;
using monitoring.Models;

namespace monitoring.Data
{
    internal class MonitoringContext : DbContext
    {
        public DbSet<Univer> Univers { get; set; }
        public DbSet<Cathedra> Cathedras { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=1234;database=monitoring;",
                new MySqlServerVersion(new Version(8, 0, 33))
            );
        }
        // => optionsBuilder.UseSqlite("Data Source=products.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Univer>().HasData(
                new Univer { UniverId = 1, Name = "ТУСУР" },
                new Univer { UniverId = 2, Name = "ТГУ" });

            modelBuilder.Entity<Cathedra>().HasData(
                new Cathedra { CathedraId = 1, UniverId = 1, Name = "ЭМИС" },
                new Cathedra { CathedraId = 2, UniverId = 1, Name = "КСУП" },
                new Cathedra { CathedraId = 3, UniverId = 2, Name = "АИСУ" });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Лаборант", Password = "1111" },
                new User { Id = 2, Name = "Зав. Кафедры", Password = "1234" });
        }
    }
}
