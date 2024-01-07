using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserLoginBE.Common;
using UserLoginBE.Models;
using UserLoginBE.Services.Ward;

namespace UserLoginBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _DistrictService;
        public DistrictController(IDistrictService service)
        {
            _DistrictService = service;
        }
        [HttpGet()]
        public async Task<ActionResult<BaseResponse<List<DistrictDto>>>> GetListAsync()
        {
            BaseResponse<List<DistrictDto>> rs = new();
            rs.Data = await _DistrictService.GetListAsync();
            return rs;
        }
    }
}
