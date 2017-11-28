using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class AwardLevelRepository : Repository<AwardLevel>, IAwardLevelRepository
    {
        private DbContext Context;
        public AwardLevelRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<AwardLevel> GetAllAwardLevel(int awardId)
        {
            return Context.Set<AwardLevel>().Where(c => c.AwardId == awardId).ToList();
        }

        public IEnumerable<AwardLevel> GetAllAwardLevelByLevel(int levId)
        {
            return Context.Set<AwardLevel>().Where(c => c.LevelId == levId).ToList();
        }

        public AwardLevel GetAwardLevel(int levId, int awardId)
        {
            return Context.Set<AwardLevel>().Where(c => c.AwardId == awardId && c.LevelId == levId).FirstOrDefault();
        }
    }
}