using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
    //[NotMapped]
    public  class BaseUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Male", "Women", "MatchMaker"
        public BaseUser(string FName,string LName, string Username,string Password,string Role)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }
        public BaseUser()
        {
                
        }
    }
}
