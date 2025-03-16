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
        public DbSet<BaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DB-Of-MatchMakings");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // קשרים עבור Contact
        //    modelBuilder.Entity<Contact>()
        //       .HasOne(c => c.Male)
        //       .WithMany(m => m.Acquaintances)
        //       .HasForeignKey(c => c.MaleId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Contact>()
        //       .HasOne(c => c.Women)
        //       .WithMany(w => w.Contacts)
        //       .HasForeignKey(c => c.WomenId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Contact>()
        //       .HasOne(c => c.MatchMaker)
        //       .WithMany(m => m.Contacts)
        //       .HasForeignKey(c => c.MatchMakerId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    // קשרים עבור FamilyDetails
        //    modelBuilder.Entity<FamilyDetails>()
        //       .HasOne(fd => fd.Male)
        //       .WithOne(m => m.FamilyDetails)
        //       .HasForeignKey<FamilyDetails>(fd => fd.MaleId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<FamilyDetails>()
        //       .HasOne(fd => fd.Women)
        //       .WithOne(w => w.FamilyDetails)
        //       .HasForeignKey<FamilyDetails>(fd => fd.WomenId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //    // קשרים עבור MatchMaking
        //    modelBuilder.Entity<MatchMaking>()
        //       .HasOne(mm => mm.male)
        //       .WithMany()
        //       .HasForeignKey(mm => mm.MaleId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<MatchMaking>()
        //       .HasOne(mm => mm.women)
        //       .WithMany()
        //       .HasForeignKey(mm => mm.WomenId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<MatchMaking>()
        //       .HasOne(mm => mm.MatchMaker)
        //       .WithMany(m => m.Matches)
        //       .HasForeignKey(mm => mm.MatchMakerId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //    // קשרים עבור Meeting
        //    modelBuilder.Entity<Meeting>()
        //       .HasOne(m => m.MatchMaking)
        //       .WithMany(mm => mm.Meetings)
        //       .HasForeignKey(m => m.MatchMakingId)
        //       .OnDelete(DeleteBehavior.Cascade);

        //    // קשרים עבור MatchMaker
        //    modelBuilder.Entity<MatchMaker>()
        //       .HasMany(m => m.Contacts)
        //       .WithOne(c => c.MatchMaker)
        //       .HasForeignKey(c => c.MatchMakerId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<MatchMaker>()
        //       .HasMany(m => m.Matches)
        //       .WithOne(mm => mm.MatchMaker)
        //       .HasForeignKey(mm => mm.MatchMakerId)
        //       .OnDelete(DeleteBehavior.Cascade);
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MatchMaking>()
        //        .HasOne(mm => mm.male)
        //        .WithMany()
        //        .HasForeignKey(mm => mm.MaleId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<MatchMaking>()
        //        .HasOne(mm => mm.women)
        //        .WithMany()
        //        .HasForeignKey(mm => mm.WomenId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //    modelBuilder.Entity<MatchMaking>()
        //        .HasOne(mm => mm.MatchMaker)
        //        .WithMany(m => m.Matches)
        //        .HasForeignKey(mm => mm.MatchMakerId)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}



    }

}
