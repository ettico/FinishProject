using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MatchMakings.Core.IRepositories
{
   public interface IContactRepository
    {
        public Task<IEnumerable<Contact>> GetListOfContactAsync();
        public Task<Contact> GetContactByIdAsync(int id);
        public Task<Contact> AddContactAsync(Contact contact);
        public Task<Contact> DeleteContactAsync(int id);
        public Task<Contact> UpdateContactAsync(int id, Contact contact);

    }
}
