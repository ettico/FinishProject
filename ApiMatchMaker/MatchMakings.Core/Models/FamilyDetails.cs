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
        public string FatherName { get; set; }
        public string FatherOrigin { get; set; }
        public string FatherYeshiva { get; set; }
        public string FatherAffiliation { get; set; }
        public string FatherOccupation { get; set; }

        public string MotherName { get; set; }
        public string MotherOrigin { get; set; }
        public string MotherGraduateSeminar { get; set; }
        public string MotherPreviousName { get; set; }
        public string MotherOccupation { get; set; }

        public bool? ParentsStatus { get; set; }
        public bool HealthStatus { get; set; }
        public string FamilyRabbi { get; set; }
        public string FamilyAbout { get; set; }

        public int? MaleId { get; set; }
        public Male? Male { get; set; }

        public int? WomenId { get; set; }
        public Women? Women { get; set; }
    }
}
