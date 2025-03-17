using MatchMakings.Core.DTOs;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiMatchMaker.Controllers
{
    //[Authorize(Roles = "Admin")] // 👑 רק המנהל יכול לגשת לפה!
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAuthService _authService;

        public AdminController(IConfiguration config, IAuthService authService)
        {
            _config = config;
            _authService = authService;
        }
        [HttpPost("login")]
        public IActionResult AdminLogin([FromBody] LoginDTO loginDto)
        {
            Console.WriteLine($"🔹 מנסה להתחבר עם: {loginDto.Username}");
            Console.WriteLine($"🔹 סיסמה שהוזנה: {loginDto.Password}");
            Console.WriteLine($"🔹 סיסמה במערכת: {_config["Admin:Password"]}");

            if (loginDto.Username == _config["Admin:Username"] && loginDto.Password == _config["Admin:Password"])
            {
                var token = _authService.GenerateToken(new BaseUser
                {
                    Id = 0,
                    Username = loginDto.Username,
                    Role = "Admin"
                });

                Console.WriteLine("✅ התחברות הצליחה! נוצר טוקן.");
                Console.WriteLine($"Configured Key: {_config["Jwt:Key"]}");
                return Ok(new { Token = token, Role = "Admin" });
            }

            Console.WriteLine("❌ שם משתמש או סיסמה שגויים!");
            return Unauthorized("שם משתמש או סיסמה שגויים!");
        }
        [HttpDelete("delete-user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _authService.GetUserById(id);
            if (user == null) return NotFound("❌ משתמש לא נמצא!");

            await _authService.DeleteUser(id);
            return Ok("✅ המשתמש נמחק בהצלחה!");
        }
    }
}
