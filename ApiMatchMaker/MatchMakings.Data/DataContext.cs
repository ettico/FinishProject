using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Data
{
    //public class DataContext : DbContext
    //{
    //    public DbSet<MatchMaker>? MatchMakers { get; set; }
    //    public DbSet<MatchMaking>? MatchMakings { get; set; }
    //    public DbSet<Meeting>? Meetings { get; set; }
    //    public DbSet<Person>? Persons { get; set; }
    //    public DbSet<FamilyDetails>? FamilyDetails { get; set; } // אם יש לך מחלקה כזו
    //    public DbSet<Contact>? Contacts { get; set; } // אם יש לך מחלקה כזו
    //    public DbSet<Male> Males { get; set; }
    //    public DbSet<Women> Womens { get; set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MatchMakingws_DB");
    //    }

    //    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    //{
    //    //    modelBuilder.Entity<Person>()
    //    //        .HasDiscriminator<string>("Gender")
    //    //        .HasValue<Male>("Male")
    //    //        .HasValue<Women>("Female");

    //    //    modelBuilder.Entity<Person>()
    //    //        .HasMany(p => p.Friends)
    //    //        .WithOne()
    //    //        .HasForeignKey(c => c.PersonId)
    //    //        .OnDelete(DeleteBehavior.Restrict);

    //    //    modelBuilder.Entity<Person>()
    //    //        .HasMany(p => p.Staff)
    //    //        .WithOne()
    //    //        .HasForeignKey(c => c.PersonId)
    //    //        .OnDelete(DeleteBehavior.Restrict);

    //    //    modelBuilder.Entity<Person>()
    //    //        .HasMany(p => p.FamilyFriends)
    //    //        .WithOne()
    //    //        .HasForeignKey(c => c.PersonId)
    //    //        .OnDelete(DeleteBehavior.Restrict);
    //    //}

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Person>()
    //            .HasDiscriminator<string>("Gender")
    //            .HasValue<Male>("Male")
    //            .HasValue<Women>("Female");

    //        modelBuilder.Entity<Person>()
    //            .HasMany(p => p.Friends)
    //            .WithOne()
    //            .HasForeignKey(c => c.PersonId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<Person>()
    //            .HasMany(p => p.Staff)
    //            .WithOne()
    //            .HasForeignKey(c => c.PersonId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<Person>()
    //            .HasMany(p => p.FamilyFriends)
    //            .WithOne()
    //            .HasForeignKey(c => c.PersonId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<Male>()
    //            .HasOne<FamilyDetails>()
    //            .WithMany()
    //            .HasForeignKey(m => m.FamilyDetailsId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<Women>()
    //            .HasOne<FamilyDetails>()
    //            .WithMany()
    //            .HasForeignKey(w => w.FamilyDetailsId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<MatchMaker>()
    //            .HasMany(m => m.Recommend)
    //            .WithOne()
    //            .HasForeignKey(c => c.PersonId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        modelBuilder.Entity<MatchMaking>()
    //            .HasMany(m => m.Meetings)
    //            .WithOne()
    //            .HasForeignKey(meeting => meeting.MatchMakerId)
    //            .OnDelete(DeleteBehavior.Cascade);
    //    }
    //}
    public class DataContext : DbContext
    {
        public DbSet<Male> Males { get; set; }
        public DbSet<Women> Womens { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FamilyDetails> FamilyDetails { get; set; }
        public DbSet<MatchMaker> MatchMakers { get; set; }
        public DbSet<MatchMaking> MatchMakings { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MatchMakingsToDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
    .HasOne(c => c.Male)
    .WithMany(m => m.Acquaintances)
    .HasForeignKey(c => c.MaleId);

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Women)
                .WithMany(w => w.Contacts)
                .HasForeignKey(c => c.WomenId);

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.MatchMaker)
                .WithMany(m => m.Contacts)
                .HasForeignKey(c => c.MatchMakerId);

            modelBuilder.Entity<FamilyDetails>()
           .HasOne(fd => fd.Male)
    .WithOne(m => m.FamilyDetails)
    .HasForeignKey<FamilyDetails>(fd => fd.MaleId);

            modelBuilder.Entity<FamilyDetails>()
                .HasOne(fd => fd.Women)
                .WithOne(w => w.FamilyDetails)
                .HasForeignKey<FamilyDetails>(fd => fd.WomenId);

            modelBuilder.Entity<MatchMaking>()
    .HasOne(mm => mm.male) // קשר עם Male
    .WithMany() // קשר אחד לרבים
    .HasForeignKey(mm => mm.MaleId);

            modelBuilder.Entity<MatchMaking>()
                .HasOne(mm => mm.women) // קשר עם Women
                .WithMany() // קשר אחד לרבים
                .HasForeignKey(mm => mm.WomenId);

            modelBuilder.Entity<MatchMaking>()
                .HasOne(mm => mm.MatchMaker)
                .WithMany(m => m.Matches)
                .HasForeignKey(mm => mm.MatchMakerId);

            modelBuilder.Entity<Meeting>()
    .HasOne(m => m.MatchMaking)
    .WithMany(mm => mm.Meetings)
    .HasForeignKey(m => m.MatchMakingId);

            modelBuilder.Entity<MatchMaker>()
    .HasMany(m => m.Contacts)
    .WithOne(c => c.MatchMaker)
    .HasForeignKey(c => c.MatchMakerId);

            modelBuilder.Entity<MatchMaker>()
                .HasMany(m => m.Matches)
                .WithOne(mm => mm.MatchMaker)
                .HasForeignKey(mm => mm.MatchMakerId);

        }



    }

}
