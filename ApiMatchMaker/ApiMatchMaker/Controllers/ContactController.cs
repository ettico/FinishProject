using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMatchMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        //private readonly IMapper _mapper;
        public ContactController(IContactService customerService)/*, IMapper mapper*/
        {
            _contactService = customerService;
            //_mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _contactService.GetListOfContactAsync();
            //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(list);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            var cust = await _contactService.GetContactByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(cust);
        }

        // POST api/<CustomerController>
        //[HttpPost]
        //public async Task<ActionResult<Contact>> Post([FromBody] CustomerPostModel c)
        //{
        //    var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
        //    return await _contactService.AddCustomerAsync(customer);
        //}

        // PUT api/<CustomerController>/5
        //[HttpPut("{id}")]
        //public async Task<ActionResult<Contact>> Put(int id, [FromBody] CustomerPostModel c)
        //{
        //    var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

        //    return await _contactService.UpdateCustomerAsync(id, customer);
        //}

        //// DELETE api/<CustomerController>/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Contact>> Delete(int id)
        //{
        //    return await _contactService.DeleteCustomerAsync(id);
        //}
    }
}
