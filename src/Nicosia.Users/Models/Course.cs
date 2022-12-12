using System.ComponentModel.DataAnnotations;

namespace Nicosia.Users.Models;

public class Course
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string CourseCode { get; set; }
    
    [Required]
    public string CourseTitle { get; set; }
    
    [Required]
    public string EctsCredits { get; set; }
}