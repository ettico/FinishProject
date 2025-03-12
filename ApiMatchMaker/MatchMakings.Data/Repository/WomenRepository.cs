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
    class WomenRepository: IWomenRepository
    {
        private readonly DataContext _dataContext;

        public WomenRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Women>> GetListOfWomenAsync()
        {
            return await _dataContext.Womens.Include(u => u.Id).ToListAsync();//todo
        }

        public async Task<Women> GetWomenByIdAsync(int id)
        {
            var Women = await _dataContext.Womens.FirstOrDefaultAsync(x => x.Id == id);
            if (Women == null)
            {
                throw new ArgumentException($"Women with id {id} was not found.");
            }
            return Women;
        }

        public async Task<Women> AddWomenAsync(Women Women)
        {
            _dataContext.Womens.Add(Women);
            await _dataContext.SaveChangesAsync();
            return Women;
        }


        public async Task<Women> UpdateWomenAsync(int id, Women Women)
        {
            await DeleteWomenAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddWomenAsync(Women);


        }
        public async Task<Women> DeleteWomenAsync(int id)
        {
            var Women = await _dataContext.Womens.FirstOrDefaultAsync(x => x.Id == id);
            if (Women == null)
            {
                throw new ArgumentException($"Contact with id {id} was not found.");
            }
            _dataContext.Womens.Remove(Women);
            await _dataContext.SaveChangesAsync();
            return Women;
        }
    }
}
