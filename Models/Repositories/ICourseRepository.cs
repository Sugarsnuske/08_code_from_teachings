using System.Collections.Generic;

namespace ConsoleApplication.Models.Repositories
{
    public interface ICourseRepository
    {
        // basicc CRUD for Student
        void Save(Course course);
        Course Get(int id);
        IEnumerable<Course> GetAll();
        void Update(Course course);
        void Delete(int id);
    }
}
