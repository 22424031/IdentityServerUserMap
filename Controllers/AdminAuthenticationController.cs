using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;
using UserLoginBE.Services;
using JwtAuthenticationManager;
using JwtAuthenticationManager.Models;
using System.Reflection.Metadata.Ecma335;

namespace UserLoginBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly JwtTokenHandler _jwtTokenManager;
        public AdminAuthenticationController(IAuthenticationService authenticationService, JwtTokenHandler jwtTokenHandler)
        {
            _authenticationService = authenticationService;
            _jwtTokenManager = jwtTokenHandler;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userForRegistration)
        {
            var result = await _authenticationService.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserLogin user)
        {
            if (await _authenticationService.ValidateUser(user) is null)
                return Unauthorized();
            var authenticationRequest = new AuthenticationRequest();
            authenticationRequest.UserName = user.UserName;
            authenticationRequest.Password = user.Password;
          //  authenticationRequest.Role = user.Roles.ToArray().ToString();
            AuthenticationResponse authenticationResponse = _jwtTokenManager.GenerateJwtToken(authenticationRequest);
            //return Ok(new
            //{
            //    Token = await _authenticationService.CreateToken()
            //});
            return Ok(authenticationResponse);
        }
    }
}
