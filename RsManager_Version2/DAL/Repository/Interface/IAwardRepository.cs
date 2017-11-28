using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IAwardRepository : IRepository<Award>
    {
        Award GetAward(string acronym, string description);
        IEnumerable<Award> GetAllAwards(int levId);
    }
}
