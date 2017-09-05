using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class ProgrammeRepository : Repository<Programme>, IProgrammeRepository
    {
        private DbContext Context;
        public ProgrammeRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }
        public bool ConfirmProgramme(string programCode, string programDes)
        {
            return Context.Set<Programme>().Where(c => c.ProgrammeCode.ToLower().Equals(programCode.ToLower()) ||
            c.ProgrammeDescription.ToLower().Equals(programDes.ToLower())).Any();
        }
        public IEnumerable<Programme> GetAllProgramme(int deptId)
        {
            return Context.Set<Programme>().Where(x => x.deptId == deptId).ToList();
        }
        public Programme GetProgramme(string programCode, string programDes)
        {
            return Context.Set<Programme>().Where(c => c.ProgrammeCode.ToLower().Equals(programCode.ToLower()) ||
              c.ProgrammeDescription.ToLower().Equals(programDes.ToLower())).FirstOrDefault();
        }
    }
}