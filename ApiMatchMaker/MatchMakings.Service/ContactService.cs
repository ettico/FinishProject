using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MatchMakings.Service
{
    public class ContactService : IContactService
    {
        readonly private IContactRepository _ContactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _ContactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
        }

        public async Task<Contact> AddContactAsync(Contact contact)
        {
            await _ContactRepository.AddContactAsync(contact);
            return contact;
        }

        public async Task<Contact> DeleteContactAsync(int id)
        {
            return await _ContactRepository.DeleteContactAsync(id);
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            return await _ContactRepository.GetContactByIdAsync(id);
        }

        public async Task<IEnumerable<Contact>> GetListOfContactAsync()
        {
            return await _ContactRepository.GetListOfContactAsync();

        }

        public async Task<Contact> UpdateContactAsync(int id, Contact contact)
        {
            return await _ContactRepository.UpdateContactAsync(id, contact);
        }
    }
}
