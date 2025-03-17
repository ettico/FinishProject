using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MatchMakings.Core.DTOs;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using MatchMakings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MatchMakings.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public AuthService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<BaseUser> AuthenticateUser(LoginDTO loginDto)
        {
            //// 🔥 בדיקה אם המשתמש הוא המנהל עם פרטים קבועים
            //if (loginDto.Username == "etti0475@gmail.com" && loginDto.Password == "Admin123!")
            //{
            //    return new BaseUser
            //    {
            //        Id = 999, // מספר מזהה קבוע למנהל
            //        Username = "etti0475@gmail.com",
            //        Password = "Admin123!",
            //        Role = "Admin"
            //    };
            //}

            // חיפוש משתמש רגיל במסד הנתונים
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginDto.Username && u.Password == loginDto.Password);
        }


        public async Task<BaseUser> RegisterUser(RegisterDTO registerDto)
        {
            // 🔍 בדיקה אם המשתמש כבר קיים
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == registerDto.Username);

            if (existingUser != null)
            {
                throw new InvalidOperationException("⚠ המשתמש כבר קיים במערכת!");
            }

            var user = new BaseUser(registerDto.FirstName, registerDto.LastName,
               registerDto.Username, registerDto.Password, registerDto.Role);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public string GenerateToken(BaseUser user)
        {

            var keyString = _config["Jwt:Key"];
            if (keyString != null)
            {
                Console.WriteLine($"🔑 Key used to generate token: {keyString}");
            }
            else
            {
                Console.WriteLine("token is null");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<BaseUser> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) throw new InvalidOperationException("❌ משתמש לא נמצא!");

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

    }
}
