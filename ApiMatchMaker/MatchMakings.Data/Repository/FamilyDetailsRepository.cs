using MatchMakings.Core.IRepositories;
using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;


namespace MatchMakings.Data.Repository
{
    public class FamilyDetailsRepository : IFamilyDetailsRepository
    {
        private readonly DataContext _dataContext;

        public FamilyDetailsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<FamilyDetails>> GetListOfFamilyDetailsAsync()
        {
            return await _dataContext.FamilyDetails.Include(u => u.Women).ToListAsync();//todo
        }

        public async Task<FamilyDetails> GetFamilyDetailsByIdAsync(int id)
        {
            var FamilyDetails = await _dataContext.FamilyDetails.FirstOrDefaultAsync(x => x.Id == id);
            if (FamilyDetails == null)
            {
                throw new ArgumentException($"FamilyDetails with id {id} was not found.");
            }
            return FamilyDetails;
        }

        public async Task<FamilyDetails> AddFamilyDetailsAsync(FamilyDetails familyDetails)
        {
            _dataContext.FamilyDetails.Add(familyDetails);
            await _dataContext.SaveChangesAsync();
            return familyDetails;
        }


        public async Task<FamilyDetails> UpdateFamilyDetailsAsync(int id, FamilyDetails familyDetails)
        {
            await DeleteFamilyDetailsAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddFamilyDetailsAsync(familyDetails);


        }
        public async Task<FamilyDetails> DeleteFamilyDetailsAsync(int id)
        {
            var familyDetails = await _dataContext.FamilyDetails.FirstOrDefaultAsync(x => x.Id == id);
            if (familyDetails == null)
            {
                throw new ArgumentException($"FamilyDetails with id {id} was not found.");
            }
            _dataContext.FamilyDetails.Remove(familyDetails);
            await _dataContext.SaveChangesAsync();
            return familyDetails;
        }
    }
}
