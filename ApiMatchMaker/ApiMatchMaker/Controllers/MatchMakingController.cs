using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchMakingController : ControllerBase
    {
        private readonly IMatchMakingService _matchMakingService;
        //private readonly IMapper _mapper;
        public MatchMakingController(IMatchMakingService matchMakingService)/*, IMapper mapper*/
        {
            _matchMakingService = matchMakingService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _matchMakingService.GetListOfMatchMakingAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchMaking>> Get(int id)
        {
            var mm = await _matchMakingService.GetMatchMakingByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(mm);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<MatchMaking>> Post([FromBody] MatchMaking m)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _matchMakingService.AddMatchMakingAsync(m);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<MatchMaking>> Put(int id, [FromBody] MatchMaking m)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _matchMakingService.UpdateMatchMakingAsync(id, m);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MatchMaking>> Delete(int id)
        {
            return await _matchMakingService.DeleteMatchMakingAsync(id);
        }
    }
}
