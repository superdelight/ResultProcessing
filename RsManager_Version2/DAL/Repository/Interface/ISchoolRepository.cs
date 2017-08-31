using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ISchoolRepository : IRepository<School>
    {
        School GetSchoolByName(string schoolName);
        School GetActiveSchool();
        bool ControlActivation(bool flag,int schoolId);
    }
}
