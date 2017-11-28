using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IAwardLevelRepository : IRepository<AwardLevel>
    {
        AwardLevel GetAwardLevel(int levId,int awardId);
        IEnumerable<AwardLevel> GetAllAwardLevel(int awardId);
        IEnumerable<AwardLevel> GetAllAwardLevelByLevel(int levId);
    }
}
