using System.ComponentModel.DataAnnotations;

namespace Nicosia.Users.Authentication;

public class RegisterModel
{
    [Required(ErrorMessage = "User name is required")]
    [DataType(DataType.EmailAddress)]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; }
    
    
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}