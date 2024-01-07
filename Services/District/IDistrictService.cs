using UserLoginBE.Models;

namespace UserLoginBE.Services.Ward
{
    public interface IDistrictService
    {
        Task<List<DistrictDto>> GetListAsync();
    }
}
