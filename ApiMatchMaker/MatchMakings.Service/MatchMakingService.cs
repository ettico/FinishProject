using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Service
{
    public class MatchMakingService : IMatchMakingService
    {
        readonly private IMatchMakingRepository _MatchMakingRepository;

        public MatchMakingService(IMatchMakingRepository matchMakingRepository)
        {
            _MatchMakingRepository = matchMakingRepository ?? throw new ArgumentNullException(nameof(matchMakingRepository));
        }

        public async Task<MatchMaking> AddMatchMakingAsync(MatchMaking matchMaking)
        {
            await _MatchMakingRepository.AddMatchMakingAsync(matchMaking);
            return matchMaking;
        }

        public async Task<MatchMaking> DeleteMatchMakingAsync(int id)
        {
            return await _MatchMakingRepository.DeleteMatchMakingAsync(id);
        }

        public async Task<MatchMaking> GetMatchMakingByIdAsync(int id)
        {
            return await _MatchMakingRepository.GetMatchMakingByIdAsync(id);
        }

        public async Task<IEnumerable<MatchMaking>> GetListOfMatchMakingAsync()
        {
            return await _MatchMakingRepository.GetListOfMatchMakingAsync();

        }

        public async Task<MatchMaking> UpdateMatchMakingAsync(int id, MatchMaking matchMaking)
        {
            return await _MatchMakingRepository.UpdateMatchMakingAsync(id, matchMaking);
        }
    }
}
