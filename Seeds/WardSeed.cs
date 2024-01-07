using UserLoginBE.Context;
using UserLoginBE.Entities.Models;

namespace UserLoginBE.Seeds
{
    public static class WardSeed
    {
        public static void WardDataSeed(UserLoginContext context)
        {
            if(!context.Ward.Any())
            {
                var datas = new List<Ward> {
                      new Ward { WardId = 1, WardName =  "Phú thọ hòa" , DistrictName="Tân Phú",DistrictId =  19 },
                 new Ward  {WardId = 2, WardName = "Bà điểm" ,DistrictName="Hóc Môn",DistrictId =  18 },
                 new Ward {WardId = 3, WardName = "Phường 2",DistrictName="Tân Bình",DistrictId = 15 },
                  new Ward {WardId = 4, WardName = "Đông Hưng Thuận",DistrictName="12", DistrictId = 12}
                };
                context.Ward.AddRange(datas);
                context.SaveChanges();
            }
        }
    }
}
