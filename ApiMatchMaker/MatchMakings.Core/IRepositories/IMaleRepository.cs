using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IRepositories
{
    public interface IMaleRepository
    {
        public Task<IEnumerable<Male>> GetListOfMaleAsync();
        public Task<Male> GetMaleByIdAsync(int id);
        public Task<Male> AddMaleAsync(Male male);
        public Task<Male> DeleteMaleAsync(int id);
        public Task<Male> UpdateMaleAsync(int id, Male male);
    }
}
