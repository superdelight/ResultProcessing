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
           private readonly ResultMEntities Context;
        public ResultLINQ(ResultMEntities Context)
        {
            SchoolContext = new SchoolRepository(Context);
            FacultyContext = new FacultyRepository(Context);
        }
        public IFacultyRepository FacultyContext { get; private set; }      
        public ISchoolRepository SchoolContext { get; private set;}
        public void Dispose()
        {
            Context.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}
