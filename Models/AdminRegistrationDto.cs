using System.ComponentModel.DataAnnotations;

namespace UserLoginBE.Models
{
    public class AdminRegistrationDto
    {
       
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            [Required(ErrorMessage = "Username is required")]
            public string UserName { get; set; } = string.Empty;
            [Required(ErrorMessage = "Password is required")]
            public string Password { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string PhoneNumber { get; set; } = string.Empty;
            public ICollection<string> Roles { get; set; } = new LinkedList<string>();
            public string Ward {  get; set; } = string.Empty;
            public string District { get; set; } = string.Empty;
        
    }
}
