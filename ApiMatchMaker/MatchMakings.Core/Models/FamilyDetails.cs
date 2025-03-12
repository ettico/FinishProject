using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class FamilyDetails
    {
        public int Id { get; set; }
        // פרטי האב
        public string FatherName { get; set; } // שם האב
        public string FatherOrigin { get; set; } // מוצא האב
        public string FatherYeshiva { get; set; } // יוצא ישיבת האב
        public string FatherAffiliation { get; set; } // השתייכות (קהילה\חוג\בית כנסת) של האב
        public string FatherOccupation { get; set; } // עיסוק האב - רצוי לציין מקום

        // פרטי האם
        public string MotherName { get; set; } // שם האם
        public string MotherOrigin { get; set; } // מוצא האם
        public string MotherGraduateSeminar { get; set; } // בוגרת סמינר של האם
        public string MotherPreviousName { get; set; } // שם קודם של האם
        public string MotherOccupation { get; set; } // עיסוק האם - רצוי לציין מקום

        // פרטי הורים
        public bool ParentsStatus { get; set; } // סטטוס הורים (נוכחים/לא נוכחים)
        public bool HealthStatus { get; set; } // מצב בריאותי של ההורים
        public string FamilyRabbi { get; set; } // רב משפחה / רב אישי
        public string FamilyAbout { get; set; } // אודות המשפחה

        // פרטי אחים ואחיות
        public int NumberOfChildren { get; set; } // מספר הילדים במשפחה
        public int PositionInFamily { get; set; } // מיקום במשפחה
        public int NumberOfMarried { get; set; } // מספר נשואים במשפחה
        public string EducationalInstitutions { get; set; } // מוסדות לימוד של הילדים
        public string InLawNames { get; set; } // שמות מחותנים (לפרט עיר\כתובת)
        public string FinancialArrangement { get; set; } // הסתדרות כלכלית

        // משתתפים
        public int NumberOfParticipants { get; set; } // כמה משתתפים יהיו
        public int ExpectedParticipants { get; set; } // כמה מצפים

        // גמישות
        public bool IsFlexible { get; set; } // גמיש-כן או לא
        public bool SignedOrganization { get; set; } // חתומים על ארגון שהשמחה במעונו
        public int MatchmakingFee { get; set; } // דמי שדכנות
      
        public Male Male { get; set; }
        public int MaleId { get; set; } // מפתח זר לקשר עם אדם

        public Women Women { get; set; }
        public int WomenId { get; set; } // מפתח זר לקשר עם אדם
    }
}
