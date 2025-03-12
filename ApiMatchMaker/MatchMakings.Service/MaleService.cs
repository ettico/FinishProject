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
    class MaleService : IMaleService
    {
        readonly private IMaleRepository _MaleRepository;

        public MaleService(IMaleRepository maleRepository)
        {
            _MaleRepository = maleRepository ?? throw new ArgumentNullException(nameof(maleRepository));
        }

        public async Task<Male> AddMaleAsync(Male male)
        {
            await _MaleRepository.AddMaleAsync(male);
            return male;
        }

        public async Task<Male> DeleteMaleAsync(int id)
        {
            return await _MaleRepository.DeleteMaleAsync(id);
        }

        public async Task<Male> GetMaleByIdAsync(int id)
        {
            return await _MaleRepository.GetMaleByIdAsync(id);
        }

        public async Task<IEnumerable<Male>> GetListOfMaleAsync()
        {
            return await _MaleRepository.GetListOfMaleAsync();

        }

        public async Task<Male> UpdateMaleAsync(int id, Male male)
        {
            return await _MaleRepository.UpdateMaleAsync(id, male);
        }
    }
}
