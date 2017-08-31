using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        Faculty GetFacultyByName(string facName);
        Faculty GetFacultyByCode(string code);
        bool ConfirmFactulty(string facName, string facCode);
    }
}
