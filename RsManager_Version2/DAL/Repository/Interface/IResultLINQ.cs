using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IResultLINQ : IDisposable
    {
        ISchoolRepository SchoolContext { get;}
        IFacultyRepository FacultyContext { get; }
        ICourseRepository CourseContext { get; }
        int SaveChanges();
    }
}
