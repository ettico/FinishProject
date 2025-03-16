using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
//using MatchMakings.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMatchMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyDetailsController : ControllerBase
    {
        private readonly IFamilyDetailsService _familyDetailsService;
        //private readonly IMapper _mapper;
        public FamilyDetailsController(IFamilyDetailsService familyDetailsService)/*, IMapper mapper*/
        {
            if (familyDetailsService == null)
            {
                throw new ArgumentNullException(nameof(familyDetailsService));
            }
            _familyDetailsService = familyDetailsService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _familyDetailsService.GetListOfFamilyDetailsAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FamilyDetails>> Get(int id)
        {
            var fm = await _familyDetailsService.GetFamilyDetailsByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(fm);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<FamilyDetails>> Post([FromBody] FamilyDetails f)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _familyDetailsService.AddFamilyDetailsAsync(f);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<FamilyDetails>> Put(int id, [FromBody] FamilyDetails f)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _familyDetailsService.UpdateFamilyDetailsAsync(id, f);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FamilyDetails>> Delete(int id)
        {
            return await _familyDetailsService.DeleteFamilyDetailsAsync(id);
        }
    }
}
