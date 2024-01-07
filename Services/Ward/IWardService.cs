using UserLoginBE.Models;

namespace UserLoginBE.Services.Ward
{
    public interface IWardService
    {
        Task<List<WardDto>> GetListAsync();
    }
}
