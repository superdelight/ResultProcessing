using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class GeoZoneRepository : Repository<GeoZone>, IGeoZoneRepository
    {
        private DbContext Context;
        public GeoZoneRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public GeoZone GetCentre(string geo)
        {
            return Context.Set<GeoZone>().Where(c => c.Description.ToLower().Trim() == geo.Trim().ToLower()).FirstOrDefault();
        }
    }
}