using Microsoft.AspNetCore.Identity;

namespace Nicosia.Users.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public string SocialInsuranceNumber { get; set; }
}