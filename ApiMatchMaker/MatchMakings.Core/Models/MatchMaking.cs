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
        public int? Id { get; set; }

        public int? MaleId { get; set; }
        public Male? male { get; set; }

        public int? WomenId { get; set; }
        public Women? women { get; set; }

        public DateTime ? ClosingDate { get; set; }
        public int? NumMeetings { get; set; }
        public List<Meeting>? Meetings { get; set; }
        public DateTime? CreationDate { get; set; } // תאריך יצירת השידוך
      


        public int? MatchMakerId { get; set; }
        public MatchMaker? MatchMaker  { get; set; }
    }

}
