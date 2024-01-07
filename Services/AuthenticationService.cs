using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using JwtAuthenticationManager;
using System.Security.Claims;
using System.Text;
using UserLoginBE.Common;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Mvc;

namespace UserLoginBE.Services
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        private User? _user;

        public AuthenticationService(IMapper mapper,
            UserManager<User> userManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterUser(UserRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var roleInValid = userForRegistration.Roles.FirstOrDefault(x => !RoleConstant.ListRoles.Contains(x));

            if (roleInValid != null)
            {
                throw new Exception("Role invalid");
            }

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);

            return result;
        }
        public async Task<IdentityResult> RegisterAdmin(AdminRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var roleInValid = userForRegistration.Roles.FirstOrDefault(x => !RoleConstant.ListRoles.Contains(x));

            if (roleInValid != null)
            {
                throw new Exception("Role invalid");
            }

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);

            return result;
        }

        public async Task<UserValidateResponse> ValidateUser(UserLogin userForAuth)
        {
            var userRS = new UserValidateResponse();
            _user = await _userManager.FindByNameAsync(userForAuth.UserName);
               
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password));
            if (result)
            {
                var roles = await _userManager.GetRolesAsync(_user);
                if (roles != null)
                {
                    userRS.Role = string.Join("," ,roles.ToArray());
                    return userRS;
                }
                
            }
            return null;
        }
    
        public async Task<UserProfile> GetUserProfile()
        {
            return new UserProfile
            {
                Name = "Trutran",
                Address = "12334 ly co dieu",
                cmnd = "123456789",
                Email = "trutran1992@gmail.com",
                CreatedAt = DateTime.Now.ToShortDateString(),
                phoneNumber = "0966145414",
                UserName = "trutran"
            };
        }
        //public async Task<string> CreateToken()
        //{
        //    var signingCredentials = GetSigningCredentials();
        //    var claims = await GetClaims();
        //    var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

        //    return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        //}

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("SECRET").ToString());
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, _user.UserName)
        };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                signingCredentials: signingCredentials
            );

            return tokenOptions;
        }
    }
}
