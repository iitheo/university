using Nicosia.Users.Models;

namespace Nicosia.Users.Data;

public interface INicosiaRepo
{
    
    IEnumerable<Course> GetAllCourses();
    Course GetCourseById(int id);
    Course CreateUser(Course course);
    Course Update(Course course);
    Course Delete(int id);

}