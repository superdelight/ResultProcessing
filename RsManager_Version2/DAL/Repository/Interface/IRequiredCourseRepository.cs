using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IRequiredCourseRepository : IRepository<RequiredCourse>
    {
        RequiredCourse GetRequiredCourse(int reqId, int courseId);
        IEnumerable<RequiredCourse> GetAllRequiredCourses(int reqId);
    }
}
