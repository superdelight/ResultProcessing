using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class ProgrammeReqRepository : Repository<ProgrammeReq>, IProgReqRepository
    {
        private DbContext Context;
        public ProgrammeReqRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }
        public IEnumerable<ProgrammeReq> GetAllProgReq(int awrdLevId)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.AwardLevelId == awrdLevId).ToList();
        }

        public IEnumerable<ProgrammeReq> GetAllProgReq(int awrdLevId, int progId)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.AwardLevelId == awrdLevId && c.ProgrammeId==progId).ToList();
        }

        public IEnumerable<ProgrammeReq> GetAllProgReqInProg(int progId)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c =>  c.ProgrammeId == progId).ToList();
        }

        public IEnumerable<ProgrammeReq> GetAllProgReqInProg(int progId, bool? IsElective)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.IsElective==IsElective && c.ProgrammeId == progId).ToList();
        }

        public IEnumerable<ProgrammeReq> GetAllProgReqInSemester(int semId)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.SemesterId==semId).ToList();
        }

        public IEnumerable<ProgrammeReq> GetAllProgReqInSemester(int semId, int progId)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.SemesterId==semId && c.ProgrammeId == progId).ToList();
        }

        public ProgrammeReq GetProgRequirement(int awrdId, int semId, int progId, bool? IsElective)
        {
            return Context.Set<Requirement>().OfType<ProgrammeReq>().Where(c => c.SemesterId == semId && c.ProgrammeId == progId && c.IsElective==IsElective).FirstOrDefault();
        }
    }
}