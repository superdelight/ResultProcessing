using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class LGARepository : Repository<LGA>, ILGARepository
    {
        private DbContext Context;
        public LGARepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }
        public IEnumerable<LGA> GetAllLGA(int stateId)
        {
            return Context.Set<LGA>().Where(c => c.StateId == stateId).ToList();
        }
    }
}