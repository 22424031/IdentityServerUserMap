using System.ComponentModel.DataAnnotations;

namespace UserLoginBE.Entities.Models
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
   
    }
}
