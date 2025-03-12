using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IRepositories
{
    public interface IFamilyDetailsRepository
    {
        public Task<IEnumerable<FamilyDetails>> GetListOfFamilyDetailsAsync();
        public Task<FamilyDetails> GetFamilyDetailsByIdAsync(int id);
        public Task<FamilyDetails> AddFamilyDetailsAsync(FamilyDetails familyDetails);
        public Task<FamilyDetails> DeleteFamilyDetailsAsync(int id);
        public Task<FamilyDetails> UpdateFamilyDetailsAsync(int id, FamilyDetails FamilyDetails);
    }
    
}
