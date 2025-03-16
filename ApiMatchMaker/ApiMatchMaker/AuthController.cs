using Microsoft.AspNetCore.Mvc;

namespace ApiMatchMaker
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // ❗ בדיקת שם משתמש וסיסמה (כרגע דוגמה, אפשר להשתמש ב-DB)
            if (request.Username == "admin" && request.Password == "1234")
            {
                var token = _jwtService.GenerateToken("1", "Admin");
                return Ok(new { Token = token });
            }
            else if (request.Username == "user" && request.Password == "1234")
            {
                var token = _jwtService.GenerateToken("2", "User");
                return Ok(new { Token = token });
            }

            return Unauthorized("שם משתמש או סיסמה שגויים");
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}

