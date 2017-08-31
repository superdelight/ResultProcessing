using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private DbContext Context;
        public CourseRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public bool ConfirmCourse(string courseTitle, string code)
        {
            return Context.Set<Course>().Where(c => c.CourseTitle.ToLower().Equals(courseTitle.ToLower()) ||
            c.CourseCode.ToLower().Equals(code.ToLower())).Any();
        }

   
        public IEnumerable<Course> GetAllCourses(int deptId)
        {
            return Context.Set<Course>().Where(d => d.DeptId.Equals(deptId));
        }

     

        public Course GetCourseByCode(string code)
        {
            return Context.Set<Course>().Where(c => c.CourseCode.ToLower().Equals(code.ToLower())).FirstOrDefault();
        }

        public Course GetCourseByTitle(string title)
        {
            return Context.Set<Course>().Where(c => c.CourseTitle.ToLower().Equals(title.ToLower())).FirstOrDefault();
        }

        public int UploadCourses(IEnumerable<Course> Courses)
        {
            int count = 0;
            foreach(var c in Courses)
            {
                if (ConfirmCourse(c.CourseTitle, c.CourseCode) == false)
                {
                    Context.Set<Course>().Add(c);
                    count++;
                }
            }
            return count;
        }
    }
}