using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService _meetingService;
        //private readonly IMapper _mapper;
        public MeetingController(IMeetingService meetingService)/*, IMapper mapper*/
        {
            _meetingService = meetingService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _meetingService.GetListOfMeetingAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meeting>> Get(int id)
        {
            var meeting = await _meetingService.GetMeetingByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(meeting);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Meeting>> Post([FromBody] Meeting m)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _meetingService.AddMeetingAsync(m);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Meeting>> Put(int id, [FromBody] Meeting m)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _meetingService.UpdateMeetingAsync(id, m);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Meeting>> Delete(int id)
        {
            return await _meetingService.DeleteMeetingAsync(id);
        }
    }
}
