using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UserLoginBE.Models
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public string phoneNumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string cmnd { get; set; }
        public string CreatedAt { get; set; }
        public string Name { get; set; }
    }
}
