using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IFacReqRepository : IRepository<FacultyReq>
    {
        FacultyReq GetFacRequirement(int awrdId, int semId,int facId, bool? IsElective);
        IEnumerable<FacultyReq> GetAllFacultyReq(int awrdLevId);
        IEnumerable<FacultyReq> GetAllFacReqInSemester(int semId);
        IEnumerable<FacultyReq> GetAllFacultyReqInFac(int facId);
        IEnumerable<FacultyReq> GetAllFacReq(int awrdLevId,int facId);
        IEnumerable<FacultyReq> GetAllFacReqInSemester(int semId,int facId);
        IEnumerable<FacultyReq> GetAllFacReqInFaculty(int facId,bool?IsElective);
    }
}
