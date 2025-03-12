using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class Male // גבר
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? Tz { get; set; }
        public string? Class { get; set; }//חוג
        public bool? AnOutsider { get; set; } = false;//חוצניק -מאותחל אוטומטית ב false
        public string? BackGround { get; set; }    //רקע-לדוג חוזרים בתשובה חרדים וכדו
        public string? Openness { get; set; }
        public string? Gender { get; set; } //מגדר-בחור או בחורה   
        public DateTime? BurnDate { get; set; }
        public int? Age { get; set; }
        public bool? HealthCondition { get; set; }//מצב בריאותי-1-תקין/0-לא תקין
        public string? Status { get; set; }
        public bool? StatusVacant { get; set; }
        public string? PairingType { get; set; }//זיווג ראשון/שני /ביטל שידוך
        public double? Height { get; set; }//גובה
        public string? GeneralAppearance { get; set; }//מראה כללי
        public string? FacePaint { get; set; }    //צבע פנים
        public string? Appearance { get; set; } //מראה חיצוני
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? FatherPhone { get; set; }
        public string? MotherPhone { get; set; }
        public string? MoreInformation { get; set; }// מידע נוסף
        public List<Contact>? Acquaintances { get; set; }  // מכרי המשפחה חברים ואנשים לברר אצלם
        public FamilyDetails? FamilyDetails { get; set; }

        public bool? DriversLicense { get; set; } // רשיון נהיגה
        public bool? Smoker { get; set; } // מעשן
        public string? Beard { get; set; } // זקן
        public string? Hot { get; set; } // כובע
        public string? Suit { get; set; } // חליפה
        public string? SmallYeshiva { get; set; } // ישיבה קטנה
        public string? BigYeshiva { get; set; } // ישיבה גדולה
        public string? Kibbutz { get; set; } // וועד
        public string? Occupation { get; set; } // עיסוק

        // שדות חדשים
        public string? ExpectationsFromPartner { get; set; } // ציפיות מבת הזוג
        public string? Club { get; set; } // חוג
        public int? AgeFrom { get; set; } // מגיל
        public int? AgeTo { get; set; } // עד גיל
        public string? ImportantTraitsInMe { get; set; } // תכונות חשובות בי
        public string? ImportantTraitsIAmLookingFor { get; set; } // תכונות חשובות שאני מחפש
        public string? PreferredSeminarStyle { get; set; } // סגנון הסמינרים המועדף
        public string? PreferredProfessionalPath { get; set; } // מסלול מקצועי מועדף
        public string? HeadCovering { get; set; } // כיסוי ראש

        public MatchMaking? matchMaking { get; set; }
        //public int FamilyDetailsId { get; set; } // מפתח זר לקשר עם פרטי משפחה
        //public FamilyDetails FamilyDetails { get; set; }
    }

}
