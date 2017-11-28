using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ICityRepository : IRepository<City>
    {
        City GetCity(string des);
        IEnumerable<City> GetAllCities(int stateId);
      
    }
}
