using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Service
{
    class FamilyDetailsService : IFamilyDetailsService
    {
        readonly private IFamilyDetailsRepository _FamilyDetailsRepository;

        public FamilyDetailsService(IFamilyDetailsRepository familyDetailsRepository)
        {
            _FamilyDetailsRepository = familyDetailsRepository ?? throw new ArgumentNullException(nameof(familyDetailsRepository));
        }

        public async Task<FamilyDetails> AddFamilyDetailsAsync(FamilyDetails familyDetails)
        {
            await _FamilyDetailsRepository.AddFamilyDetailsAsync(familyDetails);
            return familyDetails;
        }

        public async Task<FamilyDetails> DeleteFamilyDetailsAsync(int id)
        {
            return await _FamilyDetailsRepository.DeleteFamilyDetailsAsync(id);
        }

        public async Task<FamilyDetails> GetFamilyDetailsByIdAsync(int id)
        {
            return await _FamilyDetailsRepository.GetFamilyDetailsByIdAsync(id);
        }

        public async Task<IEnumerable<FamilyDetails>> GetListOfFamilyDetailsAsync()
        {
            return await _FamilyDetailsRepository.GetListOfFamilyDetailsAsync();

        }

        public async Task<FamilyDetails> UpdateFamilyDetailsAsync(int id, FamilyDetails familyDetails)
        {
            return await _FamilyDetailsRepository.UpdateFamilyDetailsAsync(id, familyDetails);
        }
    }
}
