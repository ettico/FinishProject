using MatchMakings.Core.IRepositories;
using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Data.Repository
{
   
    public class MatchMakerRepository: IMatchMakerRepository
    {
        private readonly DataContext _dataContext;

        public MatchMakerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<MatchMaker>> GetListOfMatchMakerAsync()
        {
            return await _dataContext.MatchMakers.Include(u => u.Id).ToListAsync();//todo
        }

        public async Task<MatchMaker> GetMatchMakerByIdAsync(int id)
        {
            var MatchMaker = await _dataContext.MatchMakers.FirstOrDefaultAsync(x => x.Id == id);
            if (MatchMaker == null)
            {
                throw new ArgumentException($"MatchMaker with id {id} was not found.");
            }
            return MatchMaker;
        }

        public async Task<MatchMaker> AddMatchMakerAsync(MatchMaker MatchMaker)
        {
            _dataContext.MatchMakers.Add(MatchMaker);
            await _dataContext.SaveChangesAsync();
            return MatchMaker;
        }


        public async Task<MatchMaker> UpdateMatchMakerAsync(int id, MatchMaker MatchMaker)
        {
            await DeleteMatchMakerAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddMatchMakerAsync(MatchMaker);


        }
        public async Task<MatchMaker> DeleteMatchMakerAsync(int id)
        {
            var MatchMaker = await _dataContext.MatchMakers.FirstOrDefaultAsync(x => x.Id == id);
            if (MatchMaker == null)
            {
                throw new ArgumentException($"MatchMaker with id {id} was not found.");
            }
            _dataContext.MatchMakers.Remove(MatchMaker);
            await _dataContext.SaveChangesAsync();
            return MatchMaker;
        }
    }
}
