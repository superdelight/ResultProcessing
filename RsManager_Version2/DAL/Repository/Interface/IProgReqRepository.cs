using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IProgReqRepository : IRepository<ProgrammeReq>
    {
        ProgrammeReq GetProgRequirement(int awrdId, int semId,int progId, bool? IsElective);
        IEnumerable<ProgrammeReq> GetAllProgReq(int awrdLevId);
        IEnumerable<ProgrammeReq> GetAllProgReqInSemester(int semId);
        IEnumerable<ProgrammeReq> GetAllProgReqInProg(int progId);
        IEnumerable<ProgrammeReq> GetAllProgReq(int awrdLevId,int progId);
        IEnumerable<ProgrammeReq> GetAllProgReqInSemester(int semId,int progId);
        IEnumerable<ProgrammeReq> GetAllProgReqInProg(int progId,bool?IsElective);
    }
}
