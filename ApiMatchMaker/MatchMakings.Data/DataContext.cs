using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Data
{
    public class DataContext:DbContext
    {
        public DbSet<MatchMaker>? MatchMakers { get; set; }
        public DbSet<MatchMaking>? MatchMakings { get; set; }
        public DbSet<Meeting>? Meetings { get; set; }
        public DbSet<Person>? Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MatchMakingws_DB");
        }
    }
}
