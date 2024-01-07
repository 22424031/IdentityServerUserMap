using AutoMapper;
using JwtAuthenticationManager;
using JwtAuthenticationManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserLoginBE.Common;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;
using UserLoginBE.Services;

namespace UserLoginBE.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly JwtTokenHandler _jwtTokenManager;
        public AuthenticationController(IAuthenticationService authenticationService, JwtTokenHandler jwtTokenHandler)
        {
            _authenticationService = authenticationService;
            _jwtTokenManager = jwtTokenHandler;
        }

        [HttpPost("RegisterUser")]
        public async Task<ActionResult<BaseResponse<bool>>> RegisterUser([FromBody] UserRegistrationDto userForRegistration)
        {
            BaseResponse<bool> rs = new();
            var result = await _authenticationService.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            {
                rs.IsError = true;
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                    rs.ErrorMessage += $"{error.Code}, {error.Description}. ";
                }
                rs.Status = 400;
                return rs;
            }
            rs.Status = 201;
            
            return rs;
        }
        [HttpPost("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] AdminRegistrationDto userForRegistration)
        {
            //var result = await _authenticationService.RegisterAdmin(userForRegistration);
            //if (!result.Succeeded)
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.TryAddModelError(error.Code, error.Description);
            //    }
            //    return BadRequest(ModelState);
            //}

            return StatusCode(201);
        }
        [HttpGet("user-profile")]
        public async Task<UserProfile> GetUserProfile()
        {
            var validResult = await _authenticationService.GetUserProfile();
            return validResult;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserLogin user)
        {
            var validResult = await _authenticationService.ValidateUser(user);
            if (validResult is null)
                return Unauthorized();
            var authenticationRequest = new AuthenticationRequest();
            authenticationRequest.UserName = user.UserName;
            authenticationRequest.Password = user.Password;
            authenticationRequest.Role = validResult.Role   ;
            AuthenticationResponse authenticationResponse = _jwtTokenManager.GenerateJwtToken(authenticationRequest);
            //return Ok(new
            //{
            //    Token = await _authenticationService.CreateToken()
            //});
            return Ok(authenticationResponse);
        }
    }
}
