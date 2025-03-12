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
    class MeetingRepository: IMeetingRepository
    {
        private readonly DataContext _dataContext;

        public MeetingRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Meeting>> GetListOfMeetingAsync()
        {
            return await _dataContext.Meetings.Include(u => u.Id).ToListAsync();//todo
        }

        public async Task<Meeting> GetMeetingByIdAsync(int id)
        {
            var Meeting = await _dataContext.Meetings.FirstOrDefaultAsync(x => x.Id == id);
            if (Meeting == null)
            {
                throw new ArgumentException($"Meeting with id {id} was not found.");
            }
            return Meeting;
        }

        public async Task<Meeting> AddMeetingAsync(Meeting Meeting)
        {
            _dataContext.Meetings.Add(Meeting);
            await _dataContext.SaveChangesAsync();
            return Meeting;
        }


        public async Task<Meeting> UpdateMeetingAsync(int id, Meeting Meeting)
        {
            await DeleteMeetingAsync(id);
            await _dataContext.SaveChangesAsync();
            return await AddMeetingAsync(Meeting);


        }
        public async Task<Meeting> DeleteMeetingAsync(int id)
        {
            var Meeting = await _dataContext.Meetings.FirstOrDefaultAsync(x => x.Id == id);
            if (Meeting == null)
            {
                throw new ArgumentException($"Meeting with id {id} was not found.");
            }
            _dataContext.Meetings.Remove(Meeting);
            await _dataContext.SaveChangesAsync();
            return Meeting;
        }
    }
}
