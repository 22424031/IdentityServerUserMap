using System.ComponentModel.DataAnnotations;

namespace UserLoginBE.Entities.Models
{
    public class Ward
    {
        [Key]
        public int WardId { get; set; }
        public string WardName { get; set; }
        public string DistrictName { get; set; }
        public int DistrictId { get; set; }
    }
}
