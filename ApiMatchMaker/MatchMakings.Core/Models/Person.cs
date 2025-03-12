using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Tz { get; set; }
        public string Class { get; set; }//חוג
        public bool AnOutsider { get; set; } = false;//חוצניק -מאותחל אוטומטית ב false
        public string BackGround{ get; set; }    //רקע-לדוג חוזרים בתשובה חרדים וכדו
        public string Openness { get; set; }    
        public string Gender { get; set; } //מגדר-בחור או בחורה   
        public DateTime BurnDate { get; set; }
        public int Age { get; set; }
        public bool HealthCondition { get; set; }//מצב בריאותי-1-תקין/0-לא תקין
        public string Status { get; set; } 
        public bool StatusVacant { get; set; }
        public string PairingType { get; set; }//זיווג ראשון/שני /ביטל שידוך
        public double Height { get; set; }//גובה
        public string GeneralAppearance { get; set; }//מראה כללי
        public string FacePaint { get; set; }    //צבע פנים
        public string Appearance { get; set; } //מראה חיצוני
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FatherPhone { get; set; }
        public string MotherPhone { get; set; }
        public string MoreInformation { get; set; }// מידע נוסף
        public List<Contact> Acquaintances { get; set; }  // מכרי המשפחה חברים ואנשים לברר אצלם
        public FamilyDetails FamilyDetails { get; set; }
    }
}
