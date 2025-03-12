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
        public DbSet<Person> People { get; set; }
        public DbSet<Male> Males { get; set; }
        public DbSet<Women> Females { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FamilyDetails> FamilyDetails { get; set; }
        public DbSet<MatchMaker> MatchMakers { get; set; }
        public DbSet<MatchMaking> MatchMakings { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MatchMakings_DB");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // קשרים בין Contact ל-Person
        //    modelBuilder.Entity<Contact>()
        //        .HasOne(c => c.Person1)
        //        .WithMany(p => p.Friends) // קשר עם חברים
        //        .HasForeignKey(c => c.PersonId1)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<Contact>()
        //        .HasOne(c => c.Person2)
        //        .WithMany(p => p.Staff) // קשר עם צוות
        //        .HasForeignKey(c => c.PersonId2)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    // קשרים בין FamilyDetails ל-Person
        //    modelBuilder.Entity<FamilyDetails>()
        //        .HasOne<Person>()
        //        .WithOne(fd => fd.familyDetails) // קשר עם פרטי משפחה
        //        .HasForeignKey<FamilyDetails>(fd => fd.PersonId);

        //    // קשרים בין Male ו-Female ל-FamilyDetails
        //    modelBuilder.Entity<Male>()
        //        .HasOne(fd => fd.FamilyDetails)
        //        .WithMany()
        //        .HasForeignKey(m => m.FamilyDetailsId);

        //    modelBuilder.Entity<Women>()
        //        .HasOne(fd => fd.FamilyDetails)
        //        .WithMany()
        //        .HasForeignKey(w => w.FamilyDetailsId);

        //    // קשרים בין MatchMaker ל-MatchMaking
        //    modelBuilder.Entity<MatchMaker>()
        //        .HasMany(mm => mm.Matches)
        //        .WithOne()
        //        .HasForeignKey(m => m.MatchMakerId);

        //    // קשרים בין MatchMaking ל-Meeting
        //    modelBuilder.Entity<MatchMaking>()
        //        .HasMany(mm => mm.Meetings)
        //        .WithOne()
        //        .HasForeignKey(m => m.MatchMakerId); // או PersonId1/PersonId2 לפי הצורך

        //    // קשרים בין Meeting ל-Person
        //    modelBuilder.Entity<Meeting>()
        //        .HasOne<Person>()
        //        .WithMany()
        //        .HasForeignKey(m => m.PersonId1);

        //    modelBuilder.Entity<Meeting>()
        //        .HasOne<Person>()
        //        .WithMany()
        //        .HasForeignKey(m => m.PersonId2);
        //}


    }

}
