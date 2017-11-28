using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private DbContext Context;
        public CityRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }
        public IEnumerable<City> GetAllCities(int stateId)
        {
            return Context.Set<City>().Where(c => c.StateId == stateId).ToList();
        }
        public City GetCity(string des)
        {
            return Context.Set<City>().Where(c => c.CityName.Trim().ToLower() == des.Trim().ToLower()).FirstOrDefault();
        }
    }
}