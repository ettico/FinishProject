using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class MatchMaking
    {
        public int Id { get; set; }
        public int MatchMakerId { get; set; }
        public int PersonId1 { get; set; }
        public int PersonId2 { get; set; }
        public DateTime ClosingDate { get; set; }
        public int NumMeetings { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
