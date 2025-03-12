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
    public class MeetingService : IMeetingService
    {
        readonly private IMeetingRepository _MeetingRepository;

        public MeetingService(IMeetingRepository meetingRepository)
        {
            _MeetingRepository = meetingRepository ?? throw new ArgumentNullException(nameof(meetingRepository));
        }

        public async Task<Meeting> AddMeetingAsync(Meeting meeting)
        {
            await _MeetingRepository.AddMeetingAsync(meeting);
            return meeting;
        }

        public async Task<Meeting> DeleteMeetingAsync(int id)
        {
            return await _MeetingRepository.DeleteMeetingAsync(id);
        }

        public async Task<Meeting> GetMeetingByIdAsync(int id)
        {
            return await _MeetingRepository.GetMeetingByIdAsync(id);
        }

        public async Task<IEnumerable<Meeting>> GetListOfMeetingAsync()
        {
            return await _MeetingRepository.GetListOfMeetingAsync();

        }

        public async Task<Meeting> UpdateMeetingAsync(int id, Meeting meeting)
        {
            return await _MeetingRepository.UpdateMeetingAsync(id, meeting);
        }
    }
}
