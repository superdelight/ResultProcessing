using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        private DbContext Context;
        public StateRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<State> GetAllStates(int zoneId)
        {
            return Context.Set<State>().Where(c => c.GeoZoneId == zoneId);
        }

        public State GetState(string name)
        {
            return Context.Set<State>().Where(c => c.Description.ToLower().Trim() == name.ToLower().Trim()).FirstOrDefault();
        }
    }
}