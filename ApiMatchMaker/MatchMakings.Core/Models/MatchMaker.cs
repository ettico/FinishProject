using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class MatchMaker
    {
        public int Id { get; set; }
        public string FirstName { get; set; } // שם פרטי 
        public string LastName { get; set; } // שם משפחה 
        public string MatchmakerName { get; set; } // שם שדכן
        public string IdNumber { get; set; } // תעודת זהות
        public DateTime BirthDate { get; set; } // תאריך לידה
        public string Email { get; set; } // כתובת מייל
        public string Gender { get; set; } // מגדר
        public string City { get; set; } // עיר
        public string Address { get; set; } // כתובת
        public string MobilePhone { get; set; } // טלפון נייד
        public string LandlinePhone { get; set; } // טלפון נייח (אופציונלי)
        public string PhoneType { get; set; } // סוג טלפון (כשר, מוגן או לא כשר)

        public string PersonalClub { get; set; } // חוג אישי
        public string Community { get; set; } // קהילה
        public string Occupation { get; set; } // עיסוק - יש לציין שם ומיקום
        public string PreviousWorkplaces { get; set; } // מקומות עבודה בעבר - יש לציין שם ומיקום
        public bool IsSeminarGraduate { get; set; } // בוגרת סמינר
        public bool HasChildrenInShidduchim { get; set; } // האם יש ילדים בשידוכים או לא

        public string ExperienceInShidduchim { get; set; } // נסיון בתחום השידוכים - חובה למלא ברצינות
        public string LifeSkills { get; set; } // כישורי חיים
        public int YearsInShidduchim { get; set; } // כמה זמן עוסק בשידוכים
        public bool IsInternalMatchmaker { get; set; } // האם אתה שדכן פנימי
        public string PrintingNotes { get; set; } // הערות להדפסה באלפון כמו שעות מענה וכו'
        public List<Contact> Recommend { get; set; } // ממליצים לבירורים
        public List<MatchMaking> Matches { get; set; }

    }
}
