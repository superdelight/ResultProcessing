using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        private DAL.ResultMEntities Context;
        public FacultyRepository(DAL.ResultMEntities Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public bool ConfirmFactulty(string facName, string facCode)
        {
            return Context.Faculties.Where(c => c.FacName.ToLower().Equals(facName.ToLower()) ||
            c.FacAcronyms.ToLower().Equals(facCode.ToLower())).Any();
        }
   
        public Faculty GetFacultyByCode(string code)
        {
            return Context.Faculties.Where(c => c.FacAcronyms.ToLower().Equals(code.ToLower())).FirstOrDefault();
        }

        public Faculty GetFacultyByName(string facName)
        {
            return Context.Faculties.Where(c => c.FacName.ToLower().Equals(facName.ToLower())).FirstOrDefault();
        }

     
    }
}


