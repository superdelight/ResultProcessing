using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ILevelRepository : IRepository<Level>
    {

        IEnumerable<Level> GetAllLevels(int awrdId);
        Level GetLevel(string des);
       

    }
}
