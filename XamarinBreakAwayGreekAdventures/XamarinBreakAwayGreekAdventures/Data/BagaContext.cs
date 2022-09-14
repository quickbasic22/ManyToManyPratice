using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using XamarinBreakAwayGreekAdventures.Models;
using Xamarin.Forms;
using System.IO;

namespace XamarinBreakAwayGreekAdventures.Data
{
    public class BagaContext : DbContext
    {
        public BagaContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbFileName = "XamarinBaga.db";

            
                dbFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbFileName);

            optionsBuilder.UseSqlite($"Filename={dbFileName}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().Property(d => d.Name).IsRequired();
            modelBuilder.Entity<Destination>().Property(d => d.Description).HasMaxLength(200);
            modelBuilder.Entity<Destination>().Property(d => d.Photo).HasColumnType("image");

            modelBuilder.Entity<Lodging>().Property(l => l.Name).IsRequired().HasMaxLength(200);


        }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<ActivityTrip> ActivityTrip { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPhoto> PersonPhotos { get; set; }

    }
}
