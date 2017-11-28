using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IGenReqRepository : IRepository<GeneralReq>
    {
        GeneralReq GetRequirement(int awrdId, int semId, bool? IsElective);
        IEnumerable<GeneralReq> GetAllGenReq(int awrdLevId);
        IEnumerable<GeneralReq> GetAllGenReqInSemester(int semId);
    }
}
