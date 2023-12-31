﻿using Microsoft.EntityFrameworkCore;
using System;

namespace UP.Models.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Enrollee> Enrollee { get; set; }

        public DbSet<Education> Education { get; set; }
        
        public DbSet<Disability> Disability { get; set; }

        public DbSet<Certificate> Certificate { get; set; }
        
        public DbSet<Ward> Ward { get; set; }

        public DbSet<Speciality> Speciality { get; set; }

        public DbSet<Citizenship> Citizenship { get; set; }

        public DbSet<PlaceOfResidence> PlaceOfResidence { get; set; }

        public DbSet<District> District { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=UP;Username=postgres;Password=12345");
        }
    }
}
