using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaleController : ControllerBase
    {
        private readonly IMaleService _maleService;
        //private readonly IMapper _mapper;
        public MaleController(IMaleService maleService)/*, IMapper mapper*/
        {
            _maleService = maleService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _maleService.GetListOfMaleAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Male>> Get(int id)
        {
            var male = await _maleService.GetMaleByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(male);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Male>> Post([FromBody] Male m)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _maleService.AddMaleAsync(m);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Male>> Put(int id, [FromBody] Male m)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _maleService.UpdateMaleAsync(id, m);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Male>> Delete(int id)
        {
            return await _maleService.DeleteMaleAsync(id);
        }
    }
}
