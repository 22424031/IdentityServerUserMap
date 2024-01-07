using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserLoginBE.Common;
using UserLoginBE.Models;
using UserLoginBE.Services.Ward;

namespace UserLoginBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IWardService _wardService;
        public WardController(IWardService wardService) {
            _wardService = wardService;
        }
        [HttpGet()]
        public async Task<ActionResult<BaseResponse<List<WardDto>>>> GetListAsync()
        {
            BaseResponse < List < WardDto >> rs = new();
            rs.Data = await _wardService.GetListAsync();
            return rs;
        }
    }
}
