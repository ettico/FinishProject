using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using MatchMakings.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMatchMaker.Controllers
{
    [Authorize(Roles ="MatchMaker")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        
        private readonly IContactService _contactService;
        //private DataContext _context;

        //private readonly IMapper _mapper;
        public ContactController(IContactService contactService)/*, IMapper mapper*/
        {
            _contactService = contactService;
            //_mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) return Unauthorized("❌ אין זהות בבקשה!");

            var claims = identity.Claims;
            var userId = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

            Console.WriteLine($"🆔 User ID from Token: {userId}");
            Console.WriteLine($"🎭 Role from Token: {role}");

            return Ok($"✅ משתמש מחובר עם ID: {userId} ותפקיד: {role}");
        }


        // GET: api/<CustomerController>
        //[HttpGet]
        //public async Task<ActionResult> Get()
        //{
        //    var list = await _contactService.GetListOfContactAsync();
        //    //var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
        //    return Ok(list);
        //}

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            var con = await _contactService.GetContactByIdAsync(id);
            //var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(con);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Contact>> Post([FromBody] Contact c)
        {
            //var customer = new Contact { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };
            return await _contactService.AddContactAsync(c);
        }

        //PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Contact>> Put(int id, [FromBody] Contact c)
        {
            //var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _contactService.UpdateContactAsync(id, c);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> Delete(int id)
        {
            return await _contactService.DeleteContactAsync(id);
        }
    }
}
