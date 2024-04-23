using Auth.DTOs;
using Auth.MyModels;

namespace Auth.Services.AuthService
{
    public interface IAuthService
    {
        public Task<AuthDTO> GenerateToken(AppUser user);
    }
}
