using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UserLoginBE.Common;
using UserLoginBE.Context;
using UserLoginBE.Entities.Models;
using UserLoginBE.Models;

namespace UserLoginBE.Services.Ward
{
    public class DistrictService : IDistrictService
    {
        private readonly UserLoginContext _userLoginContext;
        private readonly IMapper _mapper;
        public DistrictService(UserLoginContext context, IMapper mapper)
        {
            _userLoginContext = context;
            _mapper = mapper;
        }
        public async Task<List<DistrictDto>> GetListAsync()
        {
            var wards = await _userLoginContext.District.ToListAsync();
            return _mapper.Map<List<DistrictDto>>(wards);
        }
    }
}
