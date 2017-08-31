using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ICourseRepository : IRepository<Course>
    {
        int UploadCourses(IEnumerable<Course> Courses);
        Course GetCourseByTitle(string title);
        Course GetCourseByCode(string code);
        bool ConfirmCourse(string courseTitle, string code);
        IEnumerable<Course> GetAllCourses(int deptId);
    }
}
