using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        private DbContext Context;
        public FacultyRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public bool ConfirmFactulty(string facName, string facCode)
        {
            try
            {
                return Context.Set<Faculty>().Where(c => c.FacName.ToLower().Equals(facName.ToLower()) ||
                 c.FacAcronyms.ToLower().Equals(facCode.ToLower())).Any();
            }
            catch(Exception ex)
            {
                return false;
            }
        }
   
        public Faculty GetFacultyByCode(string code)
        {
            return Context.Set<Faculty>().Where(c => c.FacAcronyms.ToLower().Equals(code.ToLower())).FirstOrDefault();
        }

        public Faculty GetFacultyByName(string facName)
        {
            return Context.Set<Faculty>().Where(c => c.FacName.ToLower().Equals(facName.ToLower())).FirstOrDefault();
        }

     
    }
}


