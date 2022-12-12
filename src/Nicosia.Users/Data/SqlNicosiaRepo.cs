using Nicosia.Users.Models;

namespace Nicosia.Users.Data;

public class SqlNicosiaRepo : INicosiaRepo
{
    private readonly ApplicationDbContext _context;

    public SqlNicosiaRepo(ApplicationDbContext context)
    {
        _context = context;
    }
    public bool SaveChanges()
    {
        return (_context.SaveChanges() >= 0);
    }

    public IEnumerable<Course> GetAllCourses()
    {
        return _context.Courses.ToList();
    }

    public Course GetCourseById(int id)
    {
        var course = _context.Courses.FirstOrDefault(c => c.Id == id);
        if (course == null)
        {
            throw new ArgumentNullException();
        }

        return course;
    }
    

    public Course Update(Course courseUpdated)
    {
        var course = _context.Courses.Attach(courseUpdated);
        course.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        SaveChanges();
        return courseUpdated;
    }

    public Course Delete(int id)
    {
        var course = _context.Courses.Find(id);
        if (course == null)
        {
            throw new ArgumentNullException(nameof(course));
        }
        _context.Courses.Remove(course);
        SaveChanges();

        return course;
    }

    public Course CreateUser(Course course)
    {
        if (course == null)
        {
            throw new ArgumentNullException(nameof(course));
        }

        _context.Courses.Add(course);
        SaveChanges();
        return course;
    }
}