using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IMatchMakingService
    {
        public Task<IEnumerable<MatchMaking>> GetListOfMatchMakingAsync();
        public Task<MatchMaking> GetMatchMakingByIdAsync(int id);
        public Task<MatchMaking> AddMatchMakingAsync(MatchMaking matchMaking);
        public Task<MatchMaking> DeleteMatchMakingAsync(int id);
        public Task<MatchMaking> UpdateMatchMakingAsync(int id, MatchMaking matchMaking);
    }
}
