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
    public class MatchMakingRepository: IMatchMakingRepository
    {
        private readonly DataContext _dataContext;

        public MatchMakingRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<MatchMaking>> GetListOfMatchMakingAsync()
        {
            return await _dataContext.MatchMakings.Include(u => u.Male).ToListAsync();//todo
        }

        public async Task<MatchMaking> GetMatchMakingByIdAsync(int id)
        {
            var MatchMaking = await _dataContext.MatchMakings.FirstOrDefaultAsync(x => x.Id == id);
            if (MatchMaking == null)
            {
                throw new ArgumentException($"MatchMaking with id {id} was not found.");
            }
            return MatchMaking;
        }

        public async Task<MatchMaking> AddMatchMakingAsync(MatchMaking MatchMaking)
        {
            _dataContext.MatchMakings.Add(MatchMaking);
            await _dataContext.SaveChangesAsync();
            return MatchMaking;
        }


        public async Task<MatchMaking> UpdateMatchMakingAsync(int id, MatchMaking MatchMaking)
        {
            await DeleteMatchMakingAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddMatchMakingAsync(MatchMaking);


        }
        public async Task<MatchMaking> DeleteMatchMakingAsync(int id)
        {
            var MatchMaking = await _dataContext.MatchMakings.FirstOrDefaultAsync(x => x.Id == id);
            if (MatchMaking == null)
            {
                throw new ArgumentException($"MatchMaking with id {id} was not found.");
            }
            _dataContext.MatchMakings.Remove(MatchMaking);
            await _dataContext.SaveChangesAsync();
            return MatchMaking;
        }
    }
}
