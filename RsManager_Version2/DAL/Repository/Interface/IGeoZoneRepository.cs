using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IGeoZoneRepository : IRepository<GeoZone>
    {
        GeoZone GetCentre(string geo);
    }
}
