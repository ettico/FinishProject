using MatchMakings.Core.DTOs;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
   public interface IAuthService
   {
        string GenerateToken(BaseUser user);
        Task<BaseUser> AuthenticateUser(LoginDTO loginDto);
        Task<BaseUser> RegisterUser(RegisterDTO registerDto);

   }
}
