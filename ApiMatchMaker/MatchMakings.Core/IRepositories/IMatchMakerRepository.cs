using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IRepositories
{
    public interface IMatchMakerRepository
    {
        public Task<IEnumerable<MatchMaker>> GetListOfMatchMakerAsync();
        public Task<MatchMaker> GetMatchMakerByIdAsync(int id);
        public Task<MatchMaker> AddMatchMakerAsync(MatchMaker matchMaker);
        public Task<MatchMaker> DeleteMatchMakerAsync(int id);
        public Task<MatchMaker> UpdateMatchMakerAsync(int id, MatchMaker matchMaker);
    }
}
