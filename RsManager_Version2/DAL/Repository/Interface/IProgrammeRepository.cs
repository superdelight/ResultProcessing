using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IProgrammeRepository : IRepository<Programme>
    {

        bool ConfirmProgramme(string programCode, string programDes);
        Programme GetProgramme(string programCode, string programDes);
        IEnumerable<Programme> GetAllProgramme(int deptId);

    }
}
