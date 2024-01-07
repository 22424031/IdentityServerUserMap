using Microsoft.AspNetCore.Identity;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;

namespace UserLoginBE.Services
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserRegistrationDto userForRegistration);
        Task<UserValidateResponse> ValidateUser(UserLogin userForAuth);
       // Task<string> CreateToken();
        Task<IdentityResult> RegisterAdmin(AdminRegistrationDto userForRegistration);
        Task<UserProfile> GetUserProfile();
    }
}
