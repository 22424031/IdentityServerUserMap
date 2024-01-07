using Microsoft.EntityFrameworkCore;
using UserLoginBE.Context;
using UserLoginBE.Entities.Models;

namespace UserLoginBE.Seeds
{
    public static class DistrictSeed
    {
        public static void DistrictDataSeed(UserLoginContext context)
        {

            if (!context.District.Any())
            {
                var datas = new List<District> {
                    new District { DistrictId = 19, DistrictName = "Tân Phú" },
                       new District { DistrictId = 18, DistrictName = "Hóc Môn" },
                      new District { DistrictId = 17, DistrictName = "Củ Chi" },
                      new District { DistrictId = 16, DistrictName = "Bình Chánh" },
                      new District { DistrictId = 15, DistrictName = "Tân Bình" },
                      new District { DistrictId = 14, DistrictName = "Bình Thạnh" },
                      new District { DistrictId = 13, DistrictName = "Phú Nhuận" },
                     new District { DistrictId = 12, DistrictName = "12" },
                     new District { DistrictId = 11, DistrictName = "11" },
                     new District { DistrictId = 1, DistrictName = "1" },
                     new District { DistrictId = 2, DistrictName = "2" },
                     new District { DistrictId = 3, DistrictName = "3" },
                     new District { DistrictId = 4, DistrictName = "4" },
                     new District { DistrictId = 5, DistrictName = "5" },
                     new District { DistrictId = 6, DistrictName = "6" },
                     new District { DistrictId = 7, DistrictName = "7" },
                     new District { DistrictId = 8, DistrictName = "8" },
                     new District { DistrictId = 9, DistrictName = "9" },
                     new District { DistrictId = 10, DistrictName = "10" }
                };
                context.District.AddRange(datas);
                context.SaveChanges();
            }
           
        }
    }
}
