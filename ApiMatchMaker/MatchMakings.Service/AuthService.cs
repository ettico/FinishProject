using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MatchMakings.Data;
using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;

public class AuthService
{
    private readonly DataContext _context;
    private readonly JwtService _jwtService;

    public AuthService(DataContext context, JwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    // **🚀 הרשמת מועמד חדש (גבר/אישה)**
    public async Task<string> RegisterCandidate(string firstName, string lastName, string username, string password, string gender)
    {
        var hashedPassword = HashPassword(password);

        if (gender == "Male")
        {
            var male = new Male { FirstName = firstName, LastName = lastName, Email = username, Tz = hashedPassword };
            _context.Males.Add(male);
            await _context.SaveChangesAsync();
            return _jwtService.GenerateToken(male.Id.ToString(), "MaleCandidate");
        }
        else if (gender == "Female")
        {
            var female = new Women { FirstName = firstName, LastName = lastName, Email = username, Tz = hashedPassword };
            _context.Womens.Add(female);
            await _context.SaveChangesAsync();
            return _jwtService.GenerateToken(female.Id.ToString(), "FemaleCandidate");
        }
        return null;
    }

    // **🚀 הרשמת שדכנית**
    public async Task<string> RegisterShadchanit(string firstName, string lastName, string username, string password)
    {
        var hashedPassword = HashPassword(password);
        var shadchanit = new MatchMaker { FirstName = firstName, LastName = lastName, Email = username, IdNumber = hashedPassword };
        _context.MatchMakers.Add(shadchanit);
        await _context.SaveChangesAsync();
        return _jwtService.GenerateToken(shadchanit.Id.ToString(), "Shadchanit");
    }

    // **🔑 כניסת משתמש (מועמד/שדכנית)**
    public async Task<string> Login(string username, string password)
    {
        var hashedPassword = HashPassword(password);

        var male = await _context.Males.FirstOrDefaultAsync(m => m.Email == username && m.Tz == hashedPassword);
        if (male != null) return _jwtService.GenerateToken(male.Id.ToString(), "MaleCandidate");

        var female = await _context.Womens.FirstOrDefaultAsync(w => w.Email == username && w.Tz == hashedPassword);
        if (female != null) return _jwtService.GenerateToken(female.Id.ToString(), "FemaleCandidate");

        var shadchanit = await _context.MatchMakers.FirstOrDefaultAsync(s => s.Email == username && s.IdNumber == hashedPassword);
        if (shadchanit != null) return _jwtService.GenerateToken(shadchanit.Id.ToString(), "Shadchanit");

        return null;
    }

    // **🛡️ פונקציה להצפנת סיסמה**
    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var b in bytes) builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}
