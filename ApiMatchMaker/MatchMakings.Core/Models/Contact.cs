using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } // שם
        public string Phone { get; set; } // טלפון
       
        public int MaleId { get; set; } // מפתח זר לקשר עם אדם
        public Male Male { get; set; } // קשר עם אדם 1

        public int WomenId { get; set; } // מפתח זר לקשר עם אדם
        public Women Women  { get; set; } // קשר עם אדם 1

        public int MatchMakerId { get; set; } // מפתח זר לקשר עם MatchMaker
        public MatchMaker MatchMaker { get; set; } // קשר עם MatchMaker
    }
}
