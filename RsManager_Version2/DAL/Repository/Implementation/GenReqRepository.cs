using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class GenReqRepository : Repository<GeneralReq>, IGenReqRepository
    {
        private DbContext Context;
        public GenReqRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<GeneralReq> GetAllGenReq(int awrdLevId)
        {
            return Context.Set<Requirement>().OfType<GeneralReq>().Where(c => c.AwardLevelId == awrdLevId).ToList();
        }

        public IEnumerable<GeneralReq> GetAllGenReqInSemester(int semId)
        {
            return Context.Set<Requirement>().OfType<GeneralReq>().Where(c => c.SemesterId == semId).ToList();
        }

        public GeneralReq GetRequirement(int awrdId, int semId, bool? IsElective)
        {
            return Context.Set<Requirement>().OfType<GeneralReq>().Where(c => c.AwardLevelId == awrdId && c.SemesterId==semId && c.IsElective==IsElective).FirstOrDefault();
        }
    }
}