using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WomenController : ControllerBase
    {
        private readonly IWomenService _womenService;
        //private readonly IMapper _mapper;
        public WomenController(IWomenService womenService)/*, IMapper mapper*/
        {
            _womenService = womenService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _womenService.GetListOfWomenAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Women>> Get(int id)
        {
            var women = await _womenService.GetWomenByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(women);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Women>> Post([FromBody] Women w)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _womenService.AddWomenAsync(w);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Women>> Put(int id, [FromBody] Women w)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _womenService.UpdateWomenAsync(id, w);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Women>> Delete(int id)
        {
            return await _womenService.DeleteWomenAsync(id);
        }
    }
}
