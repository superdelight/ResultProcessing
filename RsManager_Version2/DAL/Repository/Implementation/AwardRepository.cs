using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class AwardRepository : Repository<Award>, IAwardRepository
    {
        private DbContext Context;
        public AwardRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<Award> GetAllAwards(int levId)
        {
            return Context.Set<AwardLevel>().Where(c => c.LevelId == levId).Select(m => m.Award);
        }

        public Award GetAward(string acronym, string description)
        {
            return Context.Set<Award>().Where(c => c.AwardAcronyms.ToLower().Trim() == acronym.ToLower().Trim() || c.AwardName.ToLower().Trim() == description.ToLower().Trim()).FirstOrDefault();
        }
    }
}