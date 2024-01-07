using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UserLoginBE.Common;
using UserLoginBE.Context;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;

namespace UserLoginBE.Services.Ward
{
    public class WardService : IWardService
    {
        private readonly UserLoginContext _userLoginContext;
        private readonly IMapper _mapper;
        public WardService(UserLoginContext context, IMapper mapper)
        {
            _userLoginContext = context;
            _mapper = mapper;
        }
        public async Task<List<WardDto>> GetListAsync()
        {
            var wards = await _userLoginContext.Ward.ToListAsync();
            return _mapper.Map<List<WardDto>>(wards);
        }
    }
}
