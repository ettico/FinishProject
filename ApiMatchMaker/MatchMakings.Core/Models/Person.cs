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
        public int Age { get; set; }    
        public double Height { get; set; }    
        public string Community { get; set; }    
        public string Phone { get; set; }    
        public string Description { get; set; }    
        public string Email { get; set; }    
        public DateTime BurnDate { get; set; }    
        //public FileInfo Resume { get; set; }   //קובץ רזומה 
           
    }
}
