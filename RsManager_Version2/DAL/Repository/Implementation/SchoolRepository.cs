using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        private DAL.ResultMEntities Context;
        public SchoolRepository(DAL.ResultMEntities Context)
            : base(Context)
        {
            this.Context = Context;
        }
        public bool ControlActivation(bool flag,int schoolId)
        {
            var school = Context.Schools.Where(d => d.Id == schoolId).FirstOrDefault();
            if(school!=null)
            {
                school.IsVisible = flag;
                int count=Context.SaveChanges();
                if(count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public School GetActiveSchool()
        {
            return Context.Schools.Where(d => d.IsVisible == true).FirstOrDefault();
        }

        public School GetSchoolByName(string schoolName)
        {
            return Context.Schools.Where(d => d.SchoolName.ToLower() == schoolName.ToLower()).FirstOrDefault();
        }
    }
}


