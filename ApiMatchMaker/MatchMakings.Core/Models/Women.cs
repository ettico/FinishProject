using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public  class Women:Person
    {
        // כיסוי ראש - מידע על כיסוי הראש
        public string HeadCovering { get; set; }

        // רקע השכלתי - תיכון של הבחורה
        public string HighSchool { get; set; }

        // סמינר - רקע חינוכי נוסף
        public string Seminar { get; set; }

        // מסלול לימודי - המסלול הלימודי של הבחורה
        public string StudyPath { get; set; }

        // מוסד לימודים נוסף - מוסד נוסף אם יש
        public string AdditionalEducationalInstitution { get; set; } // לא חובה

        // עיסוק כיום - העיסוק הנוכחי
        public string CurrentOccupation { get; set; }
        //ציפיות מבן הזוג 

        // - המידע על החוג
        public string Club { get; set; }

        // מגיל - גיל מינימלי לחיפוש בן זוג
        public int AgeFrom { get; set; }

        // עד גיל - גיל מקסימלי לחיפוש בן זוג
        public int AgeTo { get; set; }

        // תכונות חשובות בי - תכונות בבחורה
        public string ImportantTraitsInMe { get; set; }

        // תכונות חשובות שאני מחפשת - תכונות בבן זוג
        public string ImportantTraitsIMLookingFor { get; set; }

        // סגנון הישיבות המועדף - סגנון ישיבה מועדף
        public string PreferredSittingStyle { get; set; }

        // מעוניינת שהבחור יהיה - מה שהבחורה רוצה בבן זוג
        public string InterestedInBoy { get; set; }

        // רישיון נהיגה - מידע על רישיון נהיגה
        public string DrivingLicense { get; set; }

        //  מעשן - מידע על הרגלי עישון
        public bool Smoker { get; set; }

        // זקן - מידע על העדפת זקן
        public string Beard { get; set; }

        // כובע - מידע על העדפת כובע
        public string Hat { get; set; }

        // חליפה - מידע על העדפת חליפה
        public string Suit { get; set; }

        // עיסוק - העיסוק של בן הזוג
        public string Occupation { get; set; }

        //public int FamilyDetailsId { get; set; } // מפתח זר לקשר עם פרטי משפחה
        //public FamilyDetails FamilyDetails { get; set; }
    }
}
