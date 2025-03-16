using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using MatchMakings.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MatchMakerController : ControllerBase
    {

      
      
        private readonly IMatchMakerService _matchMakerService;
        //private readonly IMapper _mapper;
        public MatchMakerController(IMatchMakerService matchMakerService)/*, IMapper mapper*/
        {
            _matchMakerService = matchMakerService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _matchMakerService.GetListOfMatchMakerAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchMaker>> Get(int id)
        {
            var mm = await _matchMakerService.GetMatchMakerByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(mm);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<MatchMaker>> Post([FromBody] MatchMaker m)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _matchMakerService.AddMatchMakerAsync(m);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<MatchMaker>> Put(int id, [FromBody] MatchMaker m)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _matchMakerService.UpdateMatchMakerAsync(id, m);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MatchMaker>> Delete(int id)
        {
            return await _matchMakerService.DeleteMatchMakerAsync(id);
        }
    }
}
