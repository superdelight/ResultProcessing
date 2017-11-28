using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class RequiredCourseRepository : Repository<RequiredCourse>, IRequiredCourseRepository
    {
        private DbContext Context;
        public RequiredCourseRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<RequiredCourse> GetAllRequiredCourses(int reqId)
        {
            return Context.Set<RequiredCourse>().Where(c => c.RequirementId == reqId).ToList();
        }

        public RequiredCourse GetRequiredCourse(int reqId, int courseId)
        {
            return Context.Set<RequiredCourse>().Where(c => c.RequirementId == reqId && c.CourseId == courseId).FirstOrDefault();
        }
    }
}