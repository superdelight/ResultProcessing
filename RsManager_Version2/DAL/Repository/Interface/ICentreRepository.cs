using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ICentreRepository : IRepository<Centre>
    {
        IEnumerable<Centre> GetAllCentresinState(int stateId);
        IEnumerable<Centre> GetAllCentresinCity(int cityId);
        Centre GetCentre(string centreCode);
    }
}
