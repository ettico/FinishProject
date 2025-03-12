using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IMeetingService
    {
        public Task<IEnumerable<Meeting>> GetListOfMeetingAsync();
        public Task<Meeting> GetMeetingByIdAsync(int id);
        public Task<Meeting> AddMeetingAsync(Meeting meeting);
        public Task<Meeting> DeleteMeetingAsync(int id);
        public Task<Meeting> UpdateMeetingAsync(int id, Meeting meeting);
    }
}
