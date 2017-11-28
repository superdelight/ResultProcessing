using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ILGARepository : IRepository<LGA>
    {
        IEnumerable<LGA> GetAllLGA(int stateId);
      
    }
}
