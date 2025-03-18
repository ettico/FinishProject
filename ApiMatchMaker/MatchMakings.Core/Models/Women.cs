using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public  class Women:BaseUser
    {
        public Women(string FName, string LName, string Username, string Password, string Role) : base(FName, LName, Username, Password, Role)
        {
        }
        public Women()
        {
                
        }
        //public int Id { get; set; }
        //public string? FirstName { get; set; }
        //public string? LastName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public string? Tz { get; set; }
        public string? Class { get; set; }//חוג
        public bool? AnOutsider { get; set; } = false;//חוצניק -מאותחל אוטומטית ב false
        public string? BackGround { get; set; }    //רקע-לדוג חוזרים בתשובה חרדים וכדו
        public string? Openness { get; set; }
        //public string? Gender { get; set; } //מגדר-בחור או בחורה   
        public DateTime? BurnDate { get; set; }
        public int? Age { get; set; }
        public bool ? HealthCondition { get; set; }//מצב בריאותי-1-תקין/0-לא תקין
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
        public List<Contact>? Contacts { get; set; }  // מכרי המשפחה חברים ואנשים לברר אצלם
        public FamilyDetails? FamilyDetails { get; set; }

        // כיסוי ראש - מידע על כיסוי הראש
        public string? HeadCovering { get; set; }

        // רקע השכלתי - תיכון של הבחורה
        public string? HighSchool { get; set; }

        // סמינר - רקע חינוכי נוסף
        public string? Seminar { get; set; }

        // מסלול לימודי - המסלול הלימודי של הבחורה
        public string? StudyPath { get; set; }

        // מוסד לימודים נוסף - מוסד נוסף אם יש
        public string? AdditionalEducationalInstitution { get; set; } // לא חובה

        // עיסוק כיום - העיסוק הנוכחי
        public string? CurrentOccupation { get; set; }
        //ציפיות מבן הזוג 

        // - המידע על החוג
        public string? Club { get; set; }

        // מגיל - גיל מינימלי לחיפוש בן זוג
        public int? AgeFrom { get; set; }

        // עד גיל - גיל מקסימלי לחיפוש בן זוג
        public int? AgeTo { get; set; }

        // תכונות חשובות בי - תכונות בבחורה
        public string? ImportantTraitsInMe { get; set; }

        // תכונות חשובות שאני מחפשת - תכונות בבן זוג
        public string? ImportantTraitsIMLookingFor { get; set; }

        // סגנון הישיבות המועדף - סגנון ישיבה מועדף
        public string? PreferredSittingStyle { get; set; }

        // מעוניינת שהבחור יהיה - מה שהבחורה רוצה בבן זוג
        public string? InterestedInBoy { get; set; }

        // רישיון נהיגה - מידע על רישיון נהיגה
        public string? DrivingLicense { get; set; }

        //  מעשן - מידע על הרגלי עישון
        public bool? Smoker { get; set; }

        // זקן - מידע על העדפת זקן
        public string? Beard { get; set; }

        // כובע - מידע על העדפת כובע
        public string? Hat { get; set; }

        // חליפה - מידע על העדפת חליפה
        public string? Suit { get; set; }

        // עיסוק - העיסוק של בן הזוג
        public string   ? Occupation { get; set; }


        public List<MatchMaking>? Matchings { get; set; }

    }
}
