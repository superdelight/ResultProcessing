using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class ResultLINQ:IResultLINQ
    {
           private readonly ResultMEntities _Context;
        public ResultLINQ()
        {
            _Context = new DAL.ResultMEntities();
            SchoolContext = new SchoolRepository(_Context);
            FacultyContext = new FacultyRepository(_Context);
            CourseContext = new CourseRepository(_Context);
        }

        public ICourseRepository CourseContext { get; private set; } 
       

        public IFacultyRepository FacultyContext { get; private set; }      
        public ISchoolRepository SchoolContext { get; private set;}
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return _Context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}
