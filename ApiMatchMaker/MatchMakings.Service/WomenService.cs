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
    public class WomenService : IWomenService
    {
        readonly private IWomenRepository _WomenRepository;

        public WomenService(IWomenRepository womenRepository)
        {
            _WomenRepository = womenRepository ?? throw new ArgumentNullException(nameof(womenRepository));
        }

        public async Task<Women> AddWomenAsync(Women women)
        {
            await _WomenRepository.AddWomenAsync(women);
            return women;
        }

        public async Task<Women> DeleteWomenAsync(int id)
        {
            return await _WomenRepository.DeleteWomenAsync(id);
        }

        public async Task<Women> GetWomenByIdAsync(int id)
        {
            return await _WomenRepository.GetWomenByIdAsync(id);
        }

        public async Task<IEnumerable<Women>> GetListOfWomenAsync()
        {
            return await _WomenRepository.GetListOfWomenAsync();

        }

        public async Task<Women> UpdateWomenAsync(int id, Women women)
        {
            return await _WomenRepository.UpdateWomenAsync(id, women);
        }
    }
}
