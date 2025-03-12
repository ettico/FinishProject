using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class Male:Person // גבר
    {
        public bool DriversLicense { get; set; } // רשיון נהיגה
        public bool Smoker { get; set; } // מעשן
        public string Beard { get; set; } // זקן
        public string Hot { get; set; } // כובע
        public string Suit { get; set; } // חליפה
        public string SmallYeshiva { get; set; } // ישיבה קטנה
        public string BigYeshiva { get; set; } // ישיבה גדולה
        public string Kibbutz { get; set; } // וועד
        public string Occupation { get; set; } // עיסוק

        // שדות חדשים
        public string ExpectationsFromPartner { get; set; } // ציפיות מבת הזוג
        public string Club { get; set; } // חוג
        public int AgeFrom { get; set; } // מגיל
        public int AgeTo { get; set; } // עד גיל
        public string ImportantTraitsInMe { get; set; } // תכונות חשובות בי
        public string ImportantTraitsIAmLookingFor { get; set; } // תכונות חשובות שאני מחפש
        public string PreferredSeminarStyle { get; set; } // סגנון הסמינרים המועדף
        public string PreferredProfessionalPath { get; set; } // מסלול מקצועי מועדף
        public string HeadCovering { get; set; } // כיסוי ראש

        //public int FamilyDetailsId { get; set; } // מפתח זר לקשר עם פרטי משפחה
        //public FamilyDetails FamilyDetails { get; set; }
    }

}
