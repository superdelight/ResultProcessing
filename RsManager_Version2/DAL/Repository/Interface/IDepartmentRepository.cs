using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetDepartmentByName(string deptName);
        Department GetDepartmentByCode(string code);
        bool ConfirmDepartment(string deptName, string deptCode);
        IEnumerable<Department> GetAllDepartment(int facId);
    }
}
