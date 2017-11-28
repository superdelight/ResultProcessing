using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class FacultyReqRepository : Repository<FacultyReq>, IFacReqRepository
    {
        private DbContext Context;
        public FacultyReqRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<FacultyReq> GetAllFacReq(int awrdLevId, int facId)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.AwardLevelId == awrdLevId && c.FacultyId == facId select c).ToList();
        }

        public IEnumerable<FacultyReq> GetAllFacReqInFaculty(int facId, bool? IsElective)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.IsElective==IsElective && c.FacultyId == facId select c).ToList();
        }

        public IEnumerable<FacultyReq> GetAllFacReqInSemester(int semId)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.SemesterId==semId select c).ToList();
        }

        public IEnumerable<FacultyReq> GetAllFacReqInSemester(int semId, int facId)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.SemesterId == semId && c.FacultyId == facId select c).ToList();
        }

        public IEnumerable<FacultyReq> GetAllFacultyReq(int awrdLevId)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.AwardLevelId == awrdLevId select c).ToList();
        }

        public IEnumerable<FacultyReq> GetAllFacultyReqInFac(int facId)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.FacultyId == facId select c).ToList();
        }

        public FacultyReq GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective)
        {
            return (from c in Context.Set<Requirement>().OfType<FacultyReq>() where c.AwardLevelId == awrdId && c.FacultyId == facId && c.SemesterId==semId && c.IsElective==IsElective select c).FirstOrDefault();
        }
    }
}