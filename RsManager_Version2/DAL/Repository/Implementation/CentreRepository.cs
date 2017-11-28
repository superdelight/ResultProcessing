using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class CentreRepository : Repository<Centre>, ICentreRepository
    {
        private DbContext Context;
        public CentreRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<Centre> GetAllCentresinCity(int cityId)
        {
            return (from c in Context.Set<Centre>() where c.CityId==cityId select c).ToList();
        }

        public IEnumerable<Centre> GetAllCentresinState(int stateId)
        {
            return (from c in Context.Set<Centre>() where c.City.StateId == stateId select c).ToList();
        }

        public Centre GetCentre(string centreCode)
        {
            return Context.Set<Centre>().Where(c => c.CentreCode.ToLower().Trim() == centreCode.ToLower().Trim()).FirstOrDefault();
        }
    }
}