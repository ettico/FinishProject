using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IWomenService
    {
        public Task<IEnumerable<Women>> GetListOfWomenAsync();
        public Task<Women> GetWomenByIdAsync(int id);
        public Task<Women> AddWomenAsync(Women women);
        public Task<Women> DeleteWomenAsync(int id);
        public Task<Women> UpdateWomenAsync(int id, Women women);
    }
}
