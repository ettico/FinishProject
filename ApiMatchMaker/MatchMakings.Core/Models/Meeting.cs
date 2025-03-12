using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class Meeting
    {
        public int? Id { get; set; }
        //public int? MatchMakerId { get; set; }

        //public int? MaleId { get; set; }
        //public Male? male { get; set; }

        //public int? WomenId { get; set; }
        //public Women? women { get; set; }

        public int? NumMeeting { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string? MeetingPlace { get; set; }

        //קשר עם מחלקת שידוך
        public int? MatchMakingId { get; set; }
        public MatchMaking? MatchMaking { get; set; }
    }
}
