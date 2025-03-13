using MatchMakings.Core.IRepositories;
using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MatchMakings.Data.Repository
{
     public class ContactRepository : IContactRepository
    {
        private readonly DataContext _dataContext;

        public ContactRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Contact>> GetListOfContactAsync()
        {
            return await _dataContext.Contacts.Include(u => u.MatchMaker).ToListAsync();//todo
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            var Contact = await _dataContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (Contact == null)
            {
                throw new ArgumentException($"Contact with id {id} was not found.");
            }
            return Contact;
        }

        public async Task<Contact> AddContactAsync(Contact contact)
        {
            _dataContext.Contacts.Add(contact);
            await _dataContext.SaveChangesAsync();
            return contact;
        }


        public async Task<Contact> UpdateContactAsync(int id, Contact contact)
        {
            await DeleteContactAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddContactAsync( contact);


        }
        public async Task<Contact> DeleteContactAsync(int id)
        {
            var Contact = await _dataContext.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (Contact == null)
            {
                throw new ArgumentException($"Contact with id {id} was not found.");
            }
            _dataContext.Contacts.Remove(Contact);
            await _dataContext.SaveChangesAsync();
            return Contact;
        }
    }
}
