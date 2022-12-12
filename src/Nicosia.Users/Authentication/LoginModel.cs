using System.ComponentModel.DataAnnotations;

namespace Nicosia.Users.Authentication;

public class LoginModel
{
    [Required(ErrorMessage = "Username is required")]
    [DataType(DataType.EmailAddress)]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}