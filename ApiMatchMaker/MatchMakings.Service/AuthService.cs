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
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginDto.Username && u.Password == loginDto.Password);
        }

        public async Task<BaseUser> RegisterUser(RegisterDTO registerDto)
        {
            var user = new BaseUser(registerDto.FirstName, registerDto.LastName,
               registerDto.Username, registerDto.Password, registerDto.Role);
           
           

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public string GenerateToken(BaseUser user)
        {
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
    }
}
