using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    // **🚀 הרשמה למועמד (גבר/אישה)**
    [HttpPost("register/candidate")]
    public async Task<IActionResult> RegisterCandidate([FromBody] RegisterCandidateRequest request)
    {
        var token = await _authService.RegisterCandidate(request.FirstName, request.LastName, request.Username, request.Password, request.Gender);
        if (token == null) return BadRequest("הרשמה נכשלה");
        return Ok(new { Token = token });
    }

    // **🚀 הרשמה לשדכנית**
    [HttpPost("register/shadchanit")]
    public async Task<IActionResult> RegisterShadchanit([FromBody] RegisterShadchanitRequest request)
    {
        var token = await _authService.RegisterShadchanit(request.FirstName, request.LastName, request.Username, request.Password);
        if (token == null) return BadRequest("הרשמה נכשלה");
        return Ok(new { Token = token });
    }

    // **🔑 כניסת משתמש (גבר/אישה/שדכנית)**
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var token = await _authService.Login(request.Username, request.Password);
        if (token == null) return Unauthorized("שם משתמש או סיסמה שגויים");
        return Ok(new { Token = token });
    }
}

// **📌 מודלים ל- Request**
public class RegisterCandidateRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Gender { get; set; } // "Male" או "Female"
}

public class RegisterShadchanitRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
