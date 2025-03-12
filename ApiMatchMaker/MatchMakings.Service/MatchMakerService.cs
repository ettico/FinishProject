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
    public class MatchMakerService : IMatchMakerService
    {
        readonly private IMatchMakerRepository _MatchMakerRepository;

        public MatchMakerService(IMatchMakerRepository matchMakerRepository)
        {
            _MatchMakerRepository = matchMakerRepository ?? throw new ArgumentNullException(nameof(matchMakerRepository));
        }

        public async Task<MatchMaker> AddMatchMakerAsync(MatchMaker matchMaker)
        {
            await _MatchMakerRepository.AddMatchMakerAsync(matchMaker);
            return matchMaker;
        }

        public async Task<MatchMaker> DeleteMatchMakerAsync(int id)
        {
            return await _MatchMakerRepository.DeleteMatchMakerAsync(id);
        }

        public async Task<MatchMaker> GetMatchMakerByIdAsync(int id)
        {
            return await _MatchMakerRepository.GetMatchMakerByIdAsync(id);
        }

        public async Task<IEnumerable<MatchMaker>> GetListOfMatchMakerAsync()
        {
            return await _MatchMakerRepository.GetListOfMatchMakerAsync();

        }

        public async Task<MatchMaker> UpdateMatchMakerAsync(int id, MatchMaker matchMaker)
        {
            return await _MatchMakerRepository.UpdateMatchMakerAsync(id, matchMaker);
        }
    }
}
